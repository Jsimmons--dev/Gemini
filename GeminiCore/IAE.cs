/*
 Joshua Simmons and Shane Hayfcz
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
namespace GeminiCore
{
    public class IAE
    {

        int MEM_SIZE = 256;

        // Dictionary containing instruction string, short binary value pairs
        Dictionary<string, short> instructDic;
        //a dictionary that is the reverse of the above dictionary
        //more overhead but faster reverse lookup
        Dictionary<short, string> reverseInsDic;

        List<int> branchList = new List<int>();

        // Dictionary containing labels and their line numbers
        Dictionary<string, short> labelDic = new Dictionary<string, short>();

        public void resetLabelDic()
        {
            labelDic.Clear();
        }

        // Dictionary of branch instructions to be resolved to line numbers
        Dictionary<string, short> toResolve = new Dictionary<string, short>();

        //instructions parsed from file
        List<string> dirtyInstructions = new List<string>();

        //list of shorts: a short is added once the instructions have been translated
        List<short> shorts = new List<short>();

        //path of file to open
        public string path;

        //regex patterns for labels, instructions in general, and branch instructions
        private static string commentPattern = @"!.*";
        private static string whitespacePattern = @"^\s*$";

        //Regex objects
        Regex commentRgx = new Regex(commentPattern);
        Regex whitespaceRgx = new Regex(whitespacePattern);

        /// <summary>
        /// performs all the work required to assemble a file into binary
        /// </summary>
        public void Assemble(string path, string filename)
        {
            string[] insArray = File.ReadAllLines(Path.GetFullPath(path));
            dirtyInstructions = insArray.ToList();
            buildInstructDic();
            firstPass(dirtyInstructions);
            secondPass(dirtyInstructions);
            writeShorts(filename);
        }

        /// <summary>
        /// builds the instruction dictionary where the key is the name and the value is the
        /// short representing its bit representation
        /// </summary>
        private void buildInstructDic()
        {
            instructDic = new Dictionary<string, short>();
            instructDic.Add("lda", 1);
            instructDic.Add("sta", 2);
            instructDic.Add("add", 3);
            instructDic.Add("sub", 4);
            instructDic.Add("mul", 5);
            instructDic.Add("div", 6);
            instructDic.Add("and", 7);
            instructDic.Add("or", 8);
            instructDic.Add("shl", 9);
            instructDic.Add("nota", 10);
            instructDic.Add("ba", 11);
            instructDic.Add("be", 12);
            instructDic.Add("bl", 13);
            instructDic.Add("bg", 14);
            instructDic.Add("nop", 15);
            instructDic.Add("hlt", 16);

            reverseInsDic = instructDic.ToDictionary(x => x.Value, x => x.Key);
        }

        //
        private void firstPass(List<string> dirtIinstructions)
        {
            for (int i = 0; i < dirtyInstructions.Count; i++)
            {
                string currentInstruct = dirtyInstructions.ElementAt(i);
                dirtyInstructions[i] = commentRgx.Replace(currentInstruct, "");
                dirtyInstructions[i] = whitespaceRgx.Replace(dirtyInstructions[i], "");
                currentInstruct = dirtyInstructions[i];
                if (currentInstruct == "")
                {
                    dirtyInstructions.RemoveAt(i);
                    i--;
                    continue;
                }
                //char[] delimiters = { ' ','\t' };
                string[] split = Regex.Split(currentInstruct.Trim(),@"\s");
                string cmd = split[0];
                if (cmd.IndexOf(':') != -1)
                {
                    if (split.Length != 1)
                    {
                        throw new ArgMismatchException();
                    }
                    else
                    {
                        if (cmd.IndexOf(':') != cmd.Length - 1)
                        {
                            throw new InvalidLabelNameException();
                        }
                        labelDic.Add(cmd.Substring(0, cmd.Length - 1), (short)(i+1));
                        dirtyInstructions.RemoveAt(i);
                        i--;
                        continue;
                    }
                }
                else
                {
                    try
                    {
                        short cmdNum = instructDic[cmd];
                        if (cmdNum == 10 || cmdNum == 15 || cmdNum == 16)
                        {
                            if (split.Length != 1)
                            {
                                throw new ArgMismatchException();
                            }
                        }
                        else
                        {
                            if (split.Length != 2)
                            {
                                throw new ArgMismatchException();
                            }
                            else
                            {
                                if (cmdNum == 11 || cmdNum == 12 || cmdNum == 13 || cmdNum == 14)
                                {
                                    branchList.Add(i);
                                }
                                else
                                {
                                    string arg = split[1];
                                    if (arg[0] != '$')
                                    {
                                        if(arg[0] == '#')
                                        {
                                            if(arg[1] != '$')
                                            {
                                                throw new InvalidArgFormattingException();
                                            }
                                            continue;
                                        }
                                        throw new InvalidArgFormattingException();
                                    }
                                    else
                                    {
                                        if (arg[0] == '$')
                                        {
                                            try
                                            {
                                                Convert.ToInt32(arg.Substring(1, arg.Length - 1));
                                            }
                                            catch (FormatException exception)
                                            {
                                                throw new InvalidArgFormattingException();
                                            }
                                        }
                                        else if (arg[0] == '#' && arg[1] == '$')
                                        {
                                            try
                                            {
                                                Convert.ToInt32(arg.Substring(2, arg.Length - 1));
                                            }
                                            catch (FormatException exception)
                                            {
                                                throw new InvalidArgFormattingException();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (KeyNotFoundException exception)
                    {
                        throw new InvalidCommandException();
                    }
                }
            }
        }

        private void secondPass(List<string> instructions)
        {
            foreach (string instruction in instructions)
            {
                string[] pieces = instruction.Trim().Split();
                short op = instructDic[pieces[0]];
                short value = 0;
                switch (op)
                {
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        value = immOrMem(pieces[1]);
                        break;
                    case 2:
                        value = mem(pieces[1]);
                        break;
                    case 9:
                        value = imm(pieces[1]);
                        break;
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                        try
                        {
                            value = labelDic[pieces[1]];
                        } 
                        catch(KeyNotFoundException exception)
                        {
                            throw new InvalidLabelNameException();
                        }
                        break;
                    default:
                        break;

                }

                short op32 = (short)((int)(op) << 9);
                short bits = (short)((int)op32 | (int)value);
                shorts.Add(bits);
            }
        }

        private void writeShorts(string newASMFile)
        {
            FileStream binFile = File.Create(Path.GetFullPath("../../" + newASMFile));
            BinaryWriter bw = new BinaryWriter(binFile);
            foreach (short bin in shorts)
            {
                bw.Write(bin);
            }
            bw.Close();
        }

        /// <summary>
        /// takes a string and determines if it is an immediate or a memory address,
        /// if immediate set iFlag,
        /// then set value to number after #$ or $
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        private short immOrMem(string argument)
        {
            short iFlag = 0;
            short value = 0;
            string redo = "";
            char[] arg = argument.ToCharArray();
            if (arg[0] == '#')
            {
                iFlag = 1;
                for (int i = 2; i < arg.Length; i++)
                {
                    redo += arg[i];
                }
            }
            else
            {
                for (int i = 1; i < arg.Length; i++)
                {
                    redo += arg[i];
                }
            }
            value = Convert.ToInt16(redo);
            iFlag = (short)((iFlag) << 8);
            return (short)((int)iFlag | (int)value);

        }

        private short mem(string argument)
        {
            short value = 0;
            char[] arg = argument.ToCharArray();
            string redo = "";
            for (int i = 1; i < arg.Length; i++)
            {
                redo += arg[i];
            }
            value = Convert.ToInt16(redo);
            if (value > MEM_SIZE)
            {
                throw new SegFaultException();
            }
            return value;
        }

        private short imm(string argument)
        {
            short iFlag = 1;
            short value = 0;
            char[] arg = argument.ToCharArray();
            string redo = "";
            for (int i = 2; i < arg.Length; i++)
            {
                redo += arg[i];
            }

            value = Convert.ToInt16(redo);
            iFlag = (short)((iFlag) << 8);
            return (short)((int)iFlag | (int)value);

        }

        private short lbl(string argument)
        {
            // short value = 0;
            //value =  Convert.ToInt16(argument);
            return labelDic[argument];
        }

        public string parseComment(string instruct)
        {
            if (instruct.IndexOf("!") == 0)
            {
                return "";
            }
            return instruct.Substring(0, instruct.IndexOf("!") - 1).Trim();
        }


        public string binaryParse(short bin)
        {
            int negativeOp = 65024;
            int negativeIFlag = 256;
            int negativeValue = 255;
            int op = 0;
            int iFlag = 0;
            int value = 0;
            op = (bin & negativeOp) >> 9;
            iFlag = (bin & negativeIFlag) >> 8;
            value = (bin & negativeValue);
            string symbols;
            switch (op)
            {
                case 11:
                case 12:
                case 13:
                case 14:
                    symbols = "";
                    break;
                default:
                    if (iFlag == 1)
                    {
                        symbols = "#$";
                    }
                    else
                    {
                        symbols = "$";
                    }
                    break;
            }
            return reverseInsDic[(short)op] + " " + symbols + value.ToString();
        }

        public List<short> readBinFile()
        {
            List<short> ins = new List<short>();
            FileStream file = File.Open(Path.GetFullPath("../../g.out"), FileMode.Open);
            using (var reader = new BinaryReader(file))
            {
                try
                {
                    while (true)
                    {
                        ins.Add(reader.ReadInt16());
                    }
                }
                catch (EndOfStreamException e)
                {

                }
                return ins;
            }
        }
    }
}
