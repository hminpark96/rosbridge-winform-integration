using MoblieRobotSystem.Utilities.CostumUI;
using MoblieRobotSystem.Utilities.RosCommunication;
using ScottPlot;
using System.Diagnostics;


namespace MoblieRobotSystem.Forms
{
    public partial class FormRobotStatus : Form
    {
        //Field
        Random rand = new Random();
        double[] linearVelocity = new double[400];
        double[] angularVelocity = new double[400];
        double[] leftImu_x = new double[400];
        double[] leftImu_y = new double[400];
        double[] leftImu_z = new double[400];
        double[] midImu_x = new double[400];
        double[] midImu_y = new double[400];
        double[] midImu_z = new double[400];
        double[] rightImu_x = new double[400];
        double[] rightImu_y = new double[400];
        double[] rightImu_z = new double[400];
        Stopwatch sw = Stopwatch.StartNew();

        //Constructor
        public FormRobotStatus()
        {
            InitializeComponent();
            this.Resize += new EventHandler(PanelResize);
            InitializePlot();
            AdjustPanelSizes();

            Closed += (sender, args) =>
            {
                timerUpdateData?.Stop();
                timerRender?.Stop();
                timerRenderLabel?.Stop();
            };

            //
            tbtnRunGraph.OnBackColor = Color.FromArgb(18, 104, 129);
        }

        //Methods
        private void FormRobotStatus_Load(object sender, EventArgs e)
        {
            LoadTheme();
   
        }
        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
                double nextLinearVelocity = RosbridgeManager.Instance.TwistSubscriber.linearVelocity.x;
                double nextAngularVelocity = RosbridgeManager.Instance.TwistSubscriber.angularVelocity.z;
                double nextLeftImu_x = RosbridgeManager.Instance.Float32MultiArraySubscriber1.data[0];
                double nextLeftImu_y = RosbridgeManager.Instance.Float32MultiArraySubscriber1.data[1];
                double nextLeftImu_z = RosbridgeManager.Instance.Float32MultiArraySubscriber1.data[2];
                double nextMidImu_x = RosbridgeManager.Instance.Float32MultiArraySubscriber2.data[0];
                double nextMidImu_y = RosbridgeManager.Instance.Float32MultiArraySubscriber2.data[1];
                double nextMidImu_z = RosbridgeManager.Instance.Float32MultiArraySubscriber2.data[2];
                double nextRightImu_x = RosbridgeManager.Instance.Float32MultiArraySubscriber3.data[0];
                double nextRightImu_y = RosbridgeManager.Instance.Float32MultiArraySubscriber3.data[1];
                double nextRightImu_z = RosbridgeManager.Instance.Float32MultiArraySubscriber3.data[2];

                Array.Copy(linearVelocity, 1, linearVelocity, 0, linearVelocity.Length - 1);
                Array.Copy(angularVelocity, 1, angularVelocity, 0, angularVelocity.Length - 1);
                Array.Copy(leftImu_x, 1, leftImu_x, 0, leftImu_x.Length - 1);
                Array.Copy(leftImu_y, 1, leftImu_y, 0, leftImu_y.Length - 1);
                Array.Copy(leftImu_z, 1, leftImu_z, 0, leftImu_z.Length - 1);
                Array.Copy(midImu_x, 1, midImu_x, 0, midImu_x.Length - 1);
                Array.Copy(midImu_y, 1, midImu_y, 0, midImu_y.Length - 1);
                Array.Copy(midImu_z, 1, midImu_z, 0, midImu_z.Length - 1);
                Array.Copy(rightImu_x, 1, rightImu_x, 0, rightImu_x.Length - 1);
                Array.Copy(rightImu_y, 1, rightImu_y, 0, rightImu_y.Length - 1);
                Array.Copy(rightImu_z, 1, rightImu_z, 0, rightImu_z.Length - 1);

                linearVelocity[linearVelocity.Length - 1] = nextLinearVelocity;
                angularVelocity[angularVelocity.Length - 1] = nextAngularVelocity;
                leftImu_x[leftImu_x.Length - 1] = nextLeftImu_x;
                leftImu_y[leftImu_y.Length - 1] = nextLeftImu_y;
                leftImu_z[leftImu_z.Length - 1] = nextLeftImu_z;
                midImu_x[midImu_x.Length - 1] = nextMidImu_x;
                midImu_y[midImu_y.Length - 1] = nextMidImu_y;
                midImu_z[midImu_z.Length - 1] = nextMidImu_z;
                rightImu_x[rightImu_x.Length - 1] = nextRightImu_x;
                rightImu_y[rightImu_y.Length - 1] = nextRightImu_y;
                rightImu_z[rightImu_z.Length - 1] = nextRightImu_z;
        }

