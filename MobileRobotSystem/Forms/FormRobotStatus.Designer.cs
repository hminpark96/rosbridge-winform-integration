using MoblieRobotSystem.Controls;

namespace MoblieRobotSystem.Forms
{
    partial class FormRobotStatus
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
            components = new System.ComponentModel.Container();
            lblLinearVelo = new Label();
            lblAngularVelo = new Label();
            pltRightImuData = new ScottPlot.FormsPlot();
            lblLeftImuData = new Label();
            pltMobileRobotVelo = new ScottPlot.FormsPlot();
            pltLeftImuData = new ScottPlot.FormsPlot();
            panel1 = new Panel();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblRIMUzData = new Label();
            lblRIMUyData = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblMIMUzData = new Label();
            lblMIMUyData = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblLIMUzData = new Label();
            lblLIMUyData = new Label();
            lblRIMUxData = new Label();
            lblMIMUxData = new Label();
            lblLIMUxData = new Label();
            lblAngVelData = new Label();
            lblLinVelData = new Label();
            lblRightImuData = new Label();
            lblMidImuData = new Label();
            panel2 = new Panel();
            label1 = new Label();
            tbtnRunGraph = new HMToggleButton();
            panelMainGraph = new Panel();
            panelMidImuGraph = new Panel();
            pltMidImuData = new ScottPlot.FormsPlot();
            panelRightImuGraph = new Panel();
            panelLeftImuGraph = new Panel();
            panelMRVeloGraph = new Panel();
            timerUpdateData = new System.Windows.Forms.Timer(components);
            timerRender = new System.Windows.Forms.Timer(components);
            timerRenderLabel = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelMainGraph.SuspendLayout();
            panelMidImuGraph.SuspendLayout();
            panelRightImuGraph.SuspendLayout();
            panelLeftImuGraph.SuspendLayout();
            panelMRVeloGraph.SuspendLayout();
            SuspendLayout();
            // 
            // lblLinearVelo
            // 
            lblLinearVelo.AutoSize = true;
            lblLinearVelo.Location = new Point(23, 59);
            lblLinearVelo.Name = "lblLinearVelo";
            lblLinearVelo.Size = new Size(86, 15);
            lblLinearVelo.TabIndex = 0;
            lblLinearVelo.Text = "Linear Velocity";
            // 
            // lblAngularVelo
            // 
            lblAngularVelo.AutoSize = true;
            lblAngularVelo.Location = new Point(23, 79);
            lblAngularVelo.Name = "lblAngularVelo";
            lblAngularVelo.Size = new Size(96, 15);
            lblAngularVelo.TabIndex = 1;
            lblAngularVelo.Text = "Angular Velocity";
            // 
            // pltRightImuData
            // 
            pltRightImuData.Dock = DockStyle.Fill;
            pltRightImuData.Location = new Point(0, 0);
            pltRightImuData.Margin = new Padding(4, 3, 4, 3);
            pltRightImuData.Name = "pltRightImuData";
            pltRightImuData.Size = new Size(689, 135);
            pltRightImuData.TabIndex = 4;
            // 
            // lblLeftImuData
            // 
            lblLeftImuData.AutoSize = true;
            lblLeftImuData.Location = new Point(23, 171);
            lblLeftImuData.Name = "lblLeftImuData";
            lblLeftImuData.Size = new Size(90, 15);
            lblLeftImuData.TabIndex = 1;
            lblLeftImuData.Text = "IMU Data (Left)";
            // 
            // pltMobileRobotVelo
            // 
            pltMobileRobotVelo.AutoSize = true;
            pltMobileRobotVelo.Dock = DockStyle.Fill;
            pltMobileRobotVelo.Location = new Point(0, 0);
            pltMobileRobotVelo.Margin = new Padding(4, 3, 4, 3);
            pltMobileRobotVelo.Name = "pltMobileRobotVelo";
            pltMobileRobotVelo.Size = new Size(689, 137);
            pltMobileRobotVelo.TabIndex = 4;
            // 
            // pltLeftImuData
            // 
            pltLeftImuData.AutoSize = true;
            pltLeftImuData.Dock = DockStyle.Fill;
            pltLeftImuData.Location = new Point(0, 0);
            pltLeftImuData.Margin = new Padding(4, 3, 4, 3);
            pltLeftImuData.Name = "pltLeftImuData";
            pltLeftImuData.Size = new Size(689, 137);
            pltLeftImuData.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblRIMUzData);
            panel1.Controls.Add(lblRIMUyData);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblMIMUzData);
            panel1.Controls.Add(lblMIMUyData);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblLIMUzData);
            panel1.Controls.Add(lblLIMUyData);
            panel1.Controls.Add(lblRIMUxData);
            panel1.Controls.Add(lblMIMUxData);
            panel1.Controls.Add(lblLIMUxData);
            panel1.Controls.Add(lblAngVelData);
            panel1.Controls.Add(lblLinVelData);
            panel1.Controls.Add(lblRightImuData);
            panel1.Controls.Add(lblMidImuData);
            panel1.Controls.Add(lblLinearVelo);
            panel1.Controls.Add(lblAngularVelo);
            panel1.Controls.Add(lblLeftImuData);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 541);
            panel1.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(118, 478);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 30;
            label12.Text = "z";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(118, 459);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 29;
            label13.Text = "y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(118, 441);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 28;
            label14.Text = "x";
            // 
            // lblRIMUzData
            // 
            lblRIMUzData.AutoSize = true;
            lblRIMUzData.Location = new Point(133, 478);
            lblRIMUzData.Name = "lblRIMUzData";
            lblRIMUzData.Size = new Size(38, 15);
            lblRIMUzData.TabIndex = 27;
            lblRIMUzData.Text = "00.00";
            // 
            // lblRIMUyData
            // 
            lblRIMUyData.AutoSize = true;
            lblRIMUyData.Location = new Point(133, 459);
            lblRIMUyData.Name = "lblRIMUyData";
            lblRIMUyData.Size = new Size(38, 15);
            lblRIMUyData.TabIndex = 26;
            lblRIMUyData.Text = "00.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 343);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 25;
            label7.Text = "z";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 324);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 24;
            label8.Text = "y";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 306);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 23;
            label9.Text = "x";
            // 
            // lblMIMUzData
            // 
            lblMIMUzData.AutoSize = true;
            lblMIMUzData.Location = new Point(133, 343);
            lblMIMUzData.Name = "lblMIMUzData";
            lblMIMUzData.Size = new Size(38, 15);
            lblMIMUzData.TabIndex = 22;
            lblMIMUzData.Text = "00.00";
            // 
            // lblMIMUyData
            // 
            lblMIMUyData.AutoSize = true;
            lblMIMUyData.Location = new Point(133, 324);
            lblMIMUyData.Name = "lblMIMUyData";
            lblMIMUyData.Size = new Size(38, 15);
            lblMIMUyData.TabIndex = 21;
            lblMIMUyData.Text = "00.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 208);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 20;
            label6.Text = "z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 189);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 19;
            label5.Text = "y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 171);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 18;
            label4.Text = "x";
            // 
            // lblLIMUzData
            // 
            lblLIMUzData.AutoSize = true;
            lblLIMUzData.Location = new Point(133, 208);
            lblLIMUzData.Name = "lblLIMUzData";
            lblLIMUzData.Size = new Size(38, 15);
            lblLIMUzData.TabIndex = 17;
            lblLIMUzData.Text = "00.00";
            // 
            // lblLIMUyData
            // 
            lblLIMUyData.AutoSize = true;
            lblLIMUyData.Location = new Point(133, 189);
            lblLIMUyData.Name = "lblLIMUyData";
            lblLIMUyData.Size = new Size(38, 15);
            lblLIMUyData.TabIndex = 16;
            lblLIMUyData.Text = "00.00";
            // 
            // lblRIMUxData
            // 
            lblRIMUxData.AutoSize = true;
            lblRIMUxData.Location = new Point(133, 441);
            lblRIMUxData.Name = "lblRIMUxData";
            lblRIMUxData.Size = new Size(38, 15);
            lblRIMUxData.TabIndex = 15;
            lblRIMUxData.Text = "00.00";
            // 
            // lblMIMUxData
            // 
            lblMIMUxData.AutoSize = true;
            lblMIMUxData.Location = new Point(133, 306);
            lblMIMUxData.Name = "lblMIMUxData";
            lblMIMUxData.Size = new Size(38, 15);
            lblMIMUxData.TabIndex = 14;
            lblMIMUxData.Text = "00.00";
            // 
            // lblLIMUxData
            // 
            lblLIMUxData.AutoSize = true;
            lblLIMUxData.Location = new Point(133, 171);
            lblLIMUxData.Name = "lblLIMUxData";
            lblLIMUxData.Size = new Size(38, 15);
            lblLIMUxData.TabIndex = 13;
            lblLIMUxData.Text = "00.00";
            // 
            // lblAngVelData
            // 
            lblAngVelData.AutoSize = true;
            lblAngVelData.Location = new Point(133, 79);
            lblAngVelData.Name = "lblAngVelData";
            lblAngVelData.Size = new Size(38, 15);
            lblAngVelData.TabIndex = 12;
            lblAngVelData.Text = "00.00";
            // 
            // lblLinVelData
            // 
            lblLinVelData.AutoSize = true;
            lblLinVelData.Location = new Point(133, 59);
            lblLinVelData.Name = "lblLinVelData";
            lblLinVelData.Size = new Size(38, 15);
            lblLinVelData.TabIndex = 11;
            lblLinVelData.Text = "00.00";
            // 
            // lblRightImuData
            // 
            lblRightImuData.AutoSize = true;
            lblRightImuData.Location = new Point(23, 441);
            lblRightImuData.Name = "lblRightImuData";
            lblRightImuData.Size = new Size(98, 15);
            lblRightImuData.TabIndex = 10;
            lblRightImuData.Text = "IMU Data (Right)";
            // 
            // lblMidImuData
            // 
            lblMidImuData.AutoSize = true;
            lblMidImuData.Location = new Point(23, 306);
            lblMidImuData.Name = "lblMidImuData";
            lblMidImuData.Size = new Size(91, 15);
            lblMidImuData.TabIndex = 9;
            lblMidImuData.Text = "IMU Data (Mid)";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbtnRunGraph);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 47);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 13);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Run";
            // 
            // tbtnRunGraph
            // 
            tbtnRunGraph.AutoSize = true;
            tbtnRunGraph.Location = new Point(57, 10);
            tbtnRunGraph.MinimumSize = new Size(35, 22);
            tbtnRunGraph.Name = "tbtnRunGraph";
            tbtnRunGraph.OffBackColor = Color.Gray;
            tbtnRunGraph.OffToggleColor = Color.Gainsboro;
            tbtnRunGraph.OnBackColor = Color.MediumSlateBlue;
            tbtnRunGraph.OnToggleColor = Color.WhiteSmoke;
            tbtnRunGraph.Size = new Size(35, 22);
            tbtnRunGraph.TabIndex = 0;
            tbtnRunGraph.UseVisualStyleBackColor = true;
            tbtnRunGraph.CheckedChanged += tbtnRunGraph_CheckedChanged;
            // 
            // panelMainGraph
            // 
            panelMainGraph.Controls.Add(panelMidImuGraph);
            panelMainGraph.Controls.Add(panelRightImuGraph);
            panelMainGraph.Controls.Add(panelLeftImuGraph);
            panelMainGraph.Controls.Add(panelMRVeloGraph);
            panelMainGraph.Dock = DockStyle.Fill;
            panelMainGraph.Location = new Point(200, 0);
            panelMainGraph.Name = "panelMainGraph";
            panelMainGraph.Size = new Size(689, 541);
            panelMainGraph.TabIndex = 8;
            // 
            // panelMidImuGraph
            // 
            panelMidImuGraph.Controls.Add(pltMidImuData);
            panelMidImuGraph.Dock = DockStyle.Fill;
            panelMidImuGraph.Location = new Point(0, 274);
            panelMidImuGraph.Name = "panelMidImuGraph";
            panelMidImuGraph.Size = new Size(689, 132);
            panelMidImuGraph.TabIndex = 31;
            // 
            // pltMidImuData
            // 
            pltMidImuData.AutoSize = true;
            pltMidImuData.Dock = DockStyle.Fill;
            pltMidImuData.Location = new Point(0, 0);
            pltMidImuData.Margin = new Padding(4, 3, 4, 3);
            pltMidImuData.Name = "pltMidImuData";
            pltMidImuData.Size = new Size(689, 132);
            pltMidImuData.TabIndex = 6;
            // 
            // panelRightImuGraph
            // 
            panelRightImuGraph.Controls.Add(pltRightImuData);
            panelRightImuGraph.Dock = DockStyle.Bottom;
            panelRightImuGraph.Location = new Point(0, 406);
            panelRightImuGraph.Name = "panelRightImuGraph";
            panelRightImuGraph.Size = new Size(689, 135);
            panelRightImuGraph.TabIndex = 2;
            // 
            // panelLeftImuGraph
            // 
            panelLeftImuGraph.Controls.Add(pltLeftImuData);
            panelLeftImuGraph.Dock = DockStyle.Top;
            panelLeftImuGraph.Location = new Point(0, 137);
            panelLeftImuGraph.Name = "panelLeftImuGraph";
            panelLeftImuGraph.Size = new Size(689, 137);
            panelLeftImuGraph.TabIndex = 1;
            // 
            // panelMRVeloGraph
            // 
            panelMRVeloGraph.Controls.Add(pltMobileRobotVelo);
            panelMRVeloGraph.Dock = DockStyle.Top;
            panelMRVeloGraph.Location = new Point(0, 0);
            panelMRVeloGraph.Name = "panelMRVeloGraph";
            panelMRVeloGraph.Size = new Size(689, 137);
            panelMRVeloGraph.TabIndex = 0;
            // 
            // timerUpdateData
            // 
            timerUpdateData.Interval = 10;
            timerUpdateData.Tick += timerUpdateData_Tick;
            // 
            // timerRender
            // 
            timerRender.Interval = 20;
            timerRender.Tick += timerRender_Tick;
            // 
            // timerRenderLabel
            // 
            timerRenderLabel.Tick += timerRenderLabel_Tick;
            // 
            // FormRobotStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 541);
            Controls.Add(panelMainGraph);
            Controls.Add(panel1);
            Name = "FormRobotStatus";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FormRobotStatus";
            Load += FormRobotStatus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMainGraph.ResumeLayout(false);
            panelMidImuGraph.ResumeLayout(false);
            panelMidImuGraph.PerformLayout();
            panelRightImuGraph.ResumeLayout(false);
            panelLeftImuGraph.ResumeLayout(false);
            panelLeftImuGraph.PerformLayout();
            panelMRVeloGraph.ResumeLayout(false);
            panelMRVeloGraph.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLinearVelo;
        private Label lblAngularVelo;
        private ScottPlot.FormsPlot pltRightImuData;
        private Label lblLeftImuData;
        private ScottPlot.FormsPlot pltMobileRobotVelo;
        private ScottPlot.FormsPlot pltLeftImuData;
        private Panel panel1;
        private Panel panel2;
        private Panel panelMainGraph;
        private Panel panelMRVeloGraph;
        private Panel panelRightImuGraph;
        private Panel panelLeftImuGraph;
        private HMToggleButton tbtnRunGraph;
        private Label label1;
        private System.Windows.Forms.Timer timerUpdateData;
        private System.Windows.Forms.Timer timerRender;
        private Label lblMidImuData;
        private Label lblRightImuData;
        private Label lblRIMUxData;
        private Label lblMIMUxData;
        private Label lblLIMUxData;
        private Label lblAngVelData;
        private Label lblLinVelData;
        private Label label4;
        private Label lblLIMUzData;
        private Label lblLIMUyData;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblRIMUzData;
        private Label lblRIMUyData;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblMIMUzData;
        private Label lblMIMUyData;
        private Label label6;
        private Label label5;
        private System.Windows.Forms.Timer timerRenderLabel;
        private Panel panelMidImuGraph;
        private ScottPlot.FormsPlot pltMidImuData;
    }
}