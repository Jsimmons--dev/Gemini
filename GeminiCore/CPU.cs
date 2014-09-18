using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class CPU
    {
        short registerA = 0;
        short registerB = 0;
        public short registerACC = 0;
        short registerZERO = 0;
        short registerONE = 1;
        public short registerPC = 0;
        short registerMAR = 0;
        short registerMDR = 0;
        short registerTEMP = 0;
        short registerIR = 0;
        short registerCC = 0;
        public IAE engine;
        public Memory memory;
        public short currentIns;
        public int currentInsNum;

        public CPU()
        {
         engine = new IAE();
         memory = new Memory();
        }

        public void fillMem()
        {
            memory.instructions = engine.readBinFile();
            currentInsNum = 0;
            currentIns = memory.instructions[currentInsNum];
        }

        public void decode(short bin){
              int negativeOp = 65024;
            int negativeIFlag = 256;
            int negativeValue = 255;

            int op = 0;
            int iFlag = 0;
            int value = 0;

            op = (bin & negativeOp) >> 9;
            iFlag = (bin & negativeIFlag) >> 8;
            value = (bin & negativeValue);

            switch(op){
                case 1:
                    if(iFlag == 1){ //LDA
                        registerACC = (short)value; //imm
                    }
                    else
                    {
                        registerACC = (short)memory.stack[value]; //mem
                    }
                    break;
                case 2: //STA
                    memory.stack[value] = registerACC; // mem
                    break;
                case 3: //ADD
                    if(iFlag == 1){
                        registerACC += (short)value;  //imm
                    }
                    else
                    {
                        registerACC += (short)memory.stack[value]; // mem
                    }
                    break;
                case 4: //SUB
                    if (iFlag == 1)
                    {
                        registerACC -= (short)value; //imm
                    }
                    else
                    {
                        registerACC -= (short)memory.stack[value]; // mem
                    }
                    break;
                case 5: //MUL
                    if(iFlag == 1){
                        //imm
                    }
                    else
                    {
                        //mem
                    }
                    break;
                case 6: //DIV
                    if (iFlag == 1)
                    {
                        //imm
                    }
                    else
                    {
                        //mem
                    }
                    break;
                case 7: //AND
                    if (iFlag == 1)
                    {
                        registerACC = (short)((int)registerACC & (int)value); //imm
                    }
                    else
                    {
                        registerACC = (short)((int)registerACC & (int)memory.stack[value]);  //mem
                    }
                    break;
                case 8: //OR
                    if (iFlag == 1)
                    {
                        registerACC = (short)((int)registerACC | (int)value); //imm
                    }
                    else
                    {
                        registerACC = (short)((int)registerACC|(int)memory.stack[value]); //mem
                    }
                    break;
                case 9: //SHL
                    registerACC = (short)((int)registerACC << value);
                    break;
                case 10: //NOTA
                    registerACC = (short)(~(int)registerACC);
                    break;
                case 11: //BA
                    registerPC = (short)value;
                    break;
                case 12: //BE
                    if (registerACC == 0) { registerPC = (short)value; }
                    break;
                case 13: //BL
                    if (registerACC < 0) { registerPC = (short)value; }
                    break;
                case 14: //BG
                    if (registerACC > 0) { registerPC = (short)value; }
                    break;
                case 15: //NOP
                    registerACC += 0;
                    break;
                case 16: //HLT
                    registerPC = 0;
                    break;

            }
        }

    }
}
