namespace GeminiCPU
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aReg = new System.Windows.Forms.Label();
            this.bReg = new System.Windows.Forms.Label();
            this.accReg = new System.Windows.Forms.Label();
            this.zeroReg = new System.Windows.Forms.Label();
            this.oneReg = new System.Windows.Forms.Label();
            this.pcReg = new System.Windows.Forms.Label();
            this.marReg = new System.Windows.Forms.Label();
            this.mdrReg = new System.Windows.Forms.Label();
            this.tempReg = new System.Windows.Forms.Label();
            this.irReg = new System.Windows.Forms.Label();
            this.ccReg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetCPU = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.insIndex = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nxtInsLabel = new System.Windows.Forms.Label();
            this.ReadHitLabel = new System.Windows.Forms.Label();
            this.ReadHitValue = new System.Windows.Forms.Label();
            this.ReadMissLabel = new System.Windows.Forms.Label();
            this.ReadMissValue = new System.Windows.Forms.Label();
            this.WriteHitLabel = new System.Windows.Forms.Label();
            this.WriteHitValue = new System.Windows.Forms.Label();
            this.WriteMissLabel = new System.Windows.Forms.Label();
            this.WriteMissValue = new System.Windows.Forms.Label();
            this.cacheViewText = new System.Windows.Forms.Label();
            this.cacheViewLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.twoWayMap = new System.Windows.Forms.RadioButton();
            this.directButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordSizeTwo = new System.Windows.Forms.RadioButton();
            this.blockSizeOne = new System.Windows.Forms.RadioButton();
            this.CacheSizeTrack = new System.Windows.Forms.TrackBar();
            this.cacheSizeLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.memory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CacheSizeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.aReg, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bReg, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.accReg, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.zeroReg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.oneReg, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pcReg, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.marReg, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.mdrReg, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tempReg, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.irReg, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.ccReg, 1, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ACC";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ZERO";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "ONE";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "PC";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "MAR";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "MDR";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "TEMP";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "IR";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "CC";
            // 
            // aReg
            // 
            this.aReg.AutoSize = true;
            this.aReg.Location = new System.Drawing.Point(238, 23);
            this.aReg.Name = "aReg";
            this.aReg.Size = new System.Drawing.Size(28, 13);
            this.aReg.TabIndex = 13;
            this.aReg.Text = "0b 0";
            // 
            // bReg
            // 
            this.bReg.Location = new System.Drawing.Point(238, 46);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(100, 20);
            this.bReg.TabIndex = 14;
            this.bReg.Text = "0b 0";
            // 
            // accReg
            // 
            this.accReg.Location = new System.Drawing.Point(238, 66);
            this.accReg.Name = "accReg";
            this.accReg.Size = new System.Drawing.Size(120, 20);
            this.accReg.TabIndex = 15;
            this.accReg.Text = "0b 0";
            // 
            // zeroReg
            // 
            this.zeroReg.Location = new System.Drawing.Point(238, 86);
            this.zeroReg.Name = "zeroReg";
            this.zeroReg.Size = new System.Drawing.Size(100, 20);
            this.zeroReg.TabIndex = 16;
            this.zeroReg.Text = "0b 0";
            this.zeroReg.Click += new System.EventHandler(this.label17_Click);
            // 
            // oneReg
            // 
            this.oneReg.Location = new System.Drawing.Point(238, 106);
            this.oneReg.Name = "oneReg";
            this.oneReg.Size = new System.Drawing.Size(100, 20);
            this.oneReg.TabIndex = 17;
            this.oneReg.Text = "0b 1";
            // 
            // pcReg
            // 
            this.pcReg.Location = new System.Drawing.Point(238, 126);
            this.pcReg.Name = "pcReg";
            this.pcReg.Size = new System.Drawing.Size(100, 20);
            this.pcReg.TabIndex = 18;
            this.pcReg.Text = "0b 0";
            // 
            // marReg
            // 
            this.marReg.Location = new System.Drawing.Point(238, 146);
            this.marReg.Name = "marReg";
            this.marReg.Size = new System.Drawing.Size(100, 20);
            this.marReg.TabIndex = 19;
            this.marReg.Text = "0b 0";
            // 
            // mdrReg
            // 
            this.mdrReg.Location = new System.Drawing.Point(238, 166);
            this.mdrReg.Name = "mdrReg";
            this.mdrReg.Size = new System.Drawing.Size(100, 20);
            this.mdrReg.TabIndex = 20;
            this.mdrReg.Text = "0b 0";
            // 
            // tempReg
            // 
            this.tempReg.Location = new System.Drawing.Point(238, 186);
            this.tempReg.Name = "tempReg";
            this.tempReg.Size = new System.Drawing.Size(100, 20);
            this.tempReg.TabIndex = 21;
            this.tempReg.Text = "0b 0";
            // 
            // irReg
            // 
            this.irReg.Location = new System.Drawing.Point(238, 206);
            this.irReg.Name = "irReg";
            this.irReg.Size = new System.Drawing.Size(100, 20);
            this.irReg.TabIndex = 22;
            this.irReg.Text = "0b 0";
            // 
            // ccReg
            // 
            this.ccReg.Location = new System.Drawing.Point(238, 226);
            this.ccReg.Name = "ccReg";
            this.ccReg.Size = new System.Drawing.Size(100, 20);
            this.ccReg.TabIndex = 23;
            this.ccReg.Text = "0b 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetCPU
            // 
            this.resetCPU.Location = new System.Drawing.Point(364, 12);
            this.resetCPU.Name = "resetCPU";
            this.resetCPU.Size = new System.Drawing.Size(75, 23);
            this.resetCPU.TabIndex = 3;
            this.resetCPU.Text = "Reset CPU";
            this.resetCPU.UseVisualStyleBackColor = true;
            this.resetCPU.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Next Instruction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(357, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Run to End";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(30, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "Instruction Index";
            // 
            // insIndex
            // 
            this.insIndex.AutoSize = true;
            this.insIndex.Location = new System.Drawing.Point(125, 72);
            this.insIndex.Name = "insIndex";
            this.insIndex.Size = new System.Drawing.Size(21, 13);
            this.insIndex.TabIndex = 7;
            this.insIndex.Text = "-/0";
            this.insIndex.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(30, 89);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Next Intruction";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeminiCPU.Properties.Resources.chubby;
            this.pictureBox1.Location = new System.Drawing.Point(488, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // nxtInsLabel
            // 
            this.nxtInsLabel.AutoSize = true;
            this.nxtInsLabel.Location = new System.Drawing.Point(125, 89);
            this.nxtInsLabel.Name = "nxtInsLabel";
            this.nxtInsLabel.Size = new System.Drawing.Size(37, 13);
            this.nxtInsLabel.TabIndex = 9;
            this.nxtInsLabel.Text = "----------";
            this.nxtInsLabel.Click += new System.EventHandler(this.label28_Click);
            // 
            // ReadHitLabel
            // 
            this.ReadHitLabel.AutoSize = true;
            this.ReadHitLabel.Location = new System.Drawing.Point(485, 20);
            this.ReadHitLabel.Name = "ReadHitLabel";
            this.ReadHitLabel.Size = new System.Drawing.Size(46, 13);
            this.ReadHitLabel.TabIndex = 12;
            this.ReadHitLabel.Text = "ReadHit";
            // 
            // ReadHitValue
            // 
            this.ReadHitValue.AutoSize = true;
            this.ReadHitValue.Location = new System.Drawing.Point(536, 20);
            this.ReadHitValue.Name = "ReadHitValue";
            this.ReadHitValue.Size = new System.Drawing.Size(33, 13);
            this.ReadHitValue.TabIndex = 13;
            this.ReadHitValue.Text = "value";
            // 
            // ReadMissLabel
            // 
            this.ReadMissLabel.AutoSize = true;
            this.ReadMissLabel.Location = new System.Drawing.Point(485, 37);
            this.ReadMissLabel.Name = "ReadMissLabel";
            this.ReadMissLabel.Size = new System.Drawing.Size(54, 13);
            this.ReadMissLabel.TabIndex = 14;
            this.ReadMissLabel.Text = "ReadMiss";
            // 
            // ReadMissValue
            // 
            this.ReadMissValue.AutoSize = true;
            this.ReadMissValue.Location = new System.Drawing.Point(539, 37);
            this.ReadMissValue.Name = "ReadMissValue";
            this.ReadMissValue.Size = new System.Drawing.Size(33, 13);
            this.ReadMissValue.TabIndex = 15;
            this.ReadMissValue.Text = "value";
            // 
            // WriteHitLabel
            // 
            this.WriteHitLabel.AutoSize = true;
            this.WriteHitLabel.Location = new System.Drawing.Point(485, 53);
            this.WriteHitLabel.Name = "WriteHitLabel";
            this.WriteHitLabel.Size = new System.Drawing.Size(45, 13);
            this.WriteHitLabel.TabIndex = 16;
            this.WriteHitLabel.Text = "WriteHit";
            this.WriteHitLabel.Click += new System.EventHandler(this.label18_Click);
            // 
            // WriteHitValue
            // 
            this.WriteHitValue.AutoSize = true;
            this.WriteHitValue.Location = new System.Drawing.Point(539, 53);
            this.WriteHitValue.Name = "WriteHitValue";
            this.WriteHitValue.Size = new System.Drawing.Size(33, 13);
            this.WriteHitValue.TabIndex = 17;
            this.WriteHitValue.Text = "value";
            // 
            // WriteMissLabel
            // 
            this.WriteMissLabel.AutoSize = true;
            this.WriteMissLabel.Location = new System.Drawing.Point(485, 72);
            this.WriteMissLabel.Name = "WriteMissLabel";
            this.WriteMissLabel.Size = new System.Drawing.Size(53, 13);
            this.WriteMissLabel.TabIndex = 18;
            this.WriteMissLabel.Text = "WriteMiss";
            // 
            // WriteMissValue
            // 
            this.WriteMissValue.AutoSize = true;
            this.WriteMissValue.Location = new System.Drawing.Point(539, 70);
            this.WriteMissValue.Name = "WriteMissValue";
            this.WriteMissValue.Size = new System.Drawing.Size(33, 13);
            this.WriteMissValue.TabIndex = 19;
            this.WriteMissValue.Text = "value";
            // 
            // cacheViewText
            // 
            this.cacheViewText.AutoSize = true;
            this.cacheViewText.Location = new System.Drawing.Point(742, 22);
            this.cacheViewText.Name = "cacheViewText";
            this.cacheViewText.Size = new System.Drawing.Size(37, 13);
            this.cacheViewText.TabIndex = 20;
            this.cacheViewText.Text = "cache";
            // 
            // cacheViewLabel
            // 
            this.cacheViewLabel.AutoSize = true;
            this.cacheViewLabel.Location = new System.Drawing.Point(745, 39);
            this.cacheViewLabel.Name = "cacheViewLabel";
            this.cacheViewLabel.Size = new System.Drawing.Size(13, 13);
            this.cacheViewLabel.TabIndex = 21;
            this.cacheViewLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.twoWayMap);
            this.panel1.Controls.Add(this.directButton);
            this.panel1.Location = new System.Drawing.Point(1132, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 40);
            this.panel1.TabIndex = 22;
            // 
            // twoWayMap
            // 
            this.twoWayMap.AutoSize = true;
            this.twoWayMap.Location = new System.Drawing.Point(0, 23);
            this.twoWayMap.Name = "twoWayMap";
            this.twoWayMap.Size = new System.Drawing.Size(132, 17);
            this.twoWayMap.TabIndex = 1;
            this.twoWayMap.TabStop = true;
            this.twoWayMap.Text = "2-Way Set Associative";
            this.twoWayMap.UseVisualStyleBackColor = true;
            this.twoWayMap.CheckedChanged += new System.EventHandler(this.twoWayMap_CheckedChanged);
            // 
            // directButton
            // 
            this.directButton.AutoSize = true;
            this.directButton.Checked = true;
            this.directButton.Location = new System.Drawing.Point(0, 0);
            this.directButton.Name = "directButton";
            this.directButton.Size = new System.Drawing.Size(132, 17);
            this.directButton.TabIndex = 0;
            this.directButton.TabStop = true;
            this.directButton.Text = "1-Way Set Associative";
            this.directButton.UseVisualStyleBackColor = true;
            this.directButton.CheckedChanged += new System.EventHandler(this.directButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wordSizeTwo);
            this.panel2.Controls.Add(this.blockSizeOne);
            this.panel2.Location = new System.Drawing.Point(1132, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 40);
            this.panel2.TabIndex = 23;
            // 
            // wordSizeTwo
            // 
            this.wordSizeTwo.AutoSize = true;
            this.wordSizeTwo.Checked = true;
            this.wordSizeTwo.Location = new System.Drawing.Point(0, 23);
            this.wordSizeTwo.Name = "wordSizeTwo";
            this.wordSizeTwo.Size = new System.Drawing.Size(113, 17);
            this.wordSizeTwo.TabIndex = 1;
            this.wordSizeTwo.TabStop = true;
            this.wordSizeTwo.Text = "Block Size 2 Word";
            this.wordSizeTwo.UseVisualStyleBackColor = true;
            this.wordSizeTwo.CheckedChanged += new System.EventHandler(this.wordSizeTwo_CheckedChanged);
            // 
            // blockSizeOne
            // 
            this.blockSizeOne.AutoSize = true;
            this.blockSizeOne.Location = new System.Drawing.Point(0, 0);
            this.blockSizeOne.Name = "blockSizeOne";
            this.blockSizeOne.Size = new System.Drawing.Size(113, 17);
            this.blockSizeOne.TabIndex = 0;
            this.blockSizeOne.Text = "Block Size 1 Word";
            this.blockSizeOne.UseVisualStyleBackColor = true;
            this.blockSizeOne.CheckedChanged += new System.EventHandler(this.blockSizeOne_CheckedChanged);
            // 
            // CacheSizeTrack
            // 
            this.CacheSizeTrack.LargeChange = 1;
            this.CacheSizeTrack.Location = new System.Drawing.Point(1123, 70);
            this.CacheSizeTrack.Maximum = 16;
            this.CacheSizeTrack.Minimum = 2;
            this.CacheSizeTrack.Name = "CacheSizeTrack";
            this.CacheSizeTrack.Size = new System.Drawing.Size(150, 45);
            this.CacheSizeTrack.TabIndex = 24;
            this.CacheSizeTrack.Value = 8;
            this.CacheSizeTrack.Scroll += new System.EventHandler(this.CacheSizeTrack_Scroll);
            // 
            // cacheSizeLabel
            // 
            this.cacheSizeLabel.AutoSize = true;
            this.cacheSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheSizeLabel.Location = new System.Drawing.Point(1120, 39);
            this.cacheSizeLabel.Name = "cacheSizeLabel";
            this.cacheSizeLabel.Size = new System.Drawing.Size(159, 16);
            this.cacheSizeLabel.TabIndex = 25;
            this.cacheSizeLabel.Text = "Cache Size!  2 - 16 blocks";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(881, 20);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(43, 13);
            this.memoryLabel.TabIndex = 26;
            this.memoryLabel.Text = "memory";
            // 
            // memory
            // 
            this.memory.AcceptsReturn = true;
            this.memory.AcceptsTab = true;
            this.memory.Location = new System.Drawing.Point(884, 50);
            this.memory.Multiline = true;
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(123, 467);
            this.memory.TabIndex = 28;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 518);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.cacheSizeLabel);
            this.Controls.Add(this.CacheSizeTrack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cacheViewLabel);
            this.Controls.Add(this.cacheViewText);
            this.Controls.Add(this.WriteMissValue);
            this.Controls.Add(this.WriteMissLabel);
            this.Controls.Add(this.WriteHitValue);
            this.Controls.Add(this.WriteHitLabel);
            this.Controls.Add(this.ReadMissValue);
            this.Controls.Add(this.ReadMissLabel);
            this.Controls.Add(this.ReadHitValue);
            this.Controls.Add(this.ReadHitLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nxtInsLabel);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.insIndex);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.resetCPU);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Window";
            this.Text = "Gemini";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CacheSizeTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label aReg;
        private System.Windows.Forms.Label bReg;
        private System.Windows.Forms.Label accReg;
        private System.Windows.Forms.Label zeroReg;
        private System.Windows.Forms.Label oneReg;
        private System.Windows.Forms.Label pcReg;
        private System.Windows.Forms.Label marReg;
        private System.Windows.Forms.Label mdrReg;
        private System.Windows.Forms.Label tempReg;
        private System.Windows.Forms.Label irReg;
        private System.Windows.Forms.Label ccReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetCPU;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label insIndex;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label nxtInsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ReadHitLabel;
        private System.Windows.Forms.Label ReadHitValue;
        private System.Windows.Forms.Label ReadMissLabel;
        private System.Windows.Forms.Label ReadMissValue;
        private System.Windows.Forms.Label WriteHitLabel;
        private System.Windows.Forms.Label WriteHitValue;
        private System.Windows.Forms.Label WriteMissLabel;
        private System.Windows.Forms.Label WriteMissValue;
        private System.Windows.Forms.Label cacheViewText;
        private System.Windows.Forms.Label cacheViewLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton twoWayMap;
        private System.Windows.Forms.RadioButton directButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton wordSizeTwo;
        private System.Windows.Forms.RadioButton blockSizeOne;
        private System.Windows.Forms.TrackBar CacheSizeTrack;
        private System.Windows.Forms.Label cacheSizeLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.TextBox memory;


    }
}

