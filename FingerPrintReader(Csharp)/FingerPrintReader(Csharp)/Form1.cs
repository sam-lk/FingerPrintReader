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

            visibleHideAll();
            usersUC1.Visible = true;
            usersUC1.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void btnFingerPrint_Click(object sender, EventArgs e)
        {
            visibleHideAll();
            fingerPrintViewerUC1.Visible = true;
            fingerPrintViewerUC1.Dock = DockStyle.Fill;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            visibleHideAll();
            usersUC1.Visible = true;
            usersUC1.Dock = DockStyle.Fill;
        }

        private void btnAttandance_Click(object sender, EventArgs e)
        {
            visibleHideAll();
            attendanceUC1.Visible = true;
            attendanceUC1.Dock = DockStyle.Fill;
        }

        private void visibleHideAll()
        {
            fingerPrintViewerUC1.Visible = false;
            usersUC1.Visible = false;
            attendanceUC1.Visible = false;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            visibleHideAll();
        }

    }
}
