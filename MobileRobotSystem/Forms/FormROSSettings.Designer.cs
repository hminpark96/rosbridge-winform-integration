namespace MoblieRobotSystem.Forms
{
    partial class FormROSSettings
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
            lblROSConnection = new Label();
            btnRosConnect = new Button();
            btnRosDisconnect = new Button();
            btnSubscribe = new Button();
            btnPublish = new Button();
            tbxRosBridgeServerUrl = new TextBox();
            SuspendLayout();
            // 
            // lblROSConnection
            // 
            lblROSConnection.AutoSize = true;
            lblROSConnection.Location = new Point(29, 30);
            lblROSConnection.Name = "lblROSConnection";
            lblROSConnection.Size = new Size(96, 15);
            lblROSConnection.TabIndex = 0;
            lblROSConnection.Text = "ROS Connection";
            // 
            // btnRosConnect
            // 
            btnRosConnect.FlatStyle = FlatStyle.Flat;
            btnRosConnect.Location = new Point(29, 80);
            btnRosConnect.Name = "btnRosConnect";
            btnRosConnect.Size = new Size(174, 46);
            btnRosConnect.TabIndex = 1;
            btnRosConnect.Text = "Connect";
            btnRosConnect.UseVisualStyleBackColor = true;
            btnRosConnect.Click += btnRosConnect_Click;
            // 
            // btnRosDisconnect
            // 
            btnRosDisconnect.FlatStyle = FlatStyle.Flat;
            btnRosDisconnect.Location = new Point(209, 80);
            btnRosDisconnect.Name = "btnRosDisconnect";
            btnRosDisconnect.Size = new Size(179, 46);
            btnRosDisconnect.TabIndex = 2;
            btnRosDisconnect.Text = "Disconnect";
            btnRosDisconnect.UseVisualStyleBackColor = true;
            btnRosDisconnect.Click += btnRosDisconnect_Click;
            // 
            // btnSubscribe
            // 
            btnSubscribe.FlatStyle = FlatStyle.Flat;
            btnSubscribe.Location = new Point(209, 133);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(179, 49);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Subscibe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnPublish
            // 
            btnPublish.FlatStyle = FlatStyle.Flat;
            btnPublish.Location = new Point(29, 133);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(174, 49);
            btnPublish.TabIndex = 4;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // tbxRosBridgeServerUrl
            // 
            tbxRosBridgeServerUrl.Location = new Point(155, 30);
            tbxRosBridgeServerUrl.Name = "tbxRosBridgeServerUrl";
            tbxRosBridgeServerUrl.Size = new Size(233, 23);
            tbxRosBridgeServerUrl.TabIndex = 5;
            // 
            // FormROSSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxRosBridgeServerUrl);
            Controls.Add(btnPublish);
            Controls.Add(btnSubscribe);
            Controls.Add(btnRosDisconnect);
            Controls.Add(btnRosConnect);
            Controls.Add(lblROSConnection);
            Name = "FormROSSettings";
            Text = "FormROSSettings";
            Load += FormROSSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblROSConnection;
        private Button btnRosConnect;
        private Button btnRosDisconnect;
        private Button btnSubscribe;
        private Button btnPublish;
        private TextBox tbxRosBridgeServerUrl;
    }
}