﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo2_LENGOCTHAOVY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void frmBaiTap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Ex1",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctrl, "Please enter your name.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && !Char.IsDigit(ctrl.Text[ctrl.Text.Length - 1]))
                this.errorProvider1.SetError(ctrl, "This is not a valid number.");
            else
            {
                this.errorProvider1.Clear();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text
            txtYourName.Clear();
            txtYear.Clear();
            // TextBox Your Name reset focus
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My Name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text); // Current Year - Enter year
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);

        }
    }
}
