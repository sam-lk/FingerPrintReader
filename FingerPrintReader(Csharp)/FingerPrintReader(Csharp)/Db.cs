using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FingerPrintReader
{
    public static class Db
    {
        static string dbPath = "Server=localhost;Port=3306;Database=testpayroll;Uid=root;Pwd=;";
        static string readMeText = string.Empty;
        //static string myQuery = string.Empty;
        static bool myresult = false;
        public static string errormsg = string.Empty;
        public static MySqlConnection Con, Con2;
        static string exeDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public static void ReadTextQuery()
        {
            string exePath = "code location path";
            //readMeText = File.ReadAllText(exePath + "\\DbConnection.txt");
            readMeText = File.ReadAllText(exePath + "\\tuskerdb.config");

            dbPath = readMeText + @"password=svi4kkCM3olF8yRO;";
            //Console.WriteLine(Db.dbPath);

        }

        public static void Connection_CreateAndOpen()
        {
            Con = new MySqlConnection(dbPath); // create connection with query..
            Con.Open();
            Con2 = new MySqlConnection(dbPath); // create connection with query..
            Con2.Open();
            Console.WriteLine("Db connection open");
        }

        public static void Connection_Close()
        {
            Con = new MySqlConnection(dbPath); // create connection with query..
            Con.Open();
        }

        public static MySqlDataAdapter SearchData_Via_DataAdapter(string QuaryInput)
        {

            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            MySqlCommand myComand = new MySqlCommand(QuaryInput, Con);
            myAdapter.SelectCommand = myComand;

            DataSet myDs = new DataSet();
            myDs.Clear();
            myAdapter.Fill(myDs);

            return myAdapter; //retrun mysql data adpter
        }

        public static MySqlDataReader SearchData_Via_DataReader(string QuaryInput)
        {
            MySqlCommand mycmmd = new MySqlCommand(QuaryInput, Con);
            MySqlDataReader myreader = mycmmd.ExecuteReader();
            return myreader; //retrun mysql data reader
        }

        public static bool DeleteData(string QuaryInput)
        {
            myresult = false;
            try
            {
                using (MySqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = QuaryInput;
                    cmd.ExecuteNonQuery();
                    myresult = true;
                }
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                Console.WriteLine("db class- DeleteData-  " + errormsg);
            }
            return myresult; //retrun bool value
        }

        public static bool InsertData(string quary)
        {
            myresult = false;
            try
            {
                using (MySqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = quary;
                    cmd.ExecuteNonQuery();
                    myresult = true;
                }
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                Console.WriteLine("db class- InsertData-  " + errormsg);
            }
            return myresult;
        }

        public static bool InsertData2(string quary)
        {
            myresult = false;
            try
            {
                using (MySqlCommand cmd = Con2.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = quary;
                    cmd.ExecuteNonQuery();
                    myresult = true;
                }
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                Console.WriteLine("db class- InsertData-  " + errormsg);
            }
            return myresult;
        }

        public static void UpdateData(string myquery) //----------------------------------
        {
            try
            {
                using (MySqlCommand cmd = Con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = myquery;
                    cmd.ExecuteNonQuery();
                    //scopeID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                Console.WriteLine("db class- UpdateData-  " + errormsg);
            }
        }
    }
}
