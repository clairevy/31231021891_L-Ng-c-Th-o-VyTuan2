using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo9_LENGOCTHAOVY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Add a link for Calculator in the first half of LinkLabel 
            lnkPrograms.Links.Add(0, "Launch Calculator".Length, "calc.exe ");
            //Add a link for C: Drive in 
            //the second half of LinkLabel 
            lnkPrograms.Links.Add(lnkPrograms.Text.IndexOf(
            "Open C: Drive"), "Open D: Drive".Length, "c:\\");
            //Autosize the control based on its contents 
            lnkPrograms.AutoSize = true;
        }

        private void lnkWinForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWinForms.LinkVisited = true;

            //Go to Windows Forms Community Website
            System.Diagnostics.Process.Start("FireFox", "http://www.windowsforms.net");
        }

        private void lnkPrograms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Launch the program stored in the hyperlink
            System.Diagnostics.Process.Start(
            e.Link.LinkData.ToString());
        }
    }
}
