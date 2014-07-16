using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Web;
using SettingsForm;
using SettingsClass;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace GLPI_Report
{
    public partial class mainForm : Form
    {
        private String Connect;
        private Excel.Application objExcel;

        private MySqlConnection totalConnection;
        private MySqlConnection oTimeConnection;
        private MySqlConnection calcPercEffConnection;
        private MySqlConnection customTableConnection;

        private BindingSource bindingSourceTotal = new BindingSource();
        private BindingSource bindingSourceOTime = new BindingSource();
        private BindingSource bindingSourceCustom = new BindingSource();

        private string mainQuery = "";
        private string outOfTimeQuery = "";

        public MSettingsClass settingsClass;

        private FormWindowState oldFormState; //Состояние окна перед сворачиванием

        public mainForm()
        {
            InitializeComponent();
            settingsClass = new MSettingsClass();
        }

        public void setConnString(String Connect)
        {
            this.Connect = Connect;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeMainForm();
        }

        //Нужно корректно закрыть приложение
        private void closeMainForm()
        {
            //Если кнопка получения данных не была нажата, то и классы соединения не создавались 
            //(за исключением соединения для кастомных запросов)
            try
            {
                if (totalConnection.State == ConnectionState.Open)
                    totalConnection.Close();

                if (oTimeConnection.State == ConnectionState.Open)
                    oTimeConnection.Close();

                if (calcPercEffConnection.State == ConnectionState.Open)
                    calcPercEffConnection.Close();

                if (customTableConnection.State == ConnectionState.Open)
                    customTableConnection.Close();
            }
            catch { }

            
         
                loginForm lForm = (loginForm)Owner;
                lForm.Close();

                Application.Exit();
      
                        
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Скрываем вкладку вывода запросов из библиотеки и кастомных запросов
            tabControl.TabPages.Remove(customQuerytabPage);            

            //Устанавливаю первоначальные значения выпадающих списков статуса и приоритета
            statusComboBox.SelectedIndex = 5;
            priorityComboBox.SelectedIndex = 8;

            //По умолчанию смотреть статистику на наделю
            afterDateTimePicker.Value = DateTime.Now.AddDays(-7);
            beforeDateTimePicker.Value = DateTime.Now;

            //Применяю настройки
            try
            {
                ApplySettings();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить настройки приложения");
            }

            //Загружаю основные запросы из файлов
            loadMainQueries();

            //Подключаю библиотеку запросов
            loadQueryLibrary();            
        }

        private void loadMainQueries()
        {
            try
            {
                mainQuery = File.ReadAllText(".\\mainq\\main.sql");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл основного отчёта\r\n"+ex.Message);
                closeMainForm();
            }

            try
            {
                outOfTimeQuery = File.ReadAllText(".\\mainq\\outoftime.sql");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл отчёта по просроченным заявкам\r\n"+ex.Message);
                closeMainForm();
            }
        }

        //Процедура подключения запросов к библиотеке запросов главного меню
        private void loadQueryLibrary()
        {
            //Сначала вывожу папки (они будут являться категориями, то есть пунктами меню со вложенными подпунктами)
            string[] mFolders=null;            

            try
            {
                mFolders = Directory.GetDirectories(".\\qlib");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось загрузить библиотеку запросов\r\n"+ex.Message);
            }

            //Для библиотеки использую папки и подпапки для формирования запросов и их категорий
            ToolStripMenuItem item = menuStrip1.Items[2] as ToolStripMenuItem;
            string fileName = "";

            foreach (string folder in mFolders)
            {                
                ToolStripMenuItem subItem = new ToolStripMenuItem();
                subItem.Text = folder.Replace(".\\qlib\\", "");                
 
                //Здесь формирую подпункты
                string[] files = Directory.GetFiles(".\\qlib\\" + subItem.Text);

                foreach (string file in files)
                {
                    ToolStripMenuItem subItemFile = new ToolStripMenuItem();

                    fileName = file.Replace(".\\qlib\\" + subItem.Text + "\\","");
                    fileName = fileName.Replace(".sql", "");
                    subItemFile.Text = fileName;
                    subItemFile.Click += qLibClickCat;

                    subItem.DropDownItems.Add(subItemFile);
                }

                item.DropDownItems.Add(subItem); //Результирующий подпункт
            }
            
            //Вывожу файлы запросов из корневого каталога, те, что будут считаться без категории
            string[] mFiles = null;

            try
            {
                mFiles = Directory.GetFiles(".\\qlib");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить библиотеку запросов\r\n" + ex.Message);
            }

            //Если есть файлы, вывожу сепаратор, для удобства и отделения файлов без категории от пустых категорий
            if (mFiles.Length > 0)
                item.DropDownItems.Add(new ToolStripSeparator());

            foreach (string file in mFiles)
            {
                ToolStripMenuItem subItem = new ToolStripMenuItem();

                fileName = file.Replace(".\\qlib\\", "");
                subItem.Text = fileName.Replace(".sql", "");
                subItem.Click += qLibClickNoCat;

                item.DropDownItems.Add(subItem);
            }
        }

        //Для запросов с категорией нужно указывать родительскую папку
        private void qLibClickCat(object sender, EventArgs e)
        {
            customQuery(".\\qlib\\" + (sender as ToolStripMenuItem).OwnerItem.Text + "\\" +(sender as ToolStripMenuItem).Text + ".sql","");
        }

        //Запросы без категории вызываются из корневой папки библиотеки запросов
        private void qLibClickNoCat(object sender, EventArgs e)
        {
            customQuery(".\\qlib\\" + (sender as ToolStripMenuItem).Text + ".sql", "");
        }  
     
        //Вызываю функцию кастомного запроса из окна кастомного запроса
        public void callCustomQuery(string qString)
        {
            customQuery("", qString);
        }

        //Здесь выполняю запросы из библиотеки и из окна собственного запроса. Передаю или путь к файлу запроса, или сам запрос
        private void customQuery(string queryFile, string qString)
        {
            String commandText = "";

            //Чтение запроса или из файла, или через переданную строку запроса
            if (queryFile.Length > 0)
                commandText = File.ReadAllText(queryFile);
            else if (qString.Length > 0)
                commandText = qString;

            try
            {
                customTableConnection = new MySqlConnection(Connect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к БД\r\n"+ex.Message);
                return;
            }

            DataSet dataset = new DataSet();

           
            MySqlCommand myCommand = new MySqlCommand(commandText, customTableConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(myCommand);

            try
            {
                adapter.Fill(dataset);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось выполнить запрос\r\n"+ex.Message);
                return;
            }

            customTableConnection.Close();

            dataGridView3.AutoGenerateColumns = true;
            bindingSourceCustom.DataSource = dataset.Tables[0];
            dataGridView3.DataSource = bindingSourceCustom;            

            //Открываю скрытую вкладку
            if (tabControl.TabPages.Count == 2)           
                tabControl.TabPages.Add(customQuerytabPage);
                
            //Делаю вкладку кастомного запроса активной
            if(tabControl.SelectedIndex != 2)
                tabControl.SelectedIndex = 2;

            if (queryFile.Length > 0)
            {
                customQuerytabPage.Text = queryFile.Substring(queryFile.LastIndexOf("\\") + 1).Replace(".sql", "")+" ("+dataGridView3.RowCount+")";
            }
            else
                customQuerytabPage.Text = "Составленный запрос" + " (" + dataGridView3.RowCount + ")";
        }

        private void dAfterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            afterDateTimePicker.Enabled = !afterDateTimePicker.Enabled;
        }

        private void dBeforeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            beforeDateTimePicker.Enabled = !beforeDateTimePicker.Enabled;
        }

        private void statusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            statusComboBox.Enabled = !statusComboBox.Enabled;
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            priorityComboBox.Enabled = !priorityComboBox.Enabled;
        }

        //*************************************************************************Метод вывода основного отчёта
        private void mainReport()
        {
            string CommandText = mainQuery;

            String afterString = Convert.ToDateTime(afterDateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");           
            String beforeString = Convert.ToDateTime(beforeDateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");

            //Здесь добавляю критерии фильтрации
            if (afterDateTimePicker.Enabled && beforeDateTimePicker.Enabled)
            {
                CommandText += " AND gtk.date BETWEEN '" + afterString + "' AND ADDDATE('" + beforeString + "', INTERVAL 1 DAY) ";                               
            }
            else if (afterDateTimePicker.Enabled)
            {
                CommandText += " AND gtk.date > '" + afterString + "' ";
            }
            else if (beforeDateTimePicker.Enabled)
            {
                CommandText += " AND gtk.date < ADDDATE('" + beforeString + "', INTERVAL 1 DAY) ";
            }

            //Сортировка по статусу
            if (statusComboBox.Enabled)
            {
                switch (statusComboBox.SelectedIndex)
                {
                    case 0: CommandText += " AND gtk.status='new' ";
                        break;
                    case 1: CommandText += " AND gtk.status='assign' ";
                        break;
                    case 2: CommandText += " AND gtk.status='plan' ";
                        break;
                    case 3: CommandText += " AND gtk.status='waiting' ";
                        break;
                    case 4: CommandText += " AND gtk.status='solved' ";
                        break;
                    case 5: CommandText += " AND gtk.status='closed' ";
                        break;
                    case 6: CommandText += " AND gtk.status <> 'closed' ";
                        break;                    
                    case 7: CommandText += " AND gtk.status IN ('solved','closed') ";
                        break;
                    default: break;
                }
            }

            if (priorityComboBox.Enabled)
            {
                switch (priorityComboBox.SelectedIndex)
                {                    
                    case 0: CommandText += " AND gtk.priority>=5";
                        break;
                    case 1: CommandText += " AND gtk.priority>=4";
                        break;
                    case 2: CommandText += " AND gtk.priority>=3";
                        break;
                    case 3: CommandText += " AND gtk.priority>=2";
                        break;
                    case 4: CommandText += " AND gtk.priority>=1";
                        break;
                    case 5: CommandText += " AND gtk.priority=6";
                        break;
                    case 6: CommandText += " AND gtk.priority=5";
                        break;
                    case 7: CommandText += " AND gtk.priority=4";
                        break;
                    case 8: CommandText += " AND gtk.priority=3";
                        break;
                    case 9: CommandText += " AND gtk.priority=2";
                        break;
                    case 10: CommandText += " AND gtk.priority=1";
                        break;
                    default:  break;
                }
            }

            //Добавляю сортировку
            CommandText += " ORDER BY gtk.date DESC";

            //Подключение к БД
            totalConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, totalConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(myCommand);
            DataSet dataset = new DataSet();

            try
            {

                adapter.Fill(dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить запрос\r\n"+ex.Message);
                return;
            }

            totalConnection.Close();

            dataGridView1.AutoGenerateColumns = true;
            bindingSourceTotal.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSourceTotal;

            //Вывожу количество найденных строк в шапку вкладки
            mainTabPage.Text = "Основной отчёт отдела ("+dataGridView1.RowCount+")";    

            //Надо решать проблему с кодировкой БД, а не делать костыли
            dataGridView1.Columns[0].Visible = settingsClass.MainReport[0];
            

            //Статус буду скрывать в настройках по умолчанию;
            dataGridView1.Columns[1].Visible = settingsClass.MainReport[1];

            dataGridView1.Columns[2].Visible = settingsClass.MainReport[2];
            dataGridView1.Columns[2].Width = 150;

           
            dataGridView1.Columns[3].Visible = settingsClass.MainReport[3];
            dataGridView1.Columns[3].Width = 150;
          
            dataGridView1.Columns[4].Visible = settingsClass.MainReport[4];
            dataGridView1.Columns[4].Width = 150;
            
            dataGridView1.Columns[5].Visible = settingsClass.MainReport[5];
            dataGridView1.Columns[5].Width = 120;
            
            dataGridView1.Columns[6].Visible = settingsClass.MainReport[6];
            dataGridView1.Columns[6].Width = 80;
            
            dataGridView1.Columns[7].Visible = settingsClass.MainReport[7];
            dataGridView1.Columns[7].Width = 70;
            
            dataGridView1.Columns[8].Visible = settingsClass.MainReport[8];
            dataGridView1.Columns[8].Width = 80;
            
            dataGridView1.Columns[9].Visible = settingsClass.MainReport[9];
            dataGridView1.Columns[9].Width = 180;
            
            dataGridView1.Columns[10].Visible = settingsClass.MainReport[10];
            dataGridView1.Columns[10].Width = 80;
            
            dataGridView1.Columns[11].Visible = settingsClass.MainReport[11];
            dataGridView1.Columns[11].Width = 70;
            
            dataGridView1.Columns[12].Visible = settingsClass.MainReport[12];
            dataGridView1.Columns[12].Width = 100;
            
            dataGridView1.Columns[13].Visible = settingsClass.MainReport[13];
            dataGridView1.Columns[13].Width = 100;
           
            dataGridView1.Columns[14].Visible = settingsClass.MainReport[14];
            dataGridView1.Columns[14].Width = 80;
            
            dataGridView1.Columns[15].Visible = settingsClass.MainReport[15];
            dataGridView1.Columns[15].Width = 300;
            
            dataGridView1.Columns[16].Visible = settingsClass.MainReport[16];
            dataGridView1.Columns[16].Width = 0;
        }

        //*************************************************************************Метод вывода отчёта по просроченным заявкам
        private void outOfTimeReport()
        {
            string CommandText = outOfTimeQuery;

            String afterString = Convert.ToDateTime(afterDateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");
            String beforeString = Convert.ToDateTime(beforeDateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");

            //Здесь добавляю критерии фильтрации
            if (afterDateTimePicker.Enabled && beforeDateTimePicker.Enabled)
            {
                CommandText += " AND gtk.date BETWEEN '" + afterString + "' AND ADDDATE('" + beforeString + "', INTERVAL 1 DAY) ";        

            }
            else if (afterDateTimePicker.Enabled)
            {
                CommandText += " AND gtk.date > '" + afterString + "' ";
            }
            else if (beforeDateTimePicker.Enabled)
            {
                CommandText += " AND gtk.date < ADDDATE('" + beforeString + "', INTERVAL 1 DAY) ";
            }

            //Сортировка по статусу
            if (statusComboBox.Enabled)
            {
                switch (statusComboBox.SelectedIndex)
                {
                    case 0: CommandText += " AND gtk.status='new' ";
                        break;
                    case 1: CommandText += " AND gtk.status='assign' ";
                        break;
                    case 2: CommandText += " AND gtk.status='plan' ";
                        break;
                    case 3: CommandText += " AND gtk.status='waiting' ";
                        break;
                    case 4: CommandText += " AND gtk.status='solved' ";
                        break;
                    case 5: CommandText += " AND gtk.status='closed' ";
                        break;
                    case 6: CommandText += " AND gtk.status <> 'closed' ";
                        break;
                    case 7: CommandText += " AND gtk.status IN ('solved','closed') ";
                        break;
                    default: break;
                }
            }

            if (priorityComboBox.Enabled)
            {
                switch (priorityComboBox.SelectedIndex)
                {
                    case 0: CommandText += " AND gtk.priority>=5";
                        break;
                    case 1: CommandText += " AND gtk.priority>=4";
                        break;
                    case 2: CommandText += " AND gtk.priority>=3";
                        break;
                    case 3: CommandText += " AND gtk.priority>=2";
                        break;
                    case 4: CommandText += " AND gtk.priority>=1";
                        break;
                    case 5: CommandText += " AND gtk.priority=6";
                        break;
                    case 6: CommandText += " AND gtk.priority=5";
                        break;
                    case 7: CommandText += " AND gtk.priority=4";
                        break;
                    case 8: CommandText += " AND gtk.priority=3";
                        break;
                    case 9: CommandText += " AND gtk.priority=2";
                        break;
                    case 10: CommandText += " AND gtk.priority=1";
                        break;
                    default: break;
                }
            }

            //Добавляю сортировку
            CommandText += " ORDER BY gtk.date DESC";

           
            oTimeConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, oTimeConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(myCommand);
            DataSet dataset = new DataSet();

            try
            {
                adapter.Fill(dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить запрос\r\n"+ex.Message);
                return;
            }

            oTimeConnection.Close();            

            dataGridView2.AutoGenerateColumns = true;
            bindingSourceOTime.DataSource = dataset.Tables[0];
            dataGridView2.DataSource = bindingSourceOTime;

            oTimeTabPage.Text = "Отчёт по просроченным заявкам ("+dataGridView2.RowCount+")";

            //Надо решать проблему с кодировкой БД, а не делать костыли
            
            dataGridView2.Columns[0].Visible=settingsClass.OutOfTimeRep[0];
           
            dataGridView2.Columns[1].Visible = settingsClass.OutOfTimeRep[1];
            
            dataGridView2.Columns[2].Visible = settingsClass.OutOfTimeRep[2];
            
            dataGridView2.Columns[3].Visible = settingsClass.OutOfTimeRep[3];
            dataGridView2.Columns[3].Width = 150;
           
            dataGridView2.Columns[4].Visible = settingsClass.OutOfTimeRep[4];
            dataGridView2.Columns[4].Width = 150;
            
            dataGridView2.Columns[5].Visible = settingsClass.OutOfTimeRep[5];
            dataGridView2.Columns[5].Width = 150;
            
            dataGridView2.Columns[6].Visible = settingsClass.OutOfTimeRep[6];
            dataGridView2.Columns[6].Width = 120;
            
            dataGridView2.Columns[7].Visible = settingsClass.OutOfTimeRep[7];
            dataGridView2.Columns[7].Width = 80;
           
            dataGridView2.Columns[8].Visible = settingsClass.OutOfTimeRep[8];
            dataGridView2.Columns[8].Width = 70;
            
            dataGridView2.Columns[9].Visible = settingsClass.OutOfTimeRep[9];
            dataGridView2.Columns[9].Width = 80;
            
            dataGridView2.Columns[10].Visible = settingsClass.OutOfTimeRep[10];
            dataGridView2.Columns[10].Width = 180;
            
            dataGridView2.Columns[11].Visible = settingsClass.OutOfTimeRep[11];
            dataGridView2.Columns[11].Width = 80;
            
            dataGridView2.Columns[12].Visible = settingsClass.OutOfTimeRep[12];
            dataGridView2.Columns[12].Width = 70;
            
            dataGridView2.Columns[13].Visible = settingsClass.OutOfTimeRep[13];
            dataGridView2.Columns[13].Width = 100;
            
            dataGridView2.Columns[14].Visible = settingsClass.OutOfTimeRep[14];
            dataGridView2.Columns[14].Width = 100;
            
            dataGridView2.Columns[15].Visible = settingsClass.OutOfTimeRep[15];
            dataGridView2.Columns[15].Width = 80;
            
            dataGridView2.Columns[16].Visible = settingsClass.OutOfTimeRep[16];
            dataGridView2.Columns[16].Width = 300;
            
            dataGridView2.Columns[17].Visible = settingsClass.OutOfTimeRep[17];
            dataGridView2.Columns[17].Width = 0;

            dataGridView2.Columns[18].Visible = false;
        }

        //В зависимости от открытой вкладки выбираем, какой отчёт выводить
        private void queryButton_Click(object sender, EventArgs e)
        {
            descRichTextBox.Text = "Описание проблемы";
            solWebBrowser.DocumentText = "<html>Описание решения проблемы</html>";            

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    percLabel.Text = "";
                    mainReport();                    
                    break;
                case 1:
                    percLabel.Text = "";
                    outOfTimeReport();                                        
                    break;
                case 2:
                    percLabel.Text = "";
                    return;
            }

            //Эффективность расчитывается всегда, так видно, когда уже есть просроченные заявки
            calcPercEff();
        }

        //Назначение уважительной причины
        private void уважительнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Когда нет данных для обновления ничего не делать
            if (dataGridView2.SelectedRows.Count == 0)
                return;

            //TODO Доделать множественное назначение статуса
            if (dataGridView2.SelectedRows.Count > 1)
                return;
          
            MySqlConnection updConn = new MySqlConnection(Connect);
            updConn.Open();

            String id = dataGridView2.SelectedRows[0].Cells[dataGridView2.SelectedRows[0].Cells.Count-1].Value.ToString();

            MySqlCommand updCommand = new MySqlCommand("UPDATE glpi_outoftimereasons SET respect=1 AND new_tag=0 WHERE tickets_id=" + id, updConn);

            MySqlTransaction transaction = updConn.BeginTransaction();

            updCommand.Transaction = transaction;

            try
            {
                updCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Не удалось выполнить обновление БД\r\n" + ex.Message);
            }
            finally
            {
                transaction.Commit();
                dataGridView2.SelectedRows[0].Cells[0].Value = "Уважительная";
                updConn.Close();
            }

            //Обновляем показатель эффективности
            calcPercEff();
        }

        //Назначение неуважительной причины
        private void неУважительнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Когда нет данных для обновления ничего не делать
            if (dataGridView2.SelectedRows.Count == 0)
                return;

            //TODO Доделать множественное назначение статуса
            if (dataGridView2.SelectedRows.Count > 1)
                return;

            MySqlConnection updConn = new MySqlConnection(Connect);
            updConn.Open();

            String id = dataGridView2.SelectedRows[0].Cells[dataGridView2.SelectedRows[0].Cells.Count - 1].Value.ToString();

            MySqlCommand updCommand = new MySqlCommand("UPDATE glpi_outoftimereasons SET respect=0 AND new_tag=0 WHERE tickets_id=" + id, updConn);

            MySqlTransaction transaction = updConn.BeginTransaction();

            updCommand.Transaction = transaction;

            try
            {
                updCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Не удалось выполнить обновление БД\r\n" + ex.Message);
            }
            finally
            {
                transaction.Commit();
                dataGridView2.SelectedRows[0].Cells[0].Value = "Неуважительная";
                updConn.Close();
            }

            //Обновляем показатель эффективности
            calcPercEff();
        }

        //TODO Оптимизировать до универсального метода
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            descRichTextBox.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            solWebBrowser.DocumentText ="<html><head></head><body>"+ dataGridView1.SelectedRows[0].Cells[16].Value.ToString() +"</body></html>";
        }        

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            //Защита от случайных нажатий клавиш
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            descRichTextBox.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView1.SelectedRows[0].Cells[16].Value.ToString() + "</body></html>";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            descRichTextBox.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView1.SelectedRows[0].Cells[16].Value.ToString() + "</body></html>";
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ContextMenuStrip = contextMenuStrip1;

            if (dataGridView2.SelectedRows.Count == 0)
                return;

            descRichTextBox.Text = dataGridView2.SelectedRows[0].Cells[16].Value.ToString();
            solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView2.SelectedRows[0].Cells[17].Value.ToString() + "</body></html>";
        }

        private void dataGridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
                return;

            descRichTextBox.Text = dataGridView2.SelectedRows[0].Cells[16].Value.ToString();
            solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView2.SelectedRows[0].Cells[17].Value.ToString() + "</body></html>";
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                descRichTextBox.Text = dataGridView2.SelectedRows[0].Cells[16].Value.ToString();
                solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView2.SelectedRows[0].Cells[17].Value.ToString() + "</body></html>";
            }
        }

        //Описание проблемы и её решения должны меняться в зависимости от выбранной вкладки
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Убираю расчёт эффективности, чтобы не путаться, в какой вкладке он был расчитан
            percLabel.Text = "";

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        descRichTextBox.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                        solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView1.SelectedRows[0].Cells[16].Value.ToString() + "</body></html>";
                    }
                    else
                    {
                        descRichTextBox.Text = "";
                        solWebBrowser.DocumentText = "";   
                    }

                    break;
                case 1:
                    if (dataGridView2.SelectedRows.Count > 0)
                    {
                        descRichTextBox.Text = dataGridView2.SelectedRows[0].Cells[16].Value.ToString();
                        solWebBrowser.DocumentText = "<html><head></head><body>" + dataGridView2.SelectedRows[0].Cells[17].Value.ToString() + "</body></html>";
                    }
                    else
                    {
                        descRichTextBox.Text = "";
                        solWebBrowser.DocumentText = "";
                    }

                    break;
                case 2:                   
                    descRichTextBox.Text = "";
                    solWebBrowser.DocumentText = "";                      

                    break;
            }
        }

        private void calcPercEff()
        {
            String query = "";

            String afterString = Convert.ToDateTime(afterDateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");
            String beforeString = Convert.ToDateTime(beforeDateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");

            //Здесь добавляю критерии фильтрации
            if (afterDateTimePicker.Enabled && beforeDateTimePicker.Enabled)
            {
                query = "SELECT 100- "+
	                        "ROUND(("+		
		                        "(SELECT COUNT(*) FROM glpi_tickets gtk "+
		                        "WHERE gtk.due_date IS NOT NULL AND "+ 
			                          "gtk.closedate>gtk.due_date"+
                                      " AND gtk.date BETWEEN '" + afterString + "' AND ADDDATE('" + beforeString + "', INTERVAL 1 DAY) )-" +
		                        "(SELECT COUNT(*) FROM glpi_tickets gtk "+
			                        "INNER JOIN glpi_outoftimereasons otime ON(otime.tickets_id=gtk.id) "+
		                        "WHERE gtk.due_date IS NOT NULL AND "+
			                          "gtk.closedate>gtk.due_date AND "+
			                          "otime.respect=1 "+
                                      " AND gtk.date BETWEEN '" + afterString + "' AND ADDDATE('" + beforeString + "', INTERVAL 1 DAY)) "+
	                        ")/ "+
	                        "(SELECT COUNT(*) FROM glpi_tickets gtk "+
                                      " WHERE gtk.date BETWEEN '" + afterString + "' AND ADDDATE('" + beforeString + "', INTERVAL 1 DAY)) "+
                            "*100,2) AS Percent";
                
            }
            else if (afterDateTimePicker.Enabled)
            {
                query = "SELECT 100- " +
                            "ROUND((" +
                                "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                "WHERE gtk.due_date IS NOT NULL AND " +
                                      "gtk.closedate>gtk.due_date" +
                                      " AND gtk.date > '" + afterString + "')-" +
                                "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                    "INNER JOIN glpi_outoftimereasons otime ON(otime.tickets_id=gtk.id) " +
                                "WHERE gtk.due_date IS NOT NULL AND " +
                                      "gtk.closedate>gtk.due_date AND " +
                                      "otime.respect=1 " +
                                      " AND gtk.date > '" + afterString + "') " +
                            ")/ " +
                            "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                      " WHERE gtk.date > '" + afterString + "') " +
                            "*100,2) AS Percent";
            }
            else if (beforeDateTimePicker.Enabled)
            {
                query = "SELECT 100- " +
                            "ROUND((" +
                                "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                "WHERE gtk.due_date IS NOT NULL AND " +
                                      "gtk.closedate>gtk.due_date" +
                                      " AND gtk.date < ADDDATE('" + beforeString + "', INTERVAL 1 DAY))-" +
                                "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                    "INNER JOIN glpi_outoftimereasons otime ON(otime.tickets_id=gtk.id) " +
                                "WHERE gtk.due_date IS NOT NULL AND " +
                                      "gtk.closedate>gtk.due_date AND " +
                                      "otime.respect=1 " +
                                      " AND gtk.date < ADDDATE('" + beforeString + "', INTERVAL 1 DAY)) " +
                            ")/ " +
                            "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                      " WHERE gtk.date < ADDDATE('" + beforeString + "', INTERVAL 1 DAY)) " +
                            "*100,2) AS Percent";
            }
            else
            {
                query = "SELECT 100- " +
                            "ROUND((" +
                                "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                "WHERE gtk.due_date IS NOT NULL AND " +
                                      "gtk.closedate>gtk.due_date )-" +
                                "(SELECT COUNT(*) FROM glpi_tickets gtk " +
                                    "INNER JOIN glpi_outoftimereasons otime ON(otime.tickets_id=gtk.id) " +
                                "WHERE gtk.due_date IS NOT NULL AND " +
                                      "gtk.closedate>gtk.due_date AND " +
                                      "otime.respect=1) " +
                            ")/ " +
                            "(SELECT COUNT(*) FROM glpi_tickets gtk) " +
                            "*100,2) AS Percent";
            }

            calcPercEffConnection = new MySqlConnection(Connect);
            calcPercEffConnection.Open();

            MySqlCommand myCommand = new MySqlCommand(query, calcPercEffConnection);

            MySqlDataReader reader = myCommand.ExecuteReader();

            String perc = "";

            if (reader.Read())
            {
                perc=reader["Percent"].ToString();

                if (perc != "")
                {
                    percLabel.Text = "Эффективность: " + perc + "%";
                
                    //Раскрашиваем информацию об эффективности
                    if (Double.Parse(perc) > 95)
                        percLabel.ForeColor = Color.Green;
                    else if (Double.Parse(perc) > 90 && Double.Parse(perc) < 95)
                        percLabel.ForeColor = Color.Yellow;
                    else if (Double.Parse(perc) < 90)
                        percLabel.ForeColor = Color.Red;
                }
                else
                {
                    percLabel.ForeColor = Color.Black;
                }
            }

            calcPercEffConnection.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeMainForm();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Можно сделать отдельную форму для отчёта
            MessageBox.Show("              GLPI Report              \r\n              Бета-версия              ");
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int visibleCols = 0;
            int htmlCellIndex = 0;            

            DataGridView dgv = new DataGridView();            

            //Выгрузка производится по открытой вкладке. Таблица полей не должна быть пустой
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (dataGridView1.RowCount == 0)
                        return;
                    dgv = dataGridView1;
                    break;
                case 1:
                    if (dataGridView2.RowCount == 0)
                        return;
                    dgv = dataGridView2;
                    break;
                case 2:
                    if(dataGridView3.RowCount==0)
                        return;
                    dgv=dataGridView3;
                    break;
            }            

            //Открываю документ Excel'а
            objExcel = new Excel.Application();

            Excel.Workbook objWorkBook;
            Excel.Worksheet objWorkSheet;            

            try
            {
                objExcel.Visible = true;
                objExcel.UserControl = true;

                //Книга
                objWorkBook = objExcel.Workbooks.Add(Missing.Value);
                //Таблица
                objWorkSheet = (Excel.Worksheet)objWorkBook.Sheets[1];
                objWorkSheet.Name = tabControl.SelectedTab.Text.Substring(0,24)+"...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось создать файл Excel\r\n"+ex.Message);
                objExcel.Quit();
                return;
            }            

            //Заголовки таблицы
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    objWorkSheet.Cells[2, 2 + visibleCols] = dgv.Columns[i].HeaderText;
                    visibleCols++;
                }
            }           

            //В зависимости от названия столбца назначаю ему ширину
            for (int i = 2; i <= dgv.ColumnCount+1; i++)
            {
                String curCell=objWorkSheet.Cells[2, i].Value;

                switch (curCell)
                {
                    case "Причина пропуска срока":
                        objWorkSheet.Cells[2, i].ColumnWidth = 15;
                        break;
                    case "Приоритет":
                        objWorkSheet.Cells[2, i].ColumnWidth = 15;
                        break;
                    case "Статус заявки":
                        objWorkSheet.Cells[2, i].ColumnWidth = 17;
                        break;
                    case "Категория запроса":
                        objWorkSheet.Cells[2, i].ColumnWidth = 18;
                        break;
                    case "Филиал":
                        objWorkSheet.Cells[2, i].ColumnWidth = 20;
                        break;
                    case "Подразделение":
                        objWorkSheet.Cells[2, i].ColumnWidth = 22;
                        break;
                    case "Адрес":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Дата подачи запроса":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Время подачи запроса":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Передано исполнителю запроса":
                        objWorkSheet.Cells[2, i].ColumnWidth = 15;
                        break;
                    case "Кому назначено":
                        objWorkSheet.Cells[2, i].ColumnWidth = 30;
                        break;
                    case "Дата разрешения инцидента":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Время разрешения инцидента":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Реальное время устранения":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Плановое время устранения":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Плановое время SLA":
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                    case "Описание неисправности":
                        objWorkSheet.Cells[2, i].ColumnWidth = 40;
                        break;
                    case "Принятые меры, причина неисправности":
                        objWorkSheet.Cells[2, i].ColumnWidth = 40;

                        //Вычисляю индекс ячейки с HTML-форматированием. Соотношение сдвиг ячейки к индексу в массиве данных
                        htmlCellIndex = i-2;    
                        break;
                    default:
                        objWorkSheet.Cells[2, i].ColumnWidth = 25;
                        break;
                }
            }

            //Заполняю таблицу
            for (int i = 0; i < dgv.RowCount; i++)
            {
                int colPos = 0;

                for (int j = 0; j < dgv.ColumnCount; j++)
                    if (dgv.Columns[j].Visible)
                    {
                        if(colPos!=htmlCellIndex)
                            objWorkSheet.Cells[3 + i, 2 + colPos] = dgv[j, i].FormattedValue.ToString();
                        else
                            objWorkSheet.Cells[3 + i, 2 + colPos] = HttpUtility.HtmlDecode(dgv[j, i].FormattedValue.ToString());

                        colPos++;
                    }
            }

            //Форматирую таблицу. Начинаю с шапки
            Excel.Range headerRange = objWorkSheet.get_Range("2:2"); //+ dgv.ColumnCount + 2+":2");

            headerRange.Font.Bold = true;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.WrapText = true;
            headerRange.Orientation = 0;
            headerRange.AddIndent = false;
            headerRange.IndentLevel = 0;
            headerRange.ShrinkToFit = false;
            headerRange.ReadingOrder = -5002; //Excel.Constants.xlContext
            headerRange.MergeCells = false;

            //Вычерчиваю таблицу
            headerRange = objWorkSheet.get_Range("B2").CurrentRegion;

            headerRange.Borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle = Excel.Constants.xlNone;
            headerRange.Borders[Excel.XlBordersIndex.xlDiagonalUp].LineStyle = Excel.Constants.xlNone;

            headerRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].ColorIndex = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].TintAndShade = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;

            headerRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeTop].ColorIndex = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeTop].TintAndShade = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThin;

            headerRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].ColorIndex = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].TintAndShade = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThin;

            headerRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeRight].ColorIndex = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeRight].TintAndShade = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;

            headerRange.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Borders[Excel.XlBordersIndex.xlInsideVertical].ColorIndex = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlInsideVertical].TintAndShade = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = Excel.XlBorderWeight.xlThin;

            headerRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].ColorIndex = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].TintAndShade = 0;
            headerRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlThin;

            //Делаю форматирование строк в таблице            
            headerRange.HorizontalAlignment = Excel.Constants.xlCenter;
            headerRange.VerticalAlignment = Excel.Constants.xlCenter;
            headerRange.WrapText = true;
            headerRange.Orientation = 0;
            headerRange.AddIndent = false;
            headerRange.IndentLevel = 0;
            headerRange.ShrinkToFit = false;
            headerRange.ReadingOrder = -5002;
            headerRange.MergeCells = false;

            //Добавляю автофильтр. Здесь должно учитываться, что фильтруются только видимые поля            
            headerRange.AutoFilter(1);
        }

        private void основнойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryButton_Click(sender, e);
        }

        //TODO Привести
        private void деньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            afterDateTimePicker.Value = DateTime.Now;
            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }

        private void заВчерашнийДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            if (DateTime.Now.DayOfWeek.ToString() != "Monday")
            {
                afterDateTimePicker.Value = DateTime.Now.AddDays(-1);
                beforeDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
            else
            {
                afterDateTimePicker.Value = DateTime.Now.AddDays(-3);
                beforeDateTimePicker.Value = DateTime.Now.AddDays(-3);
            }

            queryButton_Click(sender, e);
        }        

        private void сНачалаНеделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            int decrement = 0;
            string curDay = DateTime.Now.DayOfWeek.ToString();

            switch (curDay)
            {               
                case "Tuesday":
                    decrement = -1;
                    break;
                case "Wednesday":
                    decrement = -2;
                    break;
                case "Thursday":
                    decrement = -3;
                    break;
                case "Friday":
                    decrement = -4;
                    break;
                case "Saturday":
                    decrement = -5;
                    break;
                case "Sunday":
                    decrement = -6;
                    break;
                default:
                    break;
            }

            afterDateTimePicker.Value = DateTime.Now.AddDays(decrement);
            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }   

        private void неделяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            afterDateTimePicker.Value = DateTime.Now.AddDays(-7);
            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }

        private void месяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            //Если это последний день года, то отсчитываю с декабря прошлого года
            if (month == 1)
                month = 12;
            else            
                month -= 1;          

            int days = DateTime.DaysInMonth(year, month);

            afterDateTimePicker.Value = DateTime.Now.AddDays(-days);
            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }

        private void заГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            if(!DateTime.IsLeapYear(DateTime.Now.Year))
                afterDateTimePicker.Value = DateTime.Now.AddDays(-366);
            else
                afterDateTimePicker.Value = DateTime.Now.AddDays(-365);

            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }   

        //Для запроса по интервалам времени разблокинуем выбор этих интервалов
        private void enableDates()
        {
            dBeforeCheckBox.Checked = true;
            dAfterCheckBox.Checked = true;
        }       

        //Здесь регулирую видимость/невидимость столбцов
        private void приоритетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount>0)
                dataGridView1.Columns[0].Visible = !dataGridView1.Columns[0].Visible;
        }

        private void статусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[1].Visible = !dataGridView1.Columns[1].Visible;
        }   

        private void категорияЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[2].Visible = !dataGridView1.Columns[2].Visible;
        }

        private void филиалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[3].Visible = !dataGridView1.Columns[3].Visible;
        }

        private void подразделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[4].Visible = !dataGridView1.Columns[4].Visible;
        }

        private void адресToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[5].Visible = !dataGridView1.Columns[5].Visible;
        }

        private void датаПодачиЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[6].Visible = !dataGridView1.Columns[6].Visible;
        }

        private void времяПодачиЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[7].Visible = !dataGridView1.Columns[7].Visible;
        }

        private void переданоИсполнителюЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[8].Visible = !dataGridView1.Columns[8].Visible;
        }

        private void комуНазначеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[9].Visible = !dataGridView1.Columns[9].Visible;
        }

        private void датаРазрешенияИнцидентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[10].Visible = !dataGridView1.Columns[10].Visible;
        }

        private void времяРазрешенияИнцидентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[11].Visible = !dataGridView1.Columns[11].Visible;
        }

        private void реальноеВремяУстраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[12].Visible = !dataGridView1.Columns[12].Visible;
        }

        private void плановоеВремяУстраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[13].Visible = !dataGridView1.Columns[13].Visible;
        }

        private void плановреВремяSLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[14].Visible = !dataGridView1.Columns[14].Visible;
        }

        private void описаниеНеисправностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[15].Visible = !dataGridView1.Columns[15].Visible;
        }

        private void принятыеМерыПричинаНеисправностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Columns[16].Visible = !dataGridView1.Columns[16].Visible;
        }

        //Устанавливаем смену контекстного меню для заголовка и для ячеек
        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.ContextMenuStrip = grid2ContextMenuStrip;

            if (e.Button == MouseButtons.Right)           
                
                grid2ContextMenuStrip.Show();
        }

        private void уважительностьПричиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[0].Visible = !dataGridView2.Columns[0].Visible;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[1].Visible = !dataGridView2.Columns[1].Visible;
        }

        private void статусToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[2].Visible = !dataGridView2.Columns[2].Visible;
        }       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[3].Visible = !dataGridView2.Columns[3].Visible;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[4].Visible = !dataGridView2.Columns[4].Visible;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[5].Visible = !dataGridView2.Columns[5].Visible;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[6].Visible = !dataGridView2.Columns[6].Visible;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[7].Visible = !dataGridView2.Columns[7].Visible;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[8].Visible = !dataGridView2.Columns[8].Visible;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[9].Visible = !dataGridView2.Columns[9].Visible;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[10].Visible = !dataGridView2.Columns[10].Visible;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[11].Visible = !dataGridView2.Columns[11].Visible;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[12].Visible = !dataGridView2.Columns[12].Visible;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[13].Visible = !dataGridView2.Columns[13].Visible;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[14].Visible = !dataGridView2.Columns[14].Visible;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[15].Visible = !dataGridView2.Columns[15].Visible;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[16].Visible = !dataGridView2.Columns[16].Visible;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                dataGridView2.Columns[17].Visible = !dataGridView2.Columns[17].Visible;
        }

        private void общиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainSettingsForm settingsForm = new MainSettingsForm();
            settingsForm.ShowDialog();

            //Если сохранялись настройки, то применяю их без перезагрузки программы
            if (settingsForm.DialogResult == DialogResult.OK)
                ApplySettings();
        }
        
        //Функция загрузки настроек
        public void ApplySettings()
        {
            //Заргужаю существующие настройки и настраиваю форму в соответствии с ними
            try
            {
                settingsClass.LoadSettings();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить настройки");
                return;
            }          

            //Секция настроек фильтрации
            dAfterCheckBox.Checked = settingsClass.DateAfter;
            afterDateTimePicker.Enabled = dAfterCheckBox.Checked;

            dBeforeCheckBox.Checked = settingsClass.DateBefore;
            beforeDateTimePicker.Checked = dBeforeCheckBox.Checked;

            switch (settingsClass.Status)
            {
                case "Новая":
                    statusComboBox.SelectedIndex = 0;
                    break;
                case "В работе (назначена)":
                    statusComboBox.SelectedIndex = 1;
                    break;
                case "В работе (запланирована)":
                    statusComboBox.SelectedIndex = 2;
                    break;
                case "Ожидающие решения":
                    statusComboBox.SelectedIndex = 3;
                    break;
                case "Решённые":
                    statusComboBox.SelectedIndex = 4;
                    break;
                case "Закрыты":
                    statusComboBox.SelectedIndex = 5;
                    break;
                case "Не закрыты":
                    statusComboBox.SelectedIndex = 6;
                    break;
                case "Решённые + Закрыто":
                    statusComboBox.SelectedIndex = 7;
                    break;
            }

            switch (settingsClass.Priority)
            {
                case "Как минимум Очень высокий":
                    priorityComboBox.SelectedIndex = 0;
                    break;
                case "Как минимум Высокий":
                    priorityComboBox.SelectedIndex = 1;
                    break;
                case "Как минимум Средний":
                    priorityComboBox.SelectedIndex = 2;
                    break;
                case "Как минимум Низкий":
                    priorityComboBox.SelectedIndex = 3;
                    break;
                case "Как минимум Очень низкий":
                    priorityComboBox.SelectedIndex = 4;
                    break;
                case "Наивысший":
                    priorityComboBox.SelectedIndex = 5;
                    break;
                case "Очень высокий":
                    priorityComboBox.SelectedIndex = 6;
                    break;
                case "Высокий":
                    priorityComboBox.SelectedIndex = 7;
                    break;
                case "Средний":
                    priorityComboBox.SelectedIndex = 8;
                    break;
                case "Низкий":
                    priorityComboBox.SelectedIndex = 9;
                    break;
                case "Очень низкий":
                    priorityComboBox.SelectedIndex = 10;
                    break;
            }

            statusCheckBox.Checked = settingsClass.StatusEnabled;
            statusComboBox.Enabled = statusCheckBox.Checked;

            PriorityCheckBox.Checked = settingsClass.PriorityEnabled;
            priorityComboBox.Enabled = PriorityCheckBox.Checked;   
         
            //Устанавливаю видимость полей для основного отчёта
            //Этот блок будет работать только для выполненного запроса
            if(dataGridView1.Columns.Count > 0)
            {
                for(int i=0; i<=16; i++)
                    dataGridView1.Columns[i].Visible = settingsClass.MainReport[i];                
            }           

            //Устанавливаю видимость полей для отчёта по пропущенным срокам
            //Этот блок будет работать только для выполненного запроса
            if(dataGridView2.ColumnCount > 0)
            {
                for(int i=0; i<=17; i++)
                    dataGridView2.Columns[i].Visible = settingsClass.OutOfTimeRep[i];                
            }

            //Выставляю галочки для пунктов контекстного меню основного отчёта
            ToolStripMenuItem item = grid1ContextMenuStrip.Items[0] as ToolStripMenuItem;
            item.Checked = settingsClass.MainReport[0];

            for (int i = 0; i <= 16; i++)
            {
                item = grid1ContextMenuStrip.Items[i] as ToolStripMenuItem;
                item.Checked = settingsClass.MainReport[i];
            }            

            //Выставляю галочки для пунктов контекстного меню отчёта по пропущенным заданиям
            for (int i = 0; i <= 17; i++)
            {
                item = grid2ContextMenuStrip.Items[i] as ToolStripMenuItem;
                item.Checked = settingsClass.OutOfTimeRep[i];
            }
        }

        private void составитьСвойЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Нужно перенести форму в DLL
            mainCQForm customQuery = new mainCQForm();
            customQuery.connString = Connect;
            customQuery.Show(this);
        }

        private void сНачалаМесяцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int day = DateTime.Now.Day;

            //Если это последний день года, то отсчитываю с декабря прошлого года
            if (month == 1)
                month = 12;
            else
                month -= 1;

            int days = day - 1;

            afterDateTimePicker.Value = DateTime.Now.AddDays(-days);
            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }

        private void сНачалаГодаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDates();             

            try
            {
                DateTime newYear = DateTime.Parse(DateTime.Now.Year.ToString() + ".01.01");
                afterDateTimePicker.Value = newYear;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось расчитать дату. Проверье региональные настройки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            beforeDateTimePicker.Value = DateTime.Now;

            queryButton_Click(sender, e);
        }

        private void группыПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            systemsReportForm sysRepForm = new systemsReportForm();
            sysRepForm.ShowDialog();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersReportForm usersRepForm = new usersReportForm();
            usersRepForm.ShowDialog();
        }

        private void отчётПоЭффективностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalReport totalRep = new totalReport();
            totalRep.ShowDialog();
        }        

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeMainForm();
        }

        //Отрабатываю сворачивание и разворачивание программы из трея
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                {
                    oldFormState = WindowState;
                    WindowState = FormWindowState.Minimized;
                }
                else
                {
                    Show();
                    WindowState = oldFormState;
                }
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }                        
    }
}