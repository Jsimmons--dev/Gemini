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
        #region : cache labels
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
                insIndexL = cpu.registerPC + "/" + cpu.memory.instructions.Count;
            }
            catch (NullReferenceException exception)
            {
                insIndexL = "-/0";
                nxtIns = "----------";
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

        public void setUpFirstIns()
        {
            nxtIns = cpu.engine.binaryParse(cpu.currentIns);
            updateIndex();
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
            updateCacheInfo();
            updateCacheView();
        }

        private void updatePipeline()
        {

        }

        public void setupArgs()
        {

                writeback = execute;
                writebackArgs.setup(cpu.registerTEMP, cpu.registerWB);
                execute = decode;
                executeArgs.setup(cpu.registerOP,cpu.registerACC,cpu.registerVAL);
                decode = fetch;
                decodeArgs.setup(cpu.registerMDR);
                if(fetchArgs.pc != -1)
                    fetch = cpu.engine.binaryParse(cpu.memory.instructions[fetchArgs.pc]);
                fetchArgs.setup(cpu.registerPC);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cpu.delaySlots == 0)
                {
                    if (cpu.registerPC < cpu.memory.instructions.Count)
                    {
                        cpu.currentIns = cpu.memory.instructions[cpu.registerPC];
                        //nxtIns = cpu.engine.binaryParse((short)(cpu.registerPC + 1));
                        setupArgs();
                        updatePipeline();
                        cpu.stepPipeline(fetchArgs, decodeArgs, executeArgs, writebackArgs);
                        updateView();
                    }

                    else
                    {
                        MessageBox.Show("End of File Reached");
                    }
                }
                else
                {
                    cpu.delaySlots--;
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
                    fetchArgs.setup(0);
                    decodeArgs.setup(0);
                    executeArgs.setup(0, 0, 0);
                    cpu.engine.Assemble(cpu.engine.path, "g.out");
                    cpu.fillMem();
                    cpu.registerPC++;
                    for (int i = 1; i <= 3; i++)
                    {
                        cpu.pushNoop();
                    }
                    setUpFirstIns();
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

    }
}
