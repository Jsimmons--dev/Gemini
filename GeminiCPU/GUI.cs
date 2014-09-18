using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeminiCore;

namespace GeminiCPU
{
    public partial class Window : Form
    {
        
        public Window(CPU cpu)
        {
            InitializeComponent();
            this.cpu = cpu;
        }

        CPU cpu;

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



        public void updateIndex(){
            insIndexL = cpu.registerPC + "/" + cpu.memory.instructions.Count;
        }

        public void setUpFirstIns()
        {
            nxtIns = cpu.engine.binaryParse(cpu.currentIns);
            updateIndex();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cpu.registerPC++;
            cpu.currentIns = cpu.memory.instructions[cpu.registerPC];
            nxtIns = cpu.engine.binaryParse(cpu.currentIns);
            cpu.decode(cpu.currentIns);
            acc = "0b "+ Convert.ToString(cpu.registerACC, 2);
            pc = "0b " + Convert.ToString(cpu.registerPC, 2);
            updateIndex();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cpu.registerPC = 0;
            cpu.currentIns = cpu.memory.instructions[cpu.registerPC];
            nxtIns = cpu.engine.binaryParse(cpu.currentIns);
            updateIndex();
            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cpu.currentInsNum = 0;
            cpu.currentIns = cpu.memory.instructions[cpu.currentInsNum];
            nxtIns = cpu.engine.binaryParse(cpu.currentIns);
            updateIndex();
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
    }
}
