/*
Joshua Simmons and Shane Hafycz
*/
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeminiCore;
using System.IO;

namespace GeminiCPU
{
    public partial class Window : Form
    {
        FetchArgs fetchArgs = new FetchArgs();
        DecodeArgs decodeArgs = new DecodeArgs();
        ExecuteArgs executeArgs = new ExecuteArgs();
        WritebackArgs writebackArgs = new WritebackArgs();

        public Window(CPU cpu)
        {
            InitializeComponent();
            this.cpu = cpu;
        }

        CPU cpu;


        #region pipeline labels
        public string oldfetchL
        {
            get
            {
                return this.oldfetch.Text;
            }
            set
            {
                this.oldfetch.Text = value;
            }
        }
        public string olddecodeL
        {
            get
            {
                return this.olddecode.Text;
            }
            set
            {
                this.olddecode.Text = value;
            }
        }
        public string oldexecuteL
        {
            get
            {
                return this.oldexecute.Text;
            }
            set
            {
                this.oldexecute.Text = value;
            }
        }
        public string oldwriteL
        {
            get
            {
                return this.oldwrite.Text;
            }
            set
            {
                this.oldwrite.Text = value;
            }
        }
        public string olderfetchL
        {
            get
            {
                return this.olderfetch.Text;
            }
            set
            {
                this.olderfetch.Text = value;
            }
        }
        public string olderdecodeL
        {
            get
            {
                return this.olderdecode.Text;
            }
            set
            {
                this.olderdecode.Text = value;
            }
        }
        public string olderexecuteL
        {
            get
            {
                return this.olderexecute.Text;
            }
            set
            {
                this.olderexecute.Text = value;
            }
        }
        public string olderwriteL
        {
            get
            {
                return this.olderwrite.Text;
            }
            set
            {
                this.olderwrite.Text = value;
            }
        }
        public string oldestfetchL
        {
            get
            {
                return this.oldestfetch.Text;
            }
            set
            {
                this.oldestfetch.Text = value;
            }
        }
        public string oldestdecodeL
        {
            get
            {
                return this.oldestdecode.Text;
            }
            set
            {
                this.oldestdecode.Text = value;
            }
        }
        public string oldestexecuteL
        {
            get
            {
                return this.oldestexecute.Text;
            }
            set
            {
                this.oldestexecute.Text = value;
            }
        }
        public string oldestwriteL
        {
            get
            {
                return this.oldestwrite.Text;
            }
            set
            {
                this.oldestwrite.Text = value;
            }
        }
        #endregion
        #region cacheInfo : hit and miss info
        public string ReadHit
        {
            get
            {
                return this.ReadHitValue.Text;
            }
            set
            {
                this.ReadHitValue.Text = value;
            }
        }
        public string ReadMiss
        {
            get
            {
                return this.ReadMissValue.Text;
            }
            set
            {
                this.ReadMissValue.Text = value;
            }
        }
        public string WriteHit
        {
            get
            {
                return this.WriteHitValue.Text;
            }
            set
            {
                this.WriteHitValue.Text = value;
            }
        }
        public string WriteMiss
        {
            get
            {
                return this.WriteMissValue.Text;
            }
            set
            {
                this.WriteMissValue.Text = value;
            }
        }
        #endregion

        #region registers : register selectors
        public string a
        {
            get
            {
                return this.aReg.Text;
            }
            set
            {
                this.aReg.Text = value;
            }
        }
        public string b
        {
            get
            {
                return this.bReg.Text;
            }
            set
            {
                this.bReg.Text = value;
            }
        }
        public string acc
        {
            get
            {
                return this.accReg.Text;
            }
            set
            {
                this.accReg.Text = value;
            }
        }
        public string z
        {
            get
            {
                return this.zeroReg.Text;
            }
            set
            {
                this.zeroReg.Text = value;
            }
        }
        public string one
        {
            get
            {
                return this.oneReg.Text;
            }
            set
            {
                this.oneReg.Text = value;
            }
        }
        public string pc
        {
            get
            {
                return this.pcReg.Text;
            }
            set
            {
                this.pcReg.Text = value;
            }
        }
        public string mar
        {
            get
            {
                return this.marReg.Text;
            }
            set
            {
                this.marReg.Text = value;
            }
        }
        public string mdr
        {
            get
            {
                return this.mdrReg.Text;
            }
            set
            {
                this.mdrReg.Text = value;
            }
        }
        public string temp
        {
            get
            {
                return this.tempReg.Text;
            }
            set
            {
                this.tempReg.Text = value;
            }
        }
        public string ir
        {
            get
            {
                return this.irReg.Text;
            }
            set
            {
                this.irReg.Text = value;
            }
        }
        public string cc
        {
            get
            {
                return this.ccReg.Text;
            }
            set
            {
                this.ccReg.Text = value;
            }
        }
        #endregion
        #region : pipeline labels
        public string fetch
        {
            get
            {
                return this.fetchLabel.Text;
            }
            set
            {
                this.fetchLabel.Text = value;
            }
        }
        public string decode
        {
            get
            {
                return this.decodeLabel.Text;
            }
            set
            {
                this.decodeLabel.Text = value;
            }
        }
        public string execute
        {
            get
            {
                return this.executeLabel.Text;
            }
            set
            {
                this.executeLabel.Text = value;
            }
        }
        public string writeback
        {
            get
            {
                return this.writebackLabel.Text;
            }
            set
            {
                this.writebackLabel.Text = value;
            }
        }
        #endregion

