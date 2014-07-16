using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GLPI_Report
{
    public partial class mainCQForm : Form
    {
        public string connString;

        private MySqlConnection tablesConn;
        private MySqlConnection fieldsConn;

        private MySqlCommand tablesCommand = new MySqlCommand();
        private MySqlCommand fieldsCommand=new MySqlCommand();

        public mainCQForm()
        {
            InitializeComponent();            
        }       

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainCQForm_Load(object sender, EventArgs e)
        {
            //Выбираю первый шаблон запроса из списка
            statComboBox.SelectedIndex = 0;

            //Вывожу список таблиц
            tablesConn = new MySqlConnection(connString);            

            tablesConn.Open();

            tablesCommand.Connection = tablesConn;
            tablesCommand.CommandText = "SHOW TABLES;";

            MySqlDataReader reader = tablesCommand.ExecuteReader();

            while (reader.Read())
                tablesListBox.Items.Add(reader.GetValue(0).ToString());

            tablesConn.Close();
        }

        private void addStatButton_Click(object sender, EventArgs e)
        {            
            qRichTextBox.Text += statComboBox.SelectedItem;            
        }

        private void QButton_Click(object sender, EventArgs e)
        {
            (Owner as mainForm).callCustomQuery(qRichTextBox.Text);
        }

        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QButton_Click(sender, e);
        }

        //Поля таблицы беру из информационной схемы
        private void tablesListBox_Click(object sender, EventArgs e)
        {
            if(tablesListBox.Items.Count==0)
                return;

            //Беру настройки из основной формы, чтобы не тратить время на их повторную загрузку с созданием класса
            string fieldsConnString = "Database=information_schema;Data Source=" + (Owner as mainForm).settingsClass.Host + ";User Id=" + (Owner as mainForm).settingsClass.Login +
                                       ";Password=" + (Owner as mainForm).settingsClass.Password + ";charset=utf8;"; ;

            fieldsConn = new MySqlConnection(fieldsConnString);

            try
            {
                fieldsConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить список полей таблицы\r\n"+ex.Message);
                return;
            }

            fieldsCommand.Connection = fieldsConn;
            fieldsCommand.CommandText = "SELECT column_name FROM `COLUMNS` "+
                                        "WHERE table_name='"+tablesListBox.SelectedItem+"';";

            MySqlDataReader reader = fieldsCommand.ExecuteReader();

            fieldsListBox.Items.Clear();

            while (reader.Read())
                fieldsListBox.Items.Add(reader.GetValue(0).ToString());

            reader.Close();
            fieldsConn.Close();
        }

        private void tablesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (tablesListBox.Items.Count > 0)
                if (qRichTextBox.Text.LastIndexOf(" ") == qRichTextBox.Text.Length - 1) //Устанавливаю пробелы после выражения, если нужно
                    qRichTextBox.Text += tablesListBox.SelectedItem;
                else
                    qRichTextBox.Text += " " + tablesListBox.SelectedItem;
        }

        private void fieldsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (fieldsListBox.Items.Count > 0)
                if (qRichTextBox.Text.LastIndexOf(" ") == qRichTextBox.Text.Length-1) //Устанавливаю пробелы после выражения, если нужно
                    qRichTextBox.Text += fieldsListBox.SelectedItem;
                else
                    qRichTextBox.Text += " " + fieldsListBox.SelectedItem;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFDialog = new OpenFileDialog();


            if (oFDialog.ShowDialog()==DialogResult.OK)
                try
                {
                    qRichTextBox.LoadFile(oFDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить файл\r\n"+ex.Message);
                }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFDialog = new SaveFileDialog();
            sFDialog.Filter = "Файлы запросов (*.sql)|*.sql";

            if(sFDialog.ShowDialog()==DialogResult.OK)
                try
                {
                    qRichTextBox.SaveFile(sFDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сохнатить файл\r\n" + ex.Message);
                }
        }

        private void данныеТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablesListBox.Items.Count > 0 && tablesListBox.SelectedItems.Count > 0)
                qRichTextBox.Text = "SELECT * FROM " + tablesListBox.SelectedItem;

            QButton_Click(sender, e);
        }

        private void данныеТаблицыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            данныеТаблицыToolStripMenuItem_Click(sender, e);
        }

        private void tablesListBox_KeyUp(object sender, KeyEventArgs e)
        {
            tablesListBox_Click(sender, (EventArgs)e);
        }
    }
}
