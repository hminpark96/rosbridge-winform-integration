using System.Diagnostics;
using System.Runtime.InteropServices;
using MoblieRobotSystem.Utilities.CostumUI;


namespace MoblieRobotSystem
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;
        //private int borderSize = 1;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            //this.Padding = new Padding(borderSize);//Border size
            //this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            //random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Resize += new EventHandler(ChildFormResize);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Methods
        private void ChildFormResize(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Size = this.panelDesktop.Size; // 부모 폼의 클라이언트 영역 크기에 맞춤
            }
            //Debug.WriteLine("창 사이즈 조절!");
        }
        private Color SelectThemeColor()
        {
            //int index = random.Next(ThemeColor.ColorList.Count);
            //while (tempIndex == index)
            //{
            //    index = random.Next(ThemeColor.ColorList.Count);
            //}
            //tempIndex = index;
            int index = 18;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("맑은 고딕", 11.5F);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Gray;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("맑은 고딕", 10F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            activeForm.Size = this.panelDesktop.Size;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnRobotStatus_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("로봇 상태창" + this.panelDesktop.Size);
            OpenChildForm(new Forms.FormRobotStatus(), sender);

        }
        private void btnControlSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormControlSettings(), sender);
            //Debug.WriteLine("제어기 설정창");
        }
        private void btnROSSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormROSSettings(), sender);
            //Debug.WriteLine("ROS 설정창");
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.Silver;
            panelLogo.BackColor = Color.DimGray;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
