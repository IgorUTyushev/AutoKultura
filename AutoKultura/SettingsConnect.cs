using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalysisOfTheFaceComparisonAlgorithm
{
    public partial class SettingsConnect : Form
    {
        readonly string nameStringConnection = "";
        public SettingsConnect(string nameStringConnection = "ConnectionDB")
        {
            InitializeComponent();
            this.nameStringConnection = nameStringConnection;
            SqlConnectionStringBuilder connect = GetSQLConnectionByName(nameStringConnection);
            txbUserID.Text = connect.UserID;
            txbServer.Text = connect.DataSource;
            txbPassword.Text = connect.Password;
            txbInitialCatalog.Text = connect.InitialCatalog;

        }
        public static bool CheckedConnectionSQLServer(string connectionString)
        {
            try
            {
                using SqlConnection connect = new (connectionString);
                
                    connect.Open();
                
                return true;
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка подключения!"); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Другая ошибка!"); }

            return false;
        }

        /// <summary>
        /// Получение объекта SqlConnectionStringBuilder по названию строки подключения
        /// </summary>
        /// <param name="name">Название строки подключения</param>
        /// <returns></returns>
        private static SqlConnectionStringBuilder GetSQLConnectionByName(string name)
        {
            string returnValue = string.Empty;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return new SqlConnectionStringBuilder(returnValue);
        }

        //private static string GetPathToConnectionConfig()
        //{
        //   string[] path = Application.ExecutablePath.Split('\\');
        //    string resault = "";
        //   for (int i = 0; i < path.Length - 1; i++)
        //    {
        //        resault += path[i] + "\\";
        //    }
        //    resault += "connections.config";
        //   return resault;
        //}

        /// <summary>
        /// Сохранение строки подключения
        /// </summary>
        /// <param name="stringConnection">Строка подключения</param>
        private void SaveStingConnection(string stringConnection)
        {
            if (!CheckedConnectionSQLServerLocal(stringConnection)) return;

            try
            {
                // Get the application configuration file.
                System.Configuration.Configuration config =
                        ConfigurationManager.OpenExeConfiguration(
                        ConfigurationUserLevel.None);

                // Get the connection strings section.
                ConnectionStringsSection csSection =
                    config.ConnectionStrings;

                csSection.ConnectionStrings.Remove(nameStringConnection);
                // Add the new element.
                csSection.ConnectionStrings.Add(new ConnectionStringSettings(nameStringConnection, stringConnection));

                // Save the configuration file.
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Настройки сохранены", "Успешно!");
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка файла конфигурации!"); }
           
                
            
        }     

        /// <summary>
        /// Проверка подключения
        /// </summary>
        /// <param name="connectionString"> строка подключения</param>
        /// <returns></returns>
        private static bool CheckedConnectionSQLServerLocal(string connectionString)
        {
            try
            {
                using SqlConnection connect = new(connectionString);
                
                    connect.Open();
                
                return true;
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка подключения!"); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Другая ошибка!"); }

            return false;
        }

        private void SettingsConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.Yes) this.DialogResult = DialogResult.No;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder newStringConnect = new()
            {
                Password = txbPassword.Text,
                UserID = txbUserID.Text,
                InitialCatalog = txbInitialCatalog.Text,
                DataSource = txbServer.Text,
                Encrypt = false,
                IntegratedSecurity = true
            };

            SaveStingConnection(newStringConnect.ConnectionString);

        }
    }
}
