using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo3_LENGOCTHAOVY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện phím Enter và Esc
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            lblHoTen.DoubleClick += (s, e) => lblHoTen.Text = "";
        }
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHoTen.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Close();

        }
    }
}
