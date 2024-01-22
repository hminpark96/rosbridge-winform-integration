using MoblieRobotSystem.Utilities.CostumUI;
using MoblieRobotSystem.Utilities.RosCommunication;
using System.Diagnostics;

namespace MoblieRobotSystem.Forms
{
    public partial class FormROSSettings : Form
    {
        //Field


        //Constructor
        public FormROSSettings()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FormROSSetting_Closing);
            tbxRosBridgeServerUrl.Text = RosbridgeManager.Instance.RosConnector.RosBridgeServerUrl;

        }

        //Methods
        private void FormROSSetting_Closing(object sender, FormClosingEventArgs e)
        {
            //RosConnector.Instance?.Disconnect();
        }

        private void FormROSSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
            lblROSConnection.ForeColor = ThemeColor.SecondaryColor;
        }


        private void btnRosConnect_Click(object sender, EventArgs e)
        {
            RosbridgeManager.Instance.RosConnector.RosBridgeServerUrl = tbxRosBridgeServerUrl.Text;
            RosbridgeManager.Instance.RosConnect();
        }

        private void btnRosDisconnect_Click(object sender, EventArgs e)
        {
            RosbridgeManager.Instance.TwistSubscriberStop();
            RosbridgeManager.Instance.Float32MultiArraySubscriber1Stop();
            RosbridgeManager.Instance.Float32MultiArraySubscriber2Stop();
            RosbridgeManager.Instance.Float32MultiArraySubscriber3Stop();
            RosbridgeManager.Instance.RosDisconnect();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (!RosbridgeManager.Instance.TwistSubscriber.isSubscribe)
            {
                RosbridgeManager.Instance.TwistSubscriberStart();
            }
            else RosbridgeManager.Instance.TwistSubscriberStop();

            if (!RosbridgeManager.Instance.Float32MultiArraySubscriber1.isSubscribe)
            {
                RosbridgeManager.Instance.Float32MultiArraySubscriber1Start();
            }
            else RosbridgeManager.Instance.Float32MultiArraySubscriber1Stop();

            if (!RosbridgeManager.Instance.Float32MultiArraySubscriber2.isSubscribe)
            {
                RosbridgeManager.Instance.Float32MultiArraySubscriber2Start();
            }
            else RosbridgeManager.Instance.Float32MultiArraySubscriber2Stop();

            if (!RosbridgeManager.Instance.Float32MultiArraySubscriber3.isSubscribe)
            {
                RosbridgeManager.Instance.Float32MultiArraySubscriber3Start();
            }
            else RosbridgeManager.Instance.Float32MultiArraySubscriber3Stop();

        }
    }
}
