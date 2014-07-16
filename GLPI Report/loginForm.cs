using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SettingsClass;

namespace GLPI_Report
{
    public partial class loginForm : Form
    {
        private MySqlConnection myConnection;
        private string Connect;
        private MSettingsClass settingsClass;

        public loginForm()
        {
            InitializeComponent();
            settingsClass = new MSettingsClass();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Authorization();
        }

        //Основня функция авторизации в программе
        private void Authorization()
        {
            Connect = "Database=glpi;Data Source=" + hostTextBox.Text + ";User Id=" + loginTextBox.Text +
                      ";Password=" + passwordTextBox.Text + ";charset=utf8;";

            myConnection = new MySqlConnection(Connect);

            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к серверу БД");
                return;
            }
            finally
            {
                myConnection.Close();
            }

            mainForm mForm = new mainForm();

            mForm.Show(this);
            mForm.setConnString(Connect);

            //Таймер скрывает форму
            timer1.Enabled = true;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            //Заргужаю существующие настройки и настраиваю форму в соответствии с ними
            try
            {
                settingsClass.LoadSettings();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить настройки");
                settingsClass.Host = "10.164.30.34";
                //Здесь устанавливаю настройки по умолчанию, а нужно дать возможность их указать вручную
            }

            //Выставляю логин и пароль из настроек, если они указаны
            if (settingsClass.Login.Length > 0)
                loginTextBox.Text = settingsClass.Login;

            if (settingsClass.Password.Length > 0)
                passwordTextBox.Text = settingsClass.Password;

            if (settingsClass.Host.Length > 0)
                hostTextBox.Text = settingsClass.Host;

            if (settingsClass.AutoEnter == "True")            
                Authorization();            
        }

        //Скрываю основную форму, потому что она не закрывается при использовании автовхода
        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            timer1.Enabled = false;
        }        
    }
}
