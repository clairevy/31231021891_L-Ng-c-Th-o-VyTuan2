using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo4_LENGOCTHAOVY
{
    public partial class Form1 : Form
    {
        private const double USD_RATE = 17861;
        private const double EUR_RATE = 27043;
        public Form1()
        {

            InitializeComponent();
            MessageBox.Show($"Buttons initialized: {btnVNDtoUSD != null}, {btnVNDtoEUR != null}, {btnUSDtoVND != null}, {btnEURtoVND != null}");

        }



        private bool ValidateInput(out double amount)
        {
            if (double.TryParse(txtTienQuiDoi.Text, out amount) && amount > 0)
            {
                errorProvider.Clear();
                return true;
            }
            else
            {
                errorProvider.SetError(txtTienQuiDoi, "Vui lòng nhập số hợp lệ!");
                return false;
            }
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out double amount))
            {
                txtKetQua.Text = Math.Round(amount / USD_RATE, 2).ToString();
            }
        }
        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out double amount))
            {
                txtKetQua.Text = Math.Round(amount / EUR_RATE, 2).ToString();
            }
        }
        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out double amount))
            {
                txtKetQua.Text = Math.Round(amount * USD_RATE, 2).ToString();
            }
        }
        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out double amount))
            {
                txtKetQua.Text = Math.Round(amount * EUR_RATE, 2).ToString();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
