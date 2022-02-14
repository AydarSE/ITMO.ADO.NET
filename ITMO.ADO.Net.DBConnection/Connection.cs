using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace ITMO.ADO.Net.DBConnection
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            connection.StateChange += new StateChangeEventHandler(connection_StateChange);
        }
        SqlConnection connection = new SqlConnection();
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null; ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");
       
        private void подключитьсяКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open) 
                { 
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                        connection.Database + "выполнено успешно" + "\nСервер:" +
                        connection.DataSource); 
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                }
            }
            catch
            { 
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }
        private void отключитьсяОтБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close(); MessageBox.Show("Соединение с базой данных закрыто");
            }
            else MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private async void асинхронноеПодключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с базой данных " +
                    connection.Database + " выполнено успешно " + "\nСервер: " +
                    connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }
        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            подключитьсяКБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            асинхронноеПодключениеКБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            отключитьсяОтБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0}\nProviderName = {1}\nConnectionString = {2}", cs.Name, cs.ProviderName, cs.ConnectionString); MessageBox.Show(str, "Параметры подключений");
                }
            }
        }
    }
}
