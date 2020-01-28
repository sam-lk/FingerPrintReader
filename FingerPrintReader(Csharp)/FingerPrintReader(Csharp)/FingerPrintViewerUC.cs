using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrintReader
{
    public partial class FingerPrintViewerUC : UserControl
    {
        public FingerPrintViewerUC()
        {
            InitializeComponent();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void FingerPrintViewerUC_Load(object sender, EventArgs e)
        {
            Console.WriteLine("FingerPrintUILoaded");
        }

        private void FingerPrintViewerUC_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Console.WriteLine("FingerPrint Visible change..");
            }
        }
    }
}
