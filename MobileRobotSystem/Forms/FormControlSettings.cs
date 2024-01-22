using MoblieRobotSystem.Utilities.CostumUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoblieRobotSystem.Forms
{
    public partial class FormControlSettings : Form
    {
        public FormControlSettings()
        {
            InitializeComponent();
        }

        private void FormControlSettings_Load(object sender, EventArgs e)
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
            lblPgainSetting.ForeColor = ThemeColor.SecondaryColor;
            lblIgainSetting.ForeColor = ThemeColor.PrimaryColor;
            lblDgainSetting.ForeColor = ThemeColor.SecondaryColor;
            lblCurrentPgain.ForeColor = ThemeColor.PrimaryColor;
            lblCurrentIgain.ForeColor = ThemeColor.SecondaryColor;
            lblCurrentDgain.ForeColor = ThemeColor.PrimaryColor;

        }
    }
}
