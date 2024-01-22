namespace MoblieRobotSystem
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnROSSettings = new Button();
            btnControlSettings = new Button();
            btnRobotStatus = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gray;
            panelMenu.Controls.Add(btnROSSettings);
            panelMenu.Controls.Add(btnControlSettings);
            panelMenu.Controls.Add(btnRobotStatus);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 700);
            panelMenu.TabIndex = 1;
            // 
            // btnROSSettings
            // 
            btnROSSettings.Dock = DockStyle.Top;
            btnROSSettings.FlatAppearance.BorderSize = 0;
            btnROSSettings.FlatStyle = FlatStyle.Flat;
            btnROSSettings.Font = new Font("맑은 고딕", 10F);
            btnROSSettings.ForeColor = Color.Gainsboro;
            btnROSSettings.Image = (Image)resources.GetObject("btnROSSettings.Image");
            btnROSSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnROSSettings.Location = new Point(0, 180);
            btnROSSettings.Name = "btnROSSettings";
            btnROSSettings.Padding = new Padding(8, 0, 0, 0);
            btnROSSettings.Size = new Size(220, 60);
            btnROSSettings.TabIndex = 5;
            btnROSSettings.Text = "  ROS Settings";
            btnROSSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnROSSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnROSSettings.UseVisualStyleBackColor = true;
            btnROSSettings.Click += btnROSSettings_Click;
            // 
            // btnControlSettings
            // 
            btnControlSettings.Dock = DockStyle.Top;
            btnControlSettings.FlatAppearance.BorderSize = 0;
            btnControlSettings.FlatStyle = FlatStyle.Flat;
            btnControlSettings.Font = new Font("맑은 고딕", 10F);
            btnControlSettings.ForeColor = Color.Gainsboro;
            btnControlSettings.Image = (Image)resources.GetObject("btnControlSettings.Image");
            btnControlSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnControlSettings.Location = new Point(0, 120);
            btnControlSettings.Name = "btnControlSettings";
            btnControlSettings.Padding = new Padding(8, 0, 0, 0);
            btnControlSettings.Size = new Size(220, 60);
            btnControlSettings.TabIndex = 2;
            btnControlSettings.Text = "  Control Settings";
            btnControlSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnControlSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnControlSettings.UseVisualStyleBackColor = true;
            btnControlSettings.Click += btnControlSetting_Click;
            // 
            // btnRobotStatus
            // 
            btnRobotStatus.Dock = DockStyle.Top;
            btnRobotStatus.FlatAppearance.BorderSize = 0;
            btnRobotStatus.FlatStyle = FlatStyle.Flat;
            btnRobotStatus.Font = new Font("맑은 고딕", 10F);
            btnRobotStatus.ForeColor = Color.Gainsboro;
            btnRobotStatus.Image = (Image)resources.GetObject("btnRobotStatus.Image");
            btnRobotStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnRobotStatus.Location = new Point(0, 60);
            btnRobotStatus.Name = "btnRobotStatus";
            btnRobotStatus.Padding = new Padding(8, 0, 0, 0);
            btnRobotStatus.Size = new Size(220, 60);
            btnRobotStatus.TabIndex = 1;
            btnRobotStatus.Text = "  Robot Status";
            btnRobotStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnRobotStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRobotStatus.UseVisualStyleBackColor = true;
            btnRobotStatus.Click += btnRobotStatus_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DimGray;
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 60);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("HY견고딕", 11F, FontStyle.Bold);
            lblLogo.ForeColor = Color.LightGray;
            lblLogo.Location = new Point(7, 19);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(206, 15);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Mobile Robot Systems";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Silver;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(780, 60);
            panelTitleBar.TabIndex = 6;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 15F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(678, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 10;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 15F);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(714, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 10;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 15F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(750, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.x_icon;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(49, 60);
            btnCloseChildForm.TabIndex = 8;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(346, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 26);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Controls.Add(label1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(780, 640);
            panelDesktop.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(346, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("HY견고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(277, 324);
            label1.Name = "label1";
            label1.Size = new Size(202, 16);
            label1.TabIndex = 1;
            label1.Text = "Mobile Robot Systems";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 700);
            Name = "FormMainMenu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnRobotStatus;
        private Button btnControlSettings;
        private Button btnROSSettings;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private Panel panelDesktop;
        private Button btnCloseChildForm;
        private PictureBox pictureBox1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label label1;
    }
}
