using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SettingsClass;

namespace SettingsForm
{
    public partial class MainSettingsForm : Form
    {
        MSettingsClass settingsClass=new MSettingsClass();

        public MainSettingsForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = 5;
            priorityComboBox.SelectedIndex = 8;

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

            //Секция настроек подключения
            if (settingsClass.Host.Length!=0)
                hostTextBox.Text = settingsClass.Host;
            if (settingsClass.Login.Length != 0)
                logintextBox.Text = settingsClass.Login;
            if (settingsClass.Password.Length != 0)
                passTextBox.Text = settingsClass.Password;
            if (settingsClass.AutoEnter.Length != 0)
                autoEnterCheckBox.Checked = Boolean.Parse(settingsClass.AutoEnter);

            //Секция настроек фильтрации
            dateAfterCheckBox.Checked = settingsClass.DateAfter;
            dateBeforeCheckBox.Checked = settingsClass.DateBefore;

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

            priorityCheckBox.Checked = settingsClass.PriorityEnabled;
            priorityComboBox.Enabled = priorityCheckBox.Checked;

            //Секция видимости полей основного отчёта
            priMainCheckBox.Checked=settingsClass.MainReport[0];
            statusMainCheckBox.Checked=settingsClass.MainReport[1];
            catMainCheckBox.Checked=settingsClass.MainReport[2];
            filialMainCheckBox.Checked=settingsClass.MainReport[3];
            podrMainCheckBox.Checked=settingsClass.MainReport[4];
            addressMainCheckBox.Checked=settingsClass.MainReport[5];
            startDateMainCheckBox.Checked=settingsClass.MainReport[6];
            startTimeMainCheckBox.Checked=settingsClass.MainReport[7];
            timeToUserMainCheckBox.Checked=settingsClass.MainReport[8];
            toUserMainCheckBox.Checked=settingsClass.MainReport[9];
            dateOfResolveMainCheckBox.Checked=settingsClass.MainReport[10];
            resolveTimeMainCheckBox.Checked=settingsClass.MainReport[11];
            realTimeMainCheckBox.Checked=settingsClass.MainReport[12];
            planMainCheckBox.Checked=settingsClass.MainReport[13];
            planSLAMainCheckBox.Checked=settingsClass.MainReport[14];
            descMainCheckBox.Checked=settingsClass.MainReport[15];
            resActionsMainCheckBox.Checked=settingsClass.MainReport[16];

            //Секция видимости полей отчёта по просроченным заданиям
            reasonSecondCheckBox.Checked = settingsClass.OutOfTimeRep[0];
            priSecondCheckBox.Checked = settingsClass.OutOfTimeRep[1];
            statusSecondCheckBox.Checked=settingsClass.OutOfTimeRep[2];
            catSecondCheckBox.Checked=settingsClass.OutOfTimeRep[3];
            filialSecondCheckBox.Checked=settingsClass.OutOfTimeRep[4];
            podrSecondCheckBox.Checked=settingsClass.OutOfTimeRep[5];
            addressSecondCheckBox.Checked=settingsClass.OutOfTimeRep[6];
            startDateSecondCheckBox.Checked=settingsClass.OutOfTimeRep[7];
            startTimeSecondCheckBox.Checked=settingsClass.OutOfTimeRep[8];
            timeToUserSecondCheckBox.Checked=settingsClass.OutOfTimeRep[9];
            toUserSecondCheckBox.Checked=settingsClass.OutOfTimeRep[10];
            dateOfResolveSecondCheckBox.Checked=settingsClass.OutOfTimeRep[11];
            resolveTimeSecondCheckBox.Checked=settingsClass.OutOfTimeRep[12];
            realTimeSecondCheckBox.Checked=settingsClass.OutOfTimeRep[13];
            planSecondCheckBox.Checked=settingsClass.OutOfTimeRep[14];
            planSLASecondCheckBox.Checked=settingsClass.OutOfTimeRep[15];
            descSecondCheckBox.Checked=settingsClass.OutOfTimeRep[16];
            resActionsSecondCheckBox.Checked=settingsClass.OutOfTimeRep[17];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            statusComboBox.Enabled = statusCheckBox.Checked;
        }

        private void priorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            priorityComboBox.Enabled = priorityCheckBox.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingsClass.Host = hostTextBox.Text;
            settingsClass.Login = logintextBox.Text;
            settingsClass.Password = passTextBox.Text;
            settingsClass.AutoEnter = autoEnterCheckBox.Checked.ToString();

            settingsClass.DateAfter = dateAfterCheckBox.Checked;
            settingsClass.DateBefore = dateBeforeCheckBox.Checked;
            
            settingsClass.Status = statusComboBox.Text;
            settingsClass.StatusEnabled = statusCheckBox.Checked;

            settingsClass.Priority = priorityComboBox.Text;
            settingsClass.PriorityEnabled = priorityCheckBox.Checked;

            settingsClass.MainReport = new Boolean[17];

            //Сохраняю видимость полей в переменную-массив. Основной отчёт
            settingsClass.MainReport[0] = priMainCheckBox.Checked;
            settingsClass.MainReport[1] = statusMainCheckBox.Checked;
            settingsClass.MainReport[2] = catMainCheckBox.Checked;
            settingsClass.MainReport[3] = filialMainCheckBox.Checked;
            settingsClass.MainReport[4] = podrMainCheckBox.Checked;
            settingsClass.MainReport[5] = addressMainCheckBox.Checked;
            settingsClass.MainReport[6] = startDateMainCheckBox.Checked;
            settingsClass.MainReport[7] = startTimeMainCheckBox.Checked;
            settingsClass.MainReport[8] = timeToUserMainCheckBox.Checked;
            settingsClass.MainReport[9] = toUserMainCheckBox.Checked;
            settingsClass.MainReport[10] = dateOfResolveMainCheckBox.Checked;
            settingsClass.MainReport[11] = resolveTimeMainCheckBox.Checked;
            settingsClass.MainReport[12] = realTimeMainCheckBox.Checked;
            settingsClass.MainReport[13] = planMainCheckBox.Checked;
            settingsClass.MainReport[14] = planSLAMainCheckBox.Checked;
            settingsClass.MainReport[15] = descMainCheckBox.Checked;
            settingsClass.MainReport[16] = resActionsMainCheckBox.Checked;

            settingsClass.OutOfTimeRep = new Boolean[18];

            //Отчёт по просточенным заданиям
            settingsClass.OutOfTimeRep[0] = reasonSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[1] = priSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[2] = statusSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[3] = catSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[4] = filialSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[5] = podrSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[6] = addressSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[7] = startDateSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[8] = startTimeSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[9] = timeToUserSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[10] = toUserSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[11] = dateOfResolveSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[12] = resolveTimeSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[13] = realTimeSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[14] = planSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[15] = planSLASecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[16] = descSecondCheckBox.Checked;
            settingsClass.OutOfTimeRep[17] = resActionsSecondCheckBox.Checked;

            //Сохраняю настройки
            try
            {
                settingsClass.SaveSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить настройки\r\n"+ex.Message);
                return;
            }           

            Close();
        }
    }
}
