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
            this.RegisterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registerColumnLabel = new System.Windows.Forms.Label();
            this.ValueColumnLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ACCLabel = new System.Windows.Forms.Label();
            this.ZEROLabel = new System.Windows.Forms.Label();
            this.ONELabel = new System.Windows.Forms.Label();
            this.PCLabel = new System.Windows.Forms.Label();
            this.MARLabel = new System.Windows.Forms.Label();
            this.MDRLabel = new System.Windows.Forms.Label();
            this.TEMPLabel = new System.Windows.Forms.Label();
            this.IRLabel = new System.Windows.Forms.Label();
            this.CCLabel = new System.Windows.Forms.Label();
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.resetCPU = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RunToEndButton = new System.Windows.Forms.Button();
            this.InstructionIndexLabel = new System.Windows.Forms.Label();
            this.insIndex = new System.Windows.Forms.Label();
            this.nextInstructionLabel = new System.Windows.Forms.Label();
            this.rabbitPictureBox = new System.Windows.Forms.PictureBox();
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
            this.fetchNameLabel = new System.Windows.Forms.Label();
            this.fetchLabel = new System.Windows.Forms.Label();
            this.decodeNameLabel = new System.Windows.Forms.Label();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.executeNameLabel = new System.Windows.Forms.Label();
            this.executeLabel = new System.Windows.Forms.Label();
            this.writebackNameLabel = new System.Windows.Forms.Label();
            this.writebackLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldfetch = new System.Windows.Forms.Label();
            this.olddecode = new System.Windows.Forms.Label();
            this.oldexecute = new System.Windows.Forms.Label();
            this.oldwrite = new System.Windows.Forms.Label();
            this.olderfetch = new System.Windows.Forms.Label();
            this.olderdecode = new System.Windows.Forms.Label();
            this.olderexecute = new System.Windows.Forms.Label();
            this.olderwrite = new System.Windows.Forms.Label();
            this.oldestfetch = new System.Windows.Forms.Label();
            this.oldestdecode = new System.Windows.Forms.Label();
            this.oldestexecute = new System.Windows.Forms.Label();
            this.oldestwrite = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.RegisterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CacheSizeTrack)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.AutoSize = true;
            this.RegisterPanel.ColumnCount = 2;
            this.RegisterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegisterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegisterPanel.Controls.Add(this.registerColumnLabel, 0, 0);
            this.RegisterPanel.Controls.Add(this.ValueColumnLabel, 1, 0);
            this.RegisterPanel.Controls.Add(this.ALabel, 0, 1);
            this.RegisterPanel.Controls.Add(this.BLabel, 0, 2);
            this.RegisterPanel.Controls.Add(this.ACCLabel, 0, 3);
            this.RegisterPanel.Controls.Add(this.ZEROLabel, 0, 4);
            this.RegisterPanel.Controls.Add(this.ONELabel, 0, 5);
            this.RegisterPanel.Controls.Add(this.PCLabel, 0, 6);
            this.RegisterPanel.Controls.Add(this.MARLabel, 0, 7);
            this.RegisterPanel.Controls.Add(this.MDRLabel, 0, 8);
            this.RegisterPanel.Controls.Add(this.TEMPLabel, 0, 9);
            this.RegisterPanel.Controls.Add(this.IRLabel, 0, 10);
            this.RegisterPanel.Controls.Add(this.CCLabel, 0, 11);
            this.RegisterPanel.Controls.Add(this.aReg, 1, 1);
            this.RegisterPanel.Controls.Add(this.bReg, 1, 2);
            this.RegisterPanel.Controls.Add(this.accReg, 1, 3);
            this.RegisterPanel.Controls.Add(this.zeroReg, 1, 4);
            this.RegisterPanel.Controls.Add(this.oneReg, 1, 5);
            this.RegisterPanel.Controls.Add(this.pcReg, 1, 6);
            this.RegisterPanel.Controls.Add(this.marReg, 1, 7);
            this.RegisterPanel.Controls.Add(this.mdrReg, 1, 8);
            this.RegisterPanel.Controls.Add(this.tempReg, 1, 9);
            this.RegisterPanel.Controls.Add(this.irReg, 1, 10);
            this.RegisterPanel.Controls.Add(this.ccReg, 1, 11);
            this.RegisterPanel.Location = new System.Drawing.Point(12, 125);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.RowCount = 12;
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterPanel.Size = new System.Drawing.Size(470, 246);
            this.RegisterPanel.TabIndex = 0;
            // 
            // registerColumnLabel
            // 
            this.registerColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerColumnLabel.Location = new System.Drawing.Point(3, 0);
            this.registerColumnLabel.Name = "registerColumnLabel";
            this.registerColumnLabel.Size = new System.Drawing.Size(100, 23);
            this.registerColumnLabel.TabIndex = 0;
            this.registerColumnLabel.Text = "Register";
            // 
            // ValueColumnLabel
            // 
            this.ValueColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueColumnLabel.Location = new System.Drawing.Point(238, 0);
            this.ValueColumnLabel.Name = "ValueColumnLabel";
            this.ValueColumnLabel.Size = new System.Drawing.Size(100, 23);
            this.ValueColumnLabel.TabIndex = 1;
            this.ValueColumnLabel.Text = "Value";
            // 
            // ALabel
            // 
            this.ALabel.Location = new System.Drawing.Point(3, 23);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(100, 23);
            this.ALabel.TabIndex = 2;
            this.ALabel.Text = "A";
            // 
            // BLabel
            // 
            this.BLabel.Location = new System.Drawing.Point(3, 46);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(100, 20);
            this.BLabel.TabIndex = 3;
            this.BLabel.Text = "B";
            // 
            // ACCLabel
            // 
            this.ACCLabel.Location = new System.Drawing.Point(3, 66);
            this.ACCLabel.Name = "ACCLabel";
            this.ACCLabel.Size = new System.Drawing.Size(100, 20);
            this.ACCLabel.TabIndex = 4;
            this.ACCLabel.Text = "ACC";
            // 
            // ZEROLabel
            // 
            this.ZEROLabel.Location = new System.Drawing.Point(3, 86);
            this.ZEROLabel.Name = "ZEROLabel";
            this.ZEROLabel.Size = new System.Drawing.Size(100, 20);
            this.ZEROLabel.TabIndex = 5;
            this.ZEROLabel.Text = "ZERO";
            // 
            // ONELabel
            // 
            this.ONELabel.Location = new System.Drawing.Point(3, 106);
            this.ONELabel.Name = "ONELabel";
            this.ONELabel.Size = new System.Drawing.Size(100, 20);
            this.ONELabel.TabIndex = 6;
            this.ONELabel.Text = "ONE";
            // 
            // PCLabel
            // 
            this.PCLabel.Location = new System.Drawing.Point(3, 126);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(100, 20);
            this.PCLabel.TabIndex = 7;
            this.PCLabel.Text = "PC";
            // 
            // MARLabel
            // 
            this.MARLabel.Location = new System.Drawing.Point(3, 146);
            this.MARLabel.Name = "MARLabel";
            this.MARLabel.Size = new System.Drawing.Size(100, 20);
            this.MARLabel.TabIndex = 8;
            this.MARLabel.Text = "MAR";
            // 
            // MDRLabel
            // 
            this.MDRLabel.Location = new System.Drawing.Point(3, 166);
            this.MDRLabel.Name = "MDRLabel";
            this.MDRLabel.Size = new System.Drawing.Size(100, 20);
            this.MDRLabel.TabIndex = 9;
            this.MDRLabel.Text = "MDR";
            // 
            // TEMPLabel
            // 
            this.TEMPLabel.Location = new System.Drawing.Point(3, 186);
            this.TEMPLabel.Name = "TEMPLabel";
            this.TEMPLabel.Size = new System.Drawing.Size(100, 20);
            this.TEMPLabel.TabIndex = 10;
            this.TEMPLabel.Text = "TEMP";
            // 
            // IRLabel
            // 
            this.IRLabel.Location = new System.Drawing.Point(3, 206);
            this.IRLabel.Name = "IRLabel";
            this.IRLabel.Size = new System.Drawing.Size(100, 20);
            this.IRLabel.TabIndex = 11;
            this.IRLabel.Text = "IR";
            // 
            // CCLabel
            // 
            this.CCLabel.Location = new System.Drawing.Point(3, 226);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Size = new System.Drawing.Size(100, 20);
            this.CCLabel.TabIndex = 12;
            this.CCLabel.Text = "CC";
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
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(247, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load File";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.loadButton_Click);
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
            // RunToEndButton
            // 
            this.RunToEndButton.Location = new System.Drawing.Point(357, 400);
            this.RunToEndButton.Name = "RunToEndButton";
            this.RunToEndButton.Size = new System.Drawing.Size(93, 23);
            this.RunToEndButton.TabIndex = 5;
            this.RunToEndButton.Text = "Run to End";
            this.RunToEndButton.UseVisualStyleBackColor = true;
            this.RunToEndButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // InstructionIndexLabel
            // 
            this.InstructionIndexLabel.AutoSize = true;
            this.InstructionIndexLabel.Location = new System.Drawing.Point(30, 72);
            this.InstructionIndexLabel.Name = "InstructionIndexLabel";
            this.InstructionIndexLabel.Size = new System.Drawing.Size(85, 13);
            this.InstructionIndexLabel.TabIndex = 6;
            this.InstructionIndexLabel.Text = "Instruction Index";
            // 
            // insIndex
            // 
            this.insIndex.AutoSize = true;
            this.insIndex.Location = new System.Drawing.Point(125, 72);
            this.insIndex.Name = "insIndex";
            this.insIndex.Size = new System.Drawing.Size(21, 13);
            this.insIndex.TabIndex = 7;
            this.insIndex.Text = "-/0";
            // 
            // nextInstructionLabel
            // 
            this.nextInstructionLabel.AutoSize = true;
            this.nextInstructionLabel.Location = new System.Drawing.Point(30, 89);
            this.nextInstructionLabel.Name = "nextInstructionLabel";
            this.nextInstructionLabel.Size = new System.Drawing.Size(76, 13);
            this.nextInstructionLabel.TabIndex = 8;
            this.nextInstructionLabel.Text = "Next Intruction";
            // 
            // rabbitPictureBox
            // 
            this.rabbitPictureBox.Image = global::GeminiCPU.Properties.Resources.chubby;
            this.rabbitPictureBox.Location = new System.Drawing.Point(488, 89);
            this.rabbitPictureBox.Name = "rabbitPictureBox";
            this.rabbitPictureBox.Size = new System.Drawing.Size(192, 299);
            this.rabbitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rabbitPictureBox.TabIndex = 10;
            this.rabbitPictureBox.TabStop = false;
            // 
            // nxtInsLabel
            // 
            this.nxtInsLabel.AutoSize = true;
            this.nxtInsLabel.Location = new System.Drawing.Point(125, 89);
            this.nxtInsLabel.Name = "nxtInsLabel";
            this.nxtInsLabel.Size = new System.Drawing.Size(37, 13);
            this.nxtInsLabel.TabIndex = 9;
            this.nxtInsLabel.Text = "----------";
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
            // fetchNameLabel
            // 
            this.fetchNameLabel.AutoSize = true;
            this.fetchNameLabel.Location = new System.Drawing.Point(31, 479);
            this.fetchNameLabel.Name = "fetchNameLabel";
            this.fetchNameLabel.Size = new System.Drawing.Size(48, 13);
            this.fetchNameLabel.TabIndex = 29;
            this.fetchNameLabel.Text = "FETCH: ";
            // 
            // fetchLabel
            // 
            this.fetchLabel.AutoSize = true;
            this.fetchLabel.Location = new System.Drawing.Point(88, 478);
            this.fetchLabel.Name = "fetchLabel";
            this.fetchLabel.Size = new System.Drawing.Size(22, 13);
            this.fetchLabel.TabIndex = 30;
            this.fetchLabel.Text = "-----";
            // 
            // decodeNameLabel
            // 
            this.decodeNameLabel.AutoSize = true;
            this.decodeNameLabel.Location = new System.Drawing.Point(30, 492);
            this.decodeNameLabel.Name = "decodeNameLabel";
            this.decodeNameLabel.Size = new System.Drawing.Size(58, 13);
            this.decodeNameLabel.TabIndex = 31;
            this.decodeNameLabel.Text = "DECODE: ";
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(88, 491);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(22, 13);
            this.decodeLabel.TabIndex = 32;
            this.decodeLabel.Text = "-----";
            // 
            // executeNameLabel
            // 
            this.executeNameLabel.AutoSize = true;
            this.executeNameLabel.Location = new System.Drawing.Point(30, 504);
            this.executeNameLabel.Name = "executeNameLabel";
            this.executeNameLabel.Size = new System.Drawing.Size(63, 13);
            this.executeNameLabel.TabIndex = 33;
            this.executeNameLabel.Text = "EXECUTE: ";
            // 
            // executeLabel
            // 
            this.executeLabel.AutoSize = true;
            this.executeLabel.Location = new System.Drawing.Point(88, 504);
            this.executeLabel.Name = "executeLabel";
            this.executeLabel.Size = new System.Drawing.Size(22, 13);
            this.executeLabel.TabIndex = 34;
            this.executeLabel.Text = "-----";
            // 
            // writebackNameLabel
            // 
            this.writebackNameLabel.AutoSize = true;
            this.writebackNameLabel.Location = new System.Drawing.Point(30, 517);
            this.writebackNameLabel.Name = "writebackNameLabel";
            this.writebackNameLabel.Size = new System.Drawing.Size(49, 13);
            this.writebackNameLabel.TabIndex = 35;
            this.writebackNameLabel.Text = "WRITE: ";
            // 
            // writebackLabel
            // 
            this.writebackLabel.AutoSize = true;
            this.writebackLabel.Location = new System.Drawing.Point(88, 516);
            this.writebackLabel.Name = "writebackLabel";
            this.writebackLabel.Size = new System.Drawing.Size(22, 13);
            this.writebackLabel.TabIndex = 36;
            this.writebackLabel.Text = "-----";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.Text = "yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(112, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "no";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Location = new System.Drawing.Point(480, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 25);
            this.panel3.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Controls.Add(this.radioButton3);
            this.panel4.Location = new System.Drawing.Point(480, 560);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 27);
            this.panel4.TabIndex = 40;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "yes";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(112, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "no";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Bypassing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Branch Prediction";
            // 
            // oldfetch
            // 
            this.oldfetch.AutoSize = true;
            this.oldfetch.Location = new System.Drawing.Point(128, 478);
            this.oldfetch.Name = "oldfetch";
            this.oldfetch.Size = new System.Drawing.Size(22, 13);
            this.oldfetch.TabIndex = 43;
            this.oldfetch.Text = "-----";
            // 
            // olddecode
            // 
            this.olddecode.AutoSize = true;
            this.olddecode.Location = new System.Drawing.Point(128, 492);
            this.olddecode.Name = "olddecode";
            this.olddecode.Size = new System.Drawing.Size(22, 13);
            this.olddecode.TabIndex = 44;
            this.olddecode.Text = "-----";
            // 
            // oldexecute
            // 
            this.oldexecute.AutoSize = true;
            this.oldexecute.Location = new System.Drawing.Point(128, 504);
            this.oldexecute.Name = "oldexecute";
            this.oldexecute.Size = new System.Drawing.Size(22, 13);
            this.oldexecute.TabIndex = 45;
            this.oldexecute.Text = "-----";
            // 
            // oldwrite
            // 
            this.oldwrite.AutoSize = true;
            this.oldwrite.Location = new System.Drawing.Point(128, 517);
            this.oldwrite.Name = "oldwrite";
            this.oldwrite.Size = new System.Drawing.Size(22, 13);
            this.oldwrite.TabIndex = 46;
            this.oldwrite.Text = "-----";
            // 
            // olderfetch
            // 
            this.olderfetch.AutoSize = true;
            this.olderfetch.Location = new System.Drawing.Point(167, 477);
            this.olderfetch.Name = "olderfetch";
            this.olderfetch.Size = new System.Drawing.Size(22, 13);
            this.olderfetch.TabIndex = 47;
            this.olderfetch.Text = "-----";
            // 
            // olderdecode
            // 
            this.olderdecode.AutoSize = true;
            this.olderdecode.Location = new System.Drawing.Point(167, 490);
            this.olderdecode.Name = "olderdecode";
            this.olderdecode.Size = new System.Drawing.Size(22, 13);
            this.olderdecode.TabIndex = 48;
            this.olderdecode.Text = "-----";
            // 
            // olderexecute
            // 
            this.olderexecute.AutoSize = true;
            this.olderexecute.Location = new System.Drawing.Point(167, 503);
            this.olderexecute.Name = "olderexecute";
            this.olderexecute.Size = new System.Drawing.Size(22, 13);
            this.olderexecute.TabIndex = 49;
            this.olderexecute.Text = "-----";
            // 
            // olderwrite
            // 
            this.olderwrite.AutoSize = true;
            this.olderwrite.Location = new System.Drawing.Point(167, 516);
            this.olderwrite.Name = "olderwrite";
            this.olderwrite.Size = new System.Drawing.Size(22, 13);
            this.olderwrite.TabIndex = 50;
            this.olderwrite.Text = "-----";
            // 
            // oldestfetch
            // 
            this.oldestfetch.AutoSize = true;
            this.oldestfetch.Location = new System.Drawing.Point(207, 477);
            this.oldestfetch.Name = "oldestfetch";
            this.oldestfetch.Size = new System.Drawing.Size(22, 13);
            this.oldestfetch.TabIndex = 51;
            this.oldestfetch.Text = "-----";
            // 
            // oldestdecode
            // 
            this.oldestdecode.AutoSize = true;
            this.oldestdecode.Location = new System.Drawing.Point(207, 490);
            this.oldestdecode.Name = "oldestdecode";
            this.oldestdecode.Size = new System.Drawing.Size(22, 13);
            this.oldestdecode.TabIndex = 52;
            this.oldestdecode.Text = "-----";
            // 
            // oldestexecute
            // 
            this.oldestexecute.AutoSize = true;
            this.oldestexecute.Location = new System.Drawing.Point(207, 503);
            this.oldestexecute.Name = "oldestexecute";
            this.oldestexecute.Size = new System.Drawing.Size(22, 13);
            this.oldestexecute.TabIndex = 53;
            this.oldestexecute.Text = "-----";
            // 
            // oldestwrite
            // 
            this.oldestwrite.AutoSize = true;
            this.oldestwrite.Location = new System.Drawing.Point(207, 516);
            this.oldestwrite.Name = "oldestwrite";
            this.oldestwrite.Size = new System.Drawing.Size(22, 13);
            this.oldestwrite.TabIndex = 54;
            this.oldestwrite.Text = "-----";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "current";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(129, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "old";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(170, 448);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = "o2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(210, 448);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "o3";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 638);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.oldestwrite);
            this.Controls.Add(this.oldestexecute);
            this.Controls.Add(this.oldestdecode);
            this.Controls.Add(this.oldestfetch);
            this.Controls.Add(this.olderwrite);
            this.Controls.Add(this.olderexecute);
            this.Controls.Add(this.olderdecode);
            this.Controls.Add(this.olderfetch);
            this.Controls.Add(this.oldwrite);
            this.Controls.Add(this.oldexecute);
            this.Controls.Add(this.olddecode);
            this.Controls.Add(this.oldfetch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.writebackLabel);
            this.Controls.Add(this.writebackNameLabel);
            this.Controls.Add(this.executeLabel);
            this.Controls.Add(this.executeNameLabel);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.decodeNameLabel);
            this.Controls.Add(this.fetchLabel);
            this.Controls.Add(this.fetchNameLabel);
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
            this.Controls.Add(this.rabbitPictureBox);
            this.Controls.Add(this.nxtInsLabel);
            this.Controls.Add(this.nextInstructionLabel);
            this.Controls.Add(this.insIndex);
            this.Controls.Add(this.InstructionIndexLabel);
            this.Controls.Add(this.RunToEndButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.resetCPU);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.RegisterPanel);
            this.Name = "Window";
            this.Text = "Gemini";
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CacheSizeTrack)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RegisterPanel;
        private System.Windows.Forms.Label registerColumnLabel;
        private System.Windows.Forms.Label ValueColumnLabel;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label ACCLabel;
        private System.Windows.Forms.Label ZEROLabel;
        private System.Windows.Forms.Label ONELabel;
        private System.Windows.Forms.Label PCLabel;
        private System.Windows.Forms.Label MARLabel;
        private System.Windows.Forms.Label MDRLabel;
        private System.Windows.Forms.Label TEMPLabel;
        private System.Windows.Forms.Label IRLabel;
        private System.Windows.Forms.Label CCLabel;
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
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button resetCPU;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RunToEndButton;
        private System.Windows.Forms.Label InstructionIndexLabel;
        private System.Windows.Forms.Label insIndex;
        private System.Windows.Forms.Label nxtInsLabel;
        private System.Windows.Forms.PictureBox rabbitPictureBox;
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
        private System.Windows.Forms.Label nextInstructionLabel;
        private System.Windows.Forms.Label fetchNameLabel;
        private System.Windows.Forms.Label fetchLabel;
        private System.Windows.Forms.Label decodeNameLabel;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label executeNameLabel;
        private System.Windows.Forms.Label executeLabel;
        private System.Windows.Forms.Label writebackNameLabel;
        private System.Windows.Forms.Label writebackLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oldfetch;
        private System.Windows.Forms.Label olddecode;
        private System.Windows.Forms.Label oldexecute;
        private System.Windows.Forms.Label oldwrite;
        private System.Windows.Forms.Label olderfetch;
        private System.Windows.Forms.Label olderdecode;
        private System.Windows.Forms.Label olderexecute;
        private System.Windows.Forms.Label olderwrite;
        private System.Windows.Forms.Label oldestfetch;
        private System.Windows.Forms.Label oldestdecode;
        private System.Windows.Forms.Label oldestexecute;
        private System.Windows.Forms.Label oldestwrite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;


    }
}

