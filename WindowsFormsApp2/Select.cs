using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Select
    {
        private string connStr;
        MySqlConnection connection;

        public Select(String serverName, String userName, String dbName, String port, String password)
        {
            connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            connection = new MySqlConnection(connStr);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Update statement
        public void Update(string id)
        {
            Form2 form = new Form2();
            List<bool> list = new List<bool>(form.getList());
            string set = "";
            for(int i = 0; i < 56; i++)
            {
                int index = i + 1;
                set += "seat_" + index + "='" + Convert.ToInt16(list[i]) +"', ";
            }
            set += "seat_" + 56 + "='" + Convert.ToInt16(list[55]) + " ";
            string query = "UPDATE race SET "+ set + "' WHERE id='" + id + "'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public List<string> SelectF(string id)
        {
            string query = "SELECT * FROM race Where id='" + id +"'";

            //Create a list to store the result
            List<string> list = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["id"].ToString());
                    list.Add(dataReader["destination"].ToString());
                    list.Add(dataReader["time"].ToString());
                    
                    
                }
                
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Insert statement
        public void Insert(String destination, String time, string vagon)
        {
            string query = "INSERT INTO race (destination, time, vagon) VALUES('" + destination + "', '" + time + "', '"+vagon+"')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public string SelectId(string name)
        {
            string id = "";
            string query = "SELECT * FROM race Where destination='" + name + "'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    id = dataReader["id"].ToString();
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return id;
            }
            return id;
        }
        public List<string> SelectD(string name)
        {
            List<string> vagon = new List<string>();
            string query = "SELECT * FROM race Where destination='" + name + "'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                vagon.Add("default");
                while (dataReader.Read())
                {
                    vagon.Add(dataReader["vagon"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return vagon;
            }
            return vagon;
        }
       
        public List<string> SelectV(string name, string vagon)
        {
            List<string> timeR = new List<string>();
            string query = "SELECT * FROM race Where destination='" + name + "' and vagon='" + vagon + "'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                timeR.Add("default");
                while (dataReader.Read())
                {
                    timeR.Add(dataReader["time"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return timeR;
            }
            return timeR;
        }
        public List<string> SelectR(string name, string vagon, string time)
        {
            List<string> race = new List<string>();
            string query = "SELECT * FROM race Where destination='" + name + "' and vagon='" + vagon + "' and time='" + time + "'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                race.Add("default");
                while (dataReader.Read())
                {
                    race.Add(dataReader["id"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return race;
            }
            return race;
        }

        public List<string>[] SelectA()
        {
            string query = "SELECT * FROM race";

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                list[1].Add("default");
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"].ToString());
                    list[1].Add(dataReader["destination"].ToString());
                    list[2].Add(dataReader["time"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string> SelectS(string id)
        {
            string query = "SELECT * FROM race Where id='" + id + "'";

            //Create a list to store the result
            List<string> list = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    for (int i = 1; i < 57; i++)
                    {
                        string seat = "seat_" + i;
                        list.Add(dataReader[seat].ToString());

                    }
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

    }
}
