namespace MoblieRobotSystem.Forms
{
    partial class FormControlSettings
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
            lblPgainSetting = new Label();
            lblDgainSetting = new Label();
            lblIgainSetting = new Label();
            tbxPgainSet = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnGainSet = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblCurrentPgain = new Label();
            lblCurrentIgain = new Label();
            lblCurrentDgain = new Label();
            SuspendLayout();
            // 
            // lblPgainSetting
            // 
            lblPgainSetting.AutoSize = true;
            lblPgainSetting.Location = new Point(37, 29);
            lblPgainSetting.Name = "lblPgainSetting";
            lblPgainSetting.Size = new Size(84, 15);
            lblPgainSetting.TabIndex = 0;
            lblPgainSetting.Text = "P Gain Setting";
            // 
            // lblDgainSetting
            // 
            lblDgainSetting.AutoSize = true;
            lblDgainSetting.Location = new Point(277, 29);
            lblDgainSetting.Name = "lblDgainSetting";
            lblDgainSetting.Size = new Size(86, 15);
            lblDgainSetting.TabIndex = 1;
            lblDgainSetting.Text = "D Gain Setting";
            // 
            // lblIgainSetting
            // 
            lblIgainSetting.AutoSize = true;
            lblIgainSetting.Location = new Point(158, 29);
            lblIgainSetting.Name = "lblIgainSetting";
            lblIgainSetting.Size = new Size(80, 15);
            lblIgainSetting.TabIndex = 2;
            lblIgainSetting.Text = "I Gain Setting";
            // 
            // tbxPgainSet
            // 
            tbxPgainSet.Location = new Point(37, 61);
            tbxPgainSet.Name = "tbxPgainSet";
            tbxPgainSet.Size = new Size(90, 23);
            tbxPgainSet.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 23);
            textBox3.TabIndex = 5;
            // 
            // btnGainSet
            // 
            btnGainSet.Location = new Point(399, 60);
            btnGainSet.Name = "btnGainSet";
            btnGainSet.Size = new Size(75, 23);
            btnGainSet.TabIndex = 6;
            btnGainSet.Text = "Gain Set";
            btnGainSet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(90, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(277, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(90, 23);
            textBox5.TabIndex = 9;
            // 
            // lblCurrentPgain
            // 
            lblCurrentPgain.AutoSize = true;
            lblCurrentPgain.Location = new Point(37, 101);
            lblCurrentPgain.Name = "lblCurrentPgain";
            lblCurrentPgain.Size = new Size(86, 15);
            lblCurrentPgain.TabIndex = 10;
            lblCurrentPgain.Text = "Current P Gain";
            // 
            // lblCurrentIgain
            // 
            lblCurrentIgain.AutoSize = true;
            lblCurrentIgain.Location = new Point(158, 101);
            lblCurrentIgain.Name = "lblCurrentIgain";
            lblCurrentIgain.Size = new Size(82, 15);
            lblCurrentIgain.TabIndex = 11;
            lblCurrentIgain.Text = "Current I Gain";
            // 
            // lblCurrentDgain
            // 
            lblCurrentDgain.AutoSize = true;
            lblCurrentDgain.Location = new Point(277, 101);
            lblCurrentDgain.Name = "lblCurrentDgain";
            lblCurrentDgain.Size = new Size(88, 15);
            lblCurrentDgain.TabIndex = 12;
            lblCurrentDgain.Text = "Current D Gain";
            // 
            // FormControlSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentDgain);
            Controls.Add(lblCurrentIgain);
            Controls.Add(lblCurrentPgain);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(btnGainSet);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(tbxPgainSet);
            Controls.Add(lblIgainSetting);
            Controls.Add(lblDgainSetting);
            Controls.Add(lblPgainSetting);
            Name = "FormControlSettings";
            Text = "FormControlSettings";
            Load += FormControlSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPgainSetting;
        private Label lblDgainSetting;
        private Label lblIgainSetting;
        private TextBox tbxPgainSet;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnGainSet;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblCurrentPgain;
        private Label lblCurrentIgain;
        private Label lblCurrentDgain;
    }
}