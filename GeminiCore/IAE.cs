/**
 * Josh Simmons and Shane Hayfcz
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace GeminiCore
{
   public class IAE
    {

       

        //TODO list,
        //catch malformed line exception syntax errors in first pass
        //fix error throwing in resolve labels and setting list item to new string
        //second pass: finish breaking because label does not exist

        // Dictionary containing instructing string, short binary value pairs
        Dictionary<string, short> instructDic;

        // Dictionary containing labels and their line numbers
        Dictionary<string, short> labelDic = new Dictionary<string, short>();

        // Dictionary of branch instructions to be resolved to line numbers
        Dictionary<string, short> toResolve = new Dictionary<string, short>();

        //instructions parsed from file
        List<string> instructions = new List<string>();

        //
        List<short> shorts = new List<short>();

        //regex patterns for labels, instructions in general, and branch instructions
       private static string commentPattern = @"!.*";
        private static string labelPattern = @"(([a-zA-Z]*)+:)";
        private static string instructPattern = @"([a-z])+([ /w]*)+(([$]+[0-9]*)|([#$]+[0-9]*)|[a-z]*)";
        private static string branchPattern = @"((bl)|(bg)|(ba)|(be))+([ /w]*)+([a-zA-Z]+)";
        private static string whitespacePattern = @"";

        //Regex objects
        Regex whitespaceRgx = new Regex(whitespacePattern);
        Regex commentRgx = new Regex(commentPattern);
        Regex instructRgx = new Regex(instructPattern);
        Regex labelRgx = new Regex(labelPattern);
        Regex branchRgx = new Regex(branchPattern);

        /// <summary>
        /// performs all the work required to assemble a file into binary
        /// </summary>
        public void Assemble(string path)
        {
            string[] insArray = File.ReadAllLines(path);
            instructions = insArray.ToList();
            buildInstructDic();
            firstPass(instructions);
            resolveLabels();
            secondPass(instructions);
            writeShorts(@"C:\Users\joebo_000\Source\Repos\Gemini\GeminiCPU\instructs.bin");
         
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
        }


        private void firstPass(List<string> instructs)
        {
            for (int i = instructions.Count - 1; i >= 0; i--)
            {
                string currentInstruct = instructs.ElementAt(i).Trim();
                MatchCollection commented = commentRgx.Matches(currentInstruct);
                if(commented.Count == 1){
                currentInstruct = parseComment(currentInstruct);
                instructs[i] = currentInstruct.Trim();
                }
                MatchCollection match = instructRgx.Matches(currentInstruct);
                MatchCollection labelMatch = labelRgx.Matches(currentInstruct);
               

                if ((match.Count == 1)||(match.Count == 2))
                {
                    if (labelMatch.Count == 1)
                    {
                        string labelName = currentInstruct.Trim();
                        labelName = labelName.TrimEnd(labelName[labelName.Length - 1]);
                        labelDic.Add(labelName, (short)(i + 2));
                        instructs.RemoveAt(i);
                    }
                   
                    else
                    {
                    
                    }
                }
                else
                {
                    MatchCollection whitespaceMatch = whitespaceRgx.Matches(whitespacePattern);
                    if ((currentInstruct == "")||(whitespaceMatch.Count == 1))
                    {
                        instructs.RemoveAt(i);
                    }
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
                    //value includes iflag ORed in
                    short value = 0;

                    MatchCollection branchMatch = branchRgx.Matches(instruction);
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
                        case 10:
                        case 15:
                        case 16:
                            break;
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        
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
                //break cause of syntax/no such op
               // Console.WriteLine("op not found");
            }
        }

        private void writeShorts(string name){
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (short binshort in shorts)
                    {
                        bw.Write(binshort);
                    }
                }
            }
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
   }
}