        public string nxtIns
        {
            get
            {
                return this.nxtInsLabel.Text;
            }
            set
            {
                this.nxtInsLabel.Text = value;
            }
        }
        public string insIndexL
        {
            get
            {
                return this.insIndex.Text;
            }
            set
            {
                this.insIndex.Text = value;
            }
        }

        public string memoryL
        {
            get
            {
                return this.memory.Text;
            }
            set
            {
                this.memory.Text = value;
            }
        }
        public string cacheView
        {
            get
            {
                return this.cacheViewLabel.Text;
            }
            set
            {
                this.cacheViewLabel.Text = value;
            }
        }

        public void updateIndex()
        {
            try
            {
                if (cpu.registerPC >= 0 && cpu.registerPC < cpu.memory.instructions.Count)
                    insIndexL = cpu.registerPC + "/" + (cpu.memory.instructions.Count - 1);
                else
                    insIndexL = "-/-";
            }
            catch (NullReferenceException)
            {
                insIndexL = "-/-";
            }


        }
        public void updateCacheInfo()
        {
            ReadHit = Convert.ToString(cpu.memory.cacheReadHit);
            ReadMiss = Convert.ToString(cpu.memory.cacheReadMiss);
            WriteHit = Convert.ToString(cpu.memory.cacheWriteHit);
            WriteMiss = Convert.ToString(cpu.memory.cacheWriteMiss);
        }

        //also updates memory view
        public void updateCacheView()
        {
            memoryL = Convert.ToString(cpu.memory);
            cacheView = Convert.ToString(cpu.memory.cache);
        }

        public void updateRegisters()
        {
            acc = "0b " + Convert.ToString(cpu.registerACC, 2);
            pc = "0b " + Convert.ToString(cpu.registerPC, 2);
            mar = "0b " + Convert.ToString(cpu.registerMAR, 2);
            mdr = "0b " + Convert.ToString(cpu.registerMDR, 2);
            temp = "0b " + Convert.ToString(cpu.registerTEMP, 2);
            ir = "0b " + Convert.ToString(cpu.registerIR, 2);
        }

        public void updateNxtIns()
        {
            try
            {
                if (cpu.registerPC + 1 <= cpu.memory.instructions.Count)
                {
                    nxtIns = cpu.engine.binaryParse(cpu.memory.instructions[cpu.registerPC + 1]);
                }
                else
                    nxtIns = "-----";
                updateIndex();
            } catch (Exception exception)
            {
                nxtIns = "-----";
            }
        }

        public void logCacheResults()
        {
            string path = Application.StartupPath + "../../../logFile.csv";
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Log\n");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write("\r\n" + cpu.memory.cacheReadHit + ",");
                sw.Write(cpu.memory.cacheReadMiss + ",");
                sw.Write(cpu.memory.cacheWriteHit + ",");
                sw.Write(cpu.memory.cacheWriteMiss + ",");
                sw.Write(Memory.blockSize + "," + Memory.cacheSize + "," + Memory.frameSetSize + "\n");
                sw.Flush();
            }
        }


        private void updateView()
        {
            updateRegisters();
            updateIndex();
            updateNxtIns();
            updateCacheInfo();
            updateCacheView();
        }

        private void updatePipeline()
        {

        }

