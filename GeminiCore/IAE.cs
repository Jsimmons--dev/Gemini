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

       int MEM_SIZE = 255;

        // Dictionary containing instructing string, short binary value pairs
        Dictionary<string, short> instructDic;
       //a dictionary that is the reverse of the above dictionary
        Dictionary<short, string> reverseInsDic;

        // Dictionary containing labels and their line numbers
        Dictionary<string, short> labelDic = new Dictionary<string, short>();

        public void resetLabelDic()
        {
            labelDic = new Dictionary<string, short>();
        }

        // Dictionary of branch instructions to be resolved to line numbers
        Dictionary<string, short> toResolve = new Dictionary<string, short>();

        //instructions parsed from file
        List<string> instructions = new List<string>();

       //list of shorts: a short is added once the instructions have been translated
        List<short> shorts = new List<short>();

       //path of file to open
        public string path;

        //regex patterns for labels, instructions in general, and branch instructions
       private static string commentPattern = @"!.*";
        private static string labelPattern = @"(([a-zA-Z]*)+:)";
        private static string instructPattern = @"([a-z])+([ /w]*)+(([$]+[0-9]*)|([#$]+[0-9]*)|[a-z]*)";
        private static string branchPattern = @"((bl)|(bg)|(ba)|(be))+([ /w]*)+([a-zA-Z]+)";
        private static string whitespacePattern = @"\s*|\t*";

        //Regex objects
        Regex whitespaceRgx = new Regex(whitespacePattern);
        Regex commentRgx = new Regex(commentPattern);
        Regex instructRgx = new Regex(instructPattern);
        Regex labelRgx = new Regex(labelPattern);
        Regex branchRgx = new Regex(branchPattern);

        /// <summary>
        /// performs all the work required to assemble a file into binary
        /// </summary>
        public void Assemble(string path,string filename)
        {
            string[] insArray = File.ReadAllLines(Path.GetFullPath(path));
            instructions = insArray.ToList();
            buildInstructDic();
            zerothPass();
            firstPass(instructions);
            resolveLabels();
            secondPass(instructions);
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


        private void zerothPass()
        {
                for (int i = instructions.Count - 1; i >= 0; i--)
                {
                    MatchCollection whitespaceMatch = whitespaceRgx.Matches(whitespacePattern);
                    instructions[i] = Regex.Replace(instructions[i],@"\s+"," ");
                    if ((instructions[i] == "") || (instructions[i] == " ") ||(whitespaceMatch.Count == 1))
                    {
                        instructions.RemoveAt(i);
                    }
                }
        }

        private void firstPass(List<string> instructs)
        {
            for (int i = instructions.Count - 1; i >= 0; i--)
            {
                string currentInstruct = instructs.ElementAt(i).Trim();

                MatchCollection commented = commentRgx.Matches(currentInstruct);

                //checks if instruction has a comment
                if(commented.Count == 1){
                currentInstruct = parseComment(currentInstruct);
                instructs[i] = currentInstruct.Trim();
                string[] split = instructs[i].Split(null);
                if (split.Count() > 3)
                {
                    throw new SyntaxException();
                }
                }
                MatchCollection InstructionMatch = instructRgx.Matches(currentInstruct);
                if ((InstructionMatch.Count == 1)||(InstructionMatch.Count == 2))
                {
                    MatchCollection labelMatch = labelRgx.Matches(currentInstruct);

                    if (labelMatch.Count == 1)
                    {
                        string labelName = currentInstruct.Trim();
                        labelName = labelName.TrimEnd(labelName[labelName.Length - 1]);
                        labelDic.Add(labelName, (short)((i+2)));
                        instructs.RemoveAt(i);
                        foreach (string label in labelDic.Keys.ToList())
                        {
                            labelDic[label] -= 1;
                        }
                    }

                    else
                    {

                    }
                }
                else
                {

                }
            }

        }

        private void resolveLabels()
        {

        }

        private void secondPass(List<string> instructions)
        {
            try
            {
                foreach (string instruction in instructions)
                {
                    string[] pieces = instruction.Trim().Split();
                    short op = instructDic[pieces[0]];
                    //value includes iFlag OR-ed in
                    short value = 0;

                    MatchCollection branchMatch = branchRgx.Matches(instruction);
                    //resolves branches
                    if ((branchMatch.Count == 1))
                    {

                                string instruct = instruction.Trim();
                                string[] instructPieces = instruct.Split();
                                string labelName = instructPieces[1].Trim();
                                short branchValue = labelDic[labelName];
                                pieces[1] = branchValue.ToString();
                                value = Convert.ToInt16(pieces[1]);

                            }

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
                        default:
                            break;

                    }

                   short op32 = (short)((int)(op) << 9);
                   short bits = (short)((int)op32 | (int)value);
                   shorts.Add(bits);
                }
            }
            catch (KeyNotFoundException e)
            {
                MessageBox.Show("Key Not Found Error");
            }
        }

        private void writeShorts(string newASMFile)
        {
            FileStream binFile = File.Create(Path.GetFullPath("../../" + newASMFile));
            BinaryWriter bw = new BinaryWriter(binFile);
                foreach(short bin in shorts){
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
            if(arg[0] == '#'){
                iFlag = 1;
                for (int i = 2; i < arg.Length;i++)
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
            if(value > MEM_SIZE){
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

        public string parseComment(string instruct){
            return instruct.Substring(0,instruct.IndexOf("!")-1).Trim();
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
                    if(iFlag == 1){
                        symbols = "#$";
                    }
                    else {
                        symbols = "$";
                    }
                    break;
            }
            return reverseInsDic[(short)op] + " " + symbols + value.ToString();
        }

       public List<short> readBinFile()
        {
           List<short>  ins = new List<short>();
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
