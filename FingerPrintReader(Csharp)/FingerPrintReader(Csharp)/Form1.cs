using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrintReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void btnFingerPrint_Click(object sender, EventArgs e)
        {
            usersUC1.Visible = false;
            fingerPrintViewerUC1.Visible = true;
            fingerPrintViewerUC1.Dock = DockStyle.Fill;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            fingerPrintViewerUC1.Visible = false;
            usersUC1.Visible = true;
            usersUC1.Dock = DockStyle.Fill;
        }

        //private void panel1_VisibleChanged(object sender, EventArgs e)
        //{
        //    Console.WriteLine("hyy");
        //    if (panel1.Visible == true)
        //    {
        //        Console.WriteLine("visible");
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (panel1.Visible == true)
        //    {
        //        panel1.Visible = false;
        //    }
        //    else
        //    {
        //        panel1.Visible = true;
        //    }
        //}
    }
}
