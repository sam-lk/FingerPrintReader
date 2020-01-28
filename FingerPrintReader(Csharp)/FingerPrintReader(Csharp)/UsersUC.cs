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
    public partial class UsersUC : UserControl
    {
        public UsersUC()
        {
            InitializeComponent();
        }

        private void tabUserList_Click(object sender, EventArgs e)
        {
            if(tabUserList.SelectedIndex == 0)
            {
                Console.WriteLine("VIew Load");
            }
            else if (tabUserList.SelectedIndex == 1)
            {
                Console.WriteLine("AddNew Load");
            }
        }

        private void UsersUC_VisibleChanged(object sender, EventArgs e)
        {
            
            if(this.Visible == true)
            {
                tabUserList.Dock = DockStyle.Fill;
                Console.WriteLine("UserUI Visible change..");
            }
            
        }
    }
}