        public void setupArgs()
        {
            oldestwriteL = olderwriteL;
            olderwriteL = oldwriteL;
            oldwriteL = writeback;
            if (!writebackArgs.locked)
            {
                if (cpu.registerPC - 3 >= 0)
                    writeback = cpu.engine.binaryParse(cpu.memory.instructions[cpu.registerPC - 3]);
                writebackArgs.writebackPC = executeArgs.executePC;
                writebackArgs.setup(cpu.registerTEMP, cpu.registerWB);
            }

            oldestexecuteL = olderexecuteL;
            olderexecuteL = oldexecuteL;
            oldexecuteL = execute;
            if (!executeArgs.locked)
            {
                if (cpu.registerPC -2 >= 0)
                    execute = cpu.engine.binaryParse(cpu.memory.instructions[cpu.registerPC - 2]);
                executeArgs.executePC = decodeArgs.decodePC;
                executeArgs.setup(cpu.registerOP, cpu.registerACC, cpu.registerVAL);
            }

            oldestdecodeL = olderdecodeL;
            olderdecodeL = olddecodeL;
            olddecodeL = decode;
            if (!decodeArgs.locked)
            {
                if (cpu.registerPC - 1 >= 0)
                    decode = cpu.engine.binaryParse(cpu.memory.instructions[cpu.registerPC -1]);
                decodeArgs.decodePC = fetchArgs.pc;
                decodeArgs.setup(cpu.registerMDR);
            }

            oldestfetchL = olderfetchL;
            olderfetchL = oldfetchL;
            oldfetchL = fetch;
            if(!fetchArgs.locked)
            {
                fetch = cpu.engine.binaryParse(cpu.memory.instructions[cpu.registerPC]);
                fetchArgs.setup(cpu.registerPC);

            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (cpu.registerPC < cpu.memory.instructions.Count && cpu.registerPC >= 0)
                {
                    setupArgs();
                    cpu.stepPipeline(fetchArgs, decodeArgs, executeArgs, writebackArgs);
                    updateView();
                }
                else
                {
                    MessageBox.Show("End of File Reached");
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("No File Loaded");
                Console.WriteLine(exception.StackTrace);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            cpu = new CPU();
            cpu.currentInsNum = 0;
            cpu.registerPC = 0;
            updateView();
            if (cpu.memory.instructions != null)
            {
                cpu.currentIns = cpu.memory.instructions[cpu.currentInsNum];
                nxtIns = cpu.engine.binaryParse(cpu.currentIns);
                cpu.engine.LabelDic.Clear();
                cpu.memory.resetInstructions();
            }
            a = "0b 0";
            b = "0b 0";
            acc = "0b 0";
            pc = "0b 0";
            mar = "0b 0";
            mdr = "0b 0";
            temp = "0b 0";
            ir = "0b 0";
            cc = "0b 0";

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cpu.delaySlots == 0)
                {
                    while (cpu.registerPC < cpu.memory.instructions.Count)
                    {
                        cpu.currentIns = cpu.memory.instructions[cpu.registerPC];
                        nxtIns = cpu.engine.binaryParse(cpu.currentIns);
                        setupArgs();
                        cpu.stepPipeline(fetchArgs, decodeArgs, executeArgs, writebackArgs);
                        updateView();
                    }
                    MessageBox.Show("End of File Reached");
                }
                else
                {
                    cpu.delaySlots--;
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("No File Loaded");
            }
        }

        //load file button
        private void loadButton_Click(object sender, EventArgs e)
        {
            cpu = new CPU();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cpu.engine.path = ofd.FileName;
                try
                {
                    cpu.engine.Assemble(cpu.engine.path, "g.out");
                    cpu.fillMem();
                    for (int i = 1; i <= 3; i++)
                    {
                        cpu.pushNoop();
                    }
                    updateNxtIns();
                    updateView();
                }
                catch (SyntaxException exception)
                {
                    MessageBox.Show("Syntax Error");
                    resetButton_Click(null, null);
                }
                catch (SegFaultException segE)
                {
                    MessageBox.Show("Memory was addressed out of bounds");
                    resetButton_Click(null, null);
                }
                catch (ArgMismatchException argE)
                {
                    MessageBox.Show("argument mispatch in source");
                    resetButton_Click(null, null);
                }
                catch (InvalidCommandException inE)
                {
                    MessageBox.Show("invalid command in source");
                    resetButton_Click(null, null);
                }
                catch (InvalidArgFormattingException inAE)
                {
                    MessageBox.Show("argument formatted incorrectly in source");
                    resetButton_Click(null, null);
                }
                catch (InvalidLabelNameException inL)
                {
                    MessageBox.Show("label not defined in source");
                    resetButton_Click(null, null);
                }
            }
        }

        private void directButton_CheckedChanged(object sender, EventArgs e)
        {
            Memory.frameSetSize = 1;
            resetButton_Click(null, null);
        }

        private void twoWayMap_CheckedChanged(object sender, EventArgs e)
        {
            Memory.frameSetSize = 2;
            resetButton_Click(null, null);
        }

        private void blockSizeOne_CheckedChanged(object sender, EventArgs e)
        {
            Memory.blockSize = 1;
            resetButton_Click(null, null);
        }

        private void wordSizeTwo_CheckedChanged(object sender, EventArgs e)
        {
            Memory.blockSize = 2;
            resetButton_Click(null, null);
        }

        private void CacheSizeTrack_Scroll(object sender, EventArgs e)
        {
            Memory.cacheSize = CacheSizeTrack.Value;
            resetButton_Click(null, null);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

    }
}
