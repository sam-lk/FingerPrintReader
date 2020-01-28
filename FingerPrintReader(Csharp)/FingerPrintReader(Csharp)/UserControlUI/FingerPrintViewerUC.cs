using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FingerPrintReader
{
    public partial class FingerPrintViewerUC : UserControl
    {
        public FingerPrintViewerUC()
        {
            InitializeComponent();
        }

        static string exeDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        static string textFile = exeDir + "\\AT_LOG.txt";

        private void btnReadData_Click(object sender, EventArgs e)
        {
            Db.Connection_CreateAndOpen();
            string TodayDate = DateTime.Now.ToString("yyyy-MM-dd");
            string TodayTime = DateTime.Now.ToString("HH:mm:tt");
            Console.WriteLine(TodayDate); Console.WriteLine(TodayTime);
            //Db.DeleteData("Delete from temp_data");

            using (StreamReader file = new StreamReader(textFile))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    string[] lines = ln.Split(';');
                    string[] datetime = lines[3].Split(' ');
                    //Console.WriteLine("Count: " + lines[0] + "\tEmpID: " + lines[1] + "\tCode: " + lines[2]+ "\tDate: " + datetime[0] + "\tTime: " + datetime[1]);
                    //DateTime oDate = DateTime.ParseExact(lines[3], "yyyy-M-dd HH:mm:tt", null);
                    DateTime oDate = Convert.ToDateTime(lines[3]);

                    //Db.InsertData("Insert Into temp_data (line_number, emp_id, in_out_code, t_date, t_time, t_datetime) " +
                    //    "Values ('"+ lines[0] + "', '"+ lines[1] + "', '"+ lines[2] + "', '"+ datetime[0] + "', '"+ datetime[1] + "', '"+ oDate.ToString("yyyy-MM-dd HH:mm:tt") + "') ");

                    if (Convert.ToInt32(lines[2]) == 100) //check-in
                    {
                        using (var myReader = Db.SearchData_Via_DataReader("Select status From attendance Where emp_id = '" + Convert.ToInt32(lines[1]) + "' AND att_date = '" + oDate.ToString("yyyy-MM-dd") + "'  "))
                        {
                            if (myReader.HasRows)
                            {
                                Console.WriteLine("Yes Row Have");
                                //while(myReader.Read())
                                //{

                                //}
                            }
                            else
                            {
                                //insert data 'attendance' table 
                                Db.InsertData2("Insert Into attendance (emp_id, att_date, in_time, out_time, outNextDay, status) " +
                                   "Values ('" + Convert.ToInt32(lines[1]) + "', '" + oDate.ToString("yyyy-MM-dd") + "', '" + oDate.ToString("HH:mm:tt") + "', '', '', 'CheckIn') ");
                            }
                        }
                        //insert data 'check_inout_data' table 
                        Db.InsertData2("Insert Into check_inout_data (emp_id, c_date, in_time, out_time, current_state) " +
                           "Values ('" + Convert.ToInt32(lines[1]) + "', '" + oDate.ToString("yyyy-MM-dd") + "', '" + oDate.ToString("HH:mm:tt") + "', '', 'CheckIn') ");
                    }

                    if (Convert.ToInt32(lines[2]) == 101) //check-out
                    {
                        //update 'attendance' table (check_out column)
                        Db.UpdateData("Update attendance SET out_time = '" + oDate.ToString("HH:mm:tt") + "', status = 'CheckOut' " +
                            "Where emp_id = '" + Convert.ToInt32(lines[1]) + "' AND att_date = '" + oDate.ToString("yyyy-MM-dd") + "' ");
                        //update 'check_inout_data' table (out_time column)
                        Db.UpdateData("Update check_inout_data SET out_time = '" + oDate.ToString("HH:mm:tt") + "', current_state = 'CheckOut' " +
                            "Where emp_id = '" + Convert.ToInt32(lines[1]) + "' AND c_date = '" + oDate.ToString("yyyy-MM-dd") + "' AND current_state = 'CheckIn' ");
                    }

                    if (Convert.ToInt32(lines[2]) == 130) //brake-in (get brake)
                    {
                        //insert data 'brake_inout_data' table 
                        Db.InsertData("Insert Into brake_inout_data (emp_id, b_date, in_time, out_time, current_state) " +
                            "Values ('" + Convert.ToInt32(lines[1]) + "', '" + oDate.ToString("yyyy-MM-dd") + "', '" + oDate.ToString("HH:mm:tt") + "', '', 'BrakeIn') ");
                    }

                    if (Convert.ToInt32(lines[2]) == 131) //brake-out (come back)
                    {
                        //update 'brake_inout_data' table (out_time column)
                        Db.UpdateData("Update brake_inout_data SET out_time = '" + oDate.ToString("HH:mm:tt") + "', current_state = 'BrakeOut' " +
                            "Where emp_id = '" + Convert.ToInt32(lines[1]) + "' AND b_date = '" + oDate.ToString("yyyy-MM-dd") + "' AND current_state = 'BrakeIn' ");
                    }

                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }



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