        private void timerRender_Tick(object sender, EventArgs e)
        {
            pltMobileRobotVelo.Refresh();
            pltMidImuData.Refresh();
            pltLeftImuData.Refresh();
            pltRightImuData.Refresh();
        }

        private void timerRenderLabel_Tick(object sender, EventArgs e)
        {
            lblLinVelData.Text = linearVelocity[0].ToString("F2");
            lblAngVelData.Text = angularVelocity[0].ToString("F2");
            lblLIMUxData.Text = leftImu_x[0].ToString("F2");
            lblLIMUyData.Text = leftImu_y[0].ToString("F2");
            lblLIMUzData.Text = leftImu_z[0].ToString("F2");
            //Debug.WriteLine("timerRenderLabel");
        }

        private void tbtnRunGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (RosbridgeManager.Instance.RosConnector.isConneted != null)
            {
                if (tbtnRunGraph.Checked)
                {
                    sw.Start();
                    timerUpdateData.Enabled = true;
                    timerRender.Enabled = true;
                    timerRenderLabel.Enabled = true;
                    //Debug.WriteLine("체크됨");
                }
                else
                {
                    sw.Stop();
                    timerRender.Enabled = false;
                    timerUpdateData.Enabled = false;
                    timerRenderLabel.Enabled = false;
                    //Debug.WriteLine("체크해제됨");
                }
            }
            else
            {
                MessageBox.Show("ROS가 연결되어 있지 않습니다.", "연결 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbtnRunGraph.CheckedChanged -= tbtnRunGraph_CheckedChanged;
                tbtnRunGraph.Checked = !tbtnRunGraph.Checked;
                tbtnRunGraph.CheckedChanged += tbtnRunGraph_CheckedChanged;
            }
        }

        private void PanelResize(object sender, EventArgs e)
        {
            AdjustPanelSizes();
        }

        private void AdjustPanelSizes()
        {
            int xlableHeight = 10;
            int panelWidth = this.panelMainGraph.Width;
            int panelHeight = (this.panelMainGraph.Height - xlableHeight) / 4;

            panelMRVeloGraph.Size = new Size(panelWidth, panelHeight);
            panelLeftImuGraph.Size = new Size(panelWidth, panelHeight);
            panelMidImuGraph.Size = new Size(panelWidth, panelHeight);
            panelRightImuGraph.Size = new Size(panelWidth, panelHeight + xlableHeight);
            //Debug.WriteLine("Size" + this.panelMainGraph.Size);
        }

        private void LoadTheme()
        {
            lblAngularVelo.ForeColor = ThemeColor.SecondaryColor;
            lblLinearVelo.ForeColor = ThemeColor.PrimaryColor;
            lblLeftImuData.ForeColor = ThemeColor.SecondaryColor;
            lblMidImuData.ForeColor = ThemeColor.PrimaryColor;
            lblRightImuData.ForeColor = ThemeColor.SecondaryColor;
            
        }

