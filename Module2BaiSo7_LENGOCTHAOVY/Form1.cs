using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Module2BaiSo7_LENGOCTHAOVY
{
    public partial class Form1 : Form
    {
        private bool isLightOn = true;
        public Form1()
        {
            InitializeComponent();
            toolTip.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
            toolTip.SetToolTip(picTurnOff, "Click me to Turn ON the Light!");
            lblDesignedBy.Text = "Designed by: [NGOCTHAOVYLE]";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hiển thị hình bóng đèn sáng ban đầu
            picTurnOn.Visible = true;
            picTurnOff.Visible = false;

            // Focus vào textbox Name
            txtName.Focus();

            UpdateMessage();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateMessage();

        }
        private void UpdateMessage()
        {
            string name = string.IsNullOrEmpty(txtName.Text) ? "Jack" : txtName.Text;
            lblMessage.Text = $"{name}: Turn {(isLightOn ? "OFF" : "ON")} the Light, please!";
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            // Chuyển sang trạng thái tắt đèn
            isLightOn = false;
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;
            UpdateMessage();
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            // Chuyển sang trạng thái bật đèn
            isLightOn = true;
            picTurnOn.Visible = true;
            picTurnOff.Visible = false;
            UpdateMessage();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
