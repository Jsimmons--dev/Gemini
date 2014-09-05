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
            this.ACCLabel = new System.Windows.Forms.Label();
            this.ACCValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ACCLabel
            // 
            this.ACCLabel.AutoSize = true;
            this.ACCLabel.Location = new System.Drawing.Point(25, 36);
            this.ACCLabel.Name = "ACCLabel";
            this.ACCLabel.Size = new System.Drawing.Size(28, 13);
            this.ACCLabel.TabIndex = 0;
            this.ACCLabel.Text = "ACC";
            // 
            // ACCValueLabel
            // 
            this.ACCValueLabel.AutoSize = true;
            this.ACCValueLabel.Location = new System.Drawing.Point(60, 35);
            this.ACCValueLabel.Name = "ACCValueLabel";
            this.ACCValueLabel.Size = new System.Drawing.Size(33, 13);
            this.ACCValueLabel.TabIndex = 1;
            this.ACCValueLabel.Text = "value";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ACCValueLabel);
            this.Controls.Add(this.ACCLabel);
            this.Name = "Window";
            this.Text = "Gemini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ACCLabel;
        private System.Windows.Forms.Label ACCValueLabel;
    }
}

