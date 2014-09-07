/**
 * Josh Simmons and Shane Hayfcz
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GeminiCore
{
    class IAE
    {

        //TODO list,
        //catch malformed line exception syntax errors in first pass
        //fix error throwing in resolve labels and setting list item to new string
        //second pass: finish breaking because label does not exist
        //second pass: finish cases
        //second pass: OR all values
        //second pass: write to file

        // Dictionary containing instructing string, short binary value pairs
        Dictionary<string, short> instructDic;
        
        // Dictionary containing labels and their line numbers
        Dictionary<string, short> labelDic = new Dictionary<string, short>();

        // Dictionary of branch instructions to be resolved to line numbers
        Dictionary<string, short> toResolve = new Dictionary<string, short>();

        //instructions parsed from file
        List<string> instructions = new List<string>();

        //regex patterns for labels, instructions in general, and branch instructions
        private static string labelPattern = @"(([a-zA-Z]*)+:)";
        private static string instructPattern = @"([A-Z])+([ /w]*)+(([$]+[0-9]*)|([#$]+[0-9]*)|[a-z]*)+([ /w]*)|(!.*)";
        private static string branchPattern = @"([B]+[A|E|G|L])+([ /w]*)+([a-zA-Z]*)+([ /w]*)|(!.*)";

        //Regex objects
        Regex instructRgx = new Regex(instructPattern);
        Regex labelRgx = new Regex(labelPattern);
        Regex branchRgx = new Regex(branchPattern);

        /// <summary>
        /// performs all the work required to assemble a file into binary
        /// </summary>
        private void Assemble()
        {
            buildInstructDic();
            firstPass(instructions);
            resolveLabels();
            secondPass(instructions);
        }

        /// <summary>
        /// builds the instruction dictionary where the key is the name and the value is the 
        /// short representing its bit representation
        /// </summary>
        private void buildInstructDic()
        {
            instructDic = new Dictionary<string, short>();
            instructDic.Add("LDA", 1);
            instructDic.Add("STA", 2);
            instructDic.Add("ADD", 3);
            instructDic.Add("SUB", 4);
            instructDic.Add("MUL", 5);
            instructDic.Add("DIV", 6);
            instructDic.Add("AND", 7);
            instructDic.Add("OR", 8);
            instructDic.Add("SHL", 9);
            instructDic.Add("NOTA", 10);
            instructDic.Add("BA", 11);
            instructDic.Add("BE", 12);
            instructDic.Add("BL", 13);
            instructDic.Add("BG", 14);
            instructDic.Add("NOP", 15);
            instructDic.Add("HLT", 16);
        }


        private void firstPass(List<string> instructs)
        {
            for (int i = instructions.Count - 1; i >= 0; i--)
            {
                MatchCollection match = instructRgx.Matches(instructs.ElementAt(i));
                MatchCollection labelMatch = labelRgx.Matches(instructs.ElementAt(i));
                MatchCollection branchMatch = branchRgx.Matches(instructs.ElementAt(i));
                string currentIns = instructs.ElementAt(i);

                if ((match.Count == 1)||(match.Count == 2))
                {
                    if (labelMatch.Count == 1)
                    {
                        string[] labelName = currentIns.Split();
                        string label = labelName[0];
                        label = label.TrimEnd(label[label.Length - 1]);
                        labelDic.Add(label, (short)(i + 1));
                    }
                    else if (currentIns == "")
                    {
                        instructs.RemoveAt(i);
                    }
                    else if ((branchMatch.Count == 1)||(branchMatch.Count == 2))
                    {
                        toResolve.Add(currentIns, (short)(i));
                    }
                    else
                    {

                    }
                }
            }
        }

        private void resolveLabels()
        {
            try
            {
                foreach (KeyValuePair<string, short> branch in toResolve)
                {
                    short branchValue = labelDic[branch.Key];
                    string instructionToResolve = instructions.ElementAt(branch.Value);
                    string[] pieces = instructionToResolve.Split();
                    pieces[1] = branchValue.ToString();
                    instructionToResolve = pieces[0] + pieces[1];
                    //set instruction to new string


                }
            }
            catch (NullReferenceException e)
            {
                //broken syntax
            }

        }


        private void secondPass(List<string> instructs)
        {
            try
            {
                foreach (string instruction in instructions)
                {
                    string[] pieces = instruction.Split();
                    short op = instructDic[pieces[0]];
                    short value = 0;
                    switch (op)
                    {
                        case 1:
                           value = immOrMem(pieces[1]);
                            break;
                    }
                }
            } catch (NullReferenceException e){
               //break cause of syntax/no such op
            }
        }

        /// <summary>
        /// takes a string and determines if it is an immediate or a memory address,
        /// if immediate set iFlag, 
        /// then set value to number after #$ or $
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        private short immOrMem(string argument){
            short iFlag = 0;
            short value = 0;
            //TODO parse arg to determine number and if immediate
            return (short)((int)iFlag | (int)value);

    }

    }
}