        private void InitializePlot()
        {
            // Mobile Robot Velocity Data
            pltMobileRobotVelo.Plot.Style(ScottPlot.Style.Burgundy);
            pltMobileRobotVelo.Plot.Palette = ScottPlot.Palette.Frost;
            var pltLinerVelocity = pltMobileRobotVelo.Plot.AddSignal(linearVelocity);
            pltLinerVelocity.LineWidth = 1;
            var pltAngularVelocity = pltMobileRobotVelo.Plot.AddSignal(angularVelocity);
            pltAngularVelocity.LineWidth = 1;
            pltMobileRobotVelo.Plot.AxisAutoX(margin: 0);
            pltMobileRobotVelo.Plot.SetAxisLimits(yMin: -5, yMax: 5);
            pltMobileRobotVelo.Plot.YLabel("m/s, rad/s");
            pltMobileRobotVelo.Plot.Grid(true);
            pltLinerVelocity.Label = "선속도";
            pltAngularVelocity.Label = "각속도";
            pltMobileRobotVelo.Plot.Legend(location: Alignment.UpperRight);

            // IMU data plot
            pltLeftImuData.Plot.Style(ScottPlot.Style.Burgundy); //Data style
            pltLeftImuData.Plot.Palette = ScottPlot.Palette.Frost;
            var pltLeftImu_x = pltLeftImuData.Plot.AddSignal(leftImu_x);
            pltLeftImu_x.LineWidth = 1;
            var pltLeftImu_y = pltLeftImuData.Plot.AddSignal(leftImu_y);
            pltLeftImu_y.LineWidth = 1;
            var pltLeftImu_z = pltLeftImuData.Plot.AddSignal(leftImu_z);
            pltLeftImu_z.LineWidth = 1;
            pltLeftImuData.Plot.AxisAutoX(margin: 0);
            pltLeftImuData.Plot.SetAxisLimits(yMin: -5, yMax: 5);
            pltLeftImuData.Plot.YLabel("deg");
            pltLeftImuData.Plot.Grid(true);
            pltLeftImu_x.Label = "Roll";
            pltLeftImu_y.Label = "Pitch";
            pltLeftImu_z.Label = "Yaw";
            pltLeftImuData.Plot.Legend(location: Alignment.UpperRight);
            pltLeftImu_x.LineStyle = LineStyle.Solid;
            pltLeftImu_y.LineStyle = LineStyle.Solid;
            pltLeftImu_z.LineStyle = LineStyle.Solid;

            pltMidImuData.Plot.Style(ScottPlot.Style.Burgundy);
            pltMidImuData.Plot.Palette = ScottPlot.Palette.Frost;
            var pltMidImu_x = pltMidImuData.Plot.AddSignal(midImu_x);
            pltMidImu_x.LineWidth = 1;
            var pltMidImu_y = pltMidImuData.Plot.AddSignal(midImu_y);
            pltMidImu_y.LineWidth = 1;
            var pltMidImu_z = pltMidImuData.Plot.AddSignal(midImu_z);
            pltMidImu_z.LineWidth = 1;
            pltMidImuData.Plot.AxisAutoX(margin: 0);
            pltMidImuData.Plot.SetAxisLimits(yMin: -5, yMax: 5);
            pltMidImuData.Plot.YLabel("deg");
            pltMidImuData.Plot.Grid(true);
            pltMidImu_x.Label = "Roll";
            pltMidImu_y.Label = "Pitch";
            pltMidImu_z.Label = "Yaw";
            pltMidImuData.Plot.Legend(location: Alignment.UpperRight);
            pltMidImu_x.LineStyle = LineStyle.Solid;
            pltMidImu_y.LineStyle = LineStyle.Solid;
            pltMidImu_z.LineStyle = LineStyle.Solid;

            pltRightImuData.Plot.Style(ScottPlot.Style.Burgundy);
            pltRightImuData.Plot.Palette = ScottPlot.Palette.Frost;
            var pltRightImu_x = pltRightImuData.Plot.AddSignal(rightImu_x);
            pltRightImu_x.LineWidth = 1;
            var pltRightImu_y = pltRightImuData.Plot.AddSignal(rightImu_y);
            pltRightImu_y.LineWidth = 1;
            var pltRightImu_z = pltRightImuData.Plot.AddSignal(rightImu_z);
            pltRightImu_z.LineWidth = 1;
            pltRightImuData.Plot.AxisAutoX(margin: 0);
            pltRightImuData.Plot.SetAxisLimits(yMin: -5, yMax: 5);
            pltRightImuData.Plot.YLabel("deg");
            pltRightImuData.Plot.Grid(true);
            pltRightImu_x.Label = "Roll";
            pltRightImu_y.Label = "Pitch";
            pltRightImu_z.Label = "Yaw";
            pltRightImuData.Plot.Legend(location: Alignment.UpperRight);
            pltRightImu_x.LineStyle = LineStyle.Solid;
            pltRightImu_y.LineStyle = LineStyle.Solid;
            pltRightImu_z.LineStyle = LineStyle.Solid;
            pltRightImuData.Plot.XLabel("Time(sec)");

            pltMobileRobotVelo.Refresh();
            pltMidImuData.Refresh();
            pltLeftImuData.Refresh();
            pltRightImuData.Refresh();
        }
    }
}
