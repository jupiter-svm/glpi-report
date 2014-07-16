using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace SettingsClass
{
    public class MSettingsClass
    {
        public String Host { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String AutoEnter { get; set; }
        public Boolean DateAfter { get; set; }
        public Boolean DateBefore { get; set; }
        public String Status { get; set; }
        public Boolean StatusEnabled { get; set; }
        public String Priority { get; set; }
        public Boolean PriorityEnabled { get; set; }
        public Boolean[] MainReport { get; set; }
        public Boolean[] OutOfTimeRep { get; set; }

        //Без инициализации массива не получится им манипулировать
        public MSettingsClass()
        {
            MainReport = new Boolean[17];
            OutOfTimeRep = new Boolean[18];
        }

        //Функция загрузки настроек
        public void LoadSettings()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("settings.xml");

            //Узел настроек подключения
            XmlNode root = xml.DocumentElement.ChildNodes[0];

            Host=root.ChildNodes[0].Attributes[0].Value;
            Login = root.ChildNodes[1].Attributes[0].Value;
            Password = root.ChildNodes[2].Attributes[0].Value;
            AutoEnter = root.ChildNodes[3].Attributes[0].Value;

            //Узел настроек фильтрации
            root = xml.DocumentElement.ChildNodes[1];

            DateAfter = Boolean.Parse(root.ChildNodes[0].Attributes[0].Value);
            DateBefore = Boolean.Parse(root.ChildNodes[1].Attributes[0].Value);
            Status = root.ChildNodes[2].Attributes[0].Value;
            StatusEnabled = Boolean.Parse(root.ChildNodes[3].Attributes[0].Value);
            Priority = root.ChildNodes[4].Attributes[0].Value;
            PriorityEnabled = Boolean.Parse(root.ChildNodes[5].Attributes[0].Value);

            //Узел настроек видимости полей первого отчёта
            root = xml.DocumentElement.ChildNodes[2];

            MainReport[0]=Boolean.Parse(root.ChildNodes[0].Attributes[0].Value);
            MainReport[1]=Boolean.Parse(root.ChildNodes[1].Attributes[0].Value);
            MainReport[2]=Boolean.Parse(root.ChildNodes[2].Attributes[0].Value);
            MainReport[3]=Boolean.Parse(root.ChildNodes[3].Attributes[0].Value);
            MainReport[4]=Boolean.Parse(root.ChildNodes[4].Attributes[0].Value);
            MainReport[5]=Boolean.Parse(root.ChildNodes[5].Attributes[0].Value);
            MainReport[6]=Boolean.Parse(root.ChildNodes[6].Attributes[0].Value);
            MainReport[7]=Boolean.Parse(root.ChildNodes[7].Attributes[0].Value);
            MainReport[8]=Boolean.Parse(root.ChildNodes[8].Attributes[0].Value);
            MainReport[9]=Boolean.Parse(root.ChildNodes[9].Attributes[0].Value);
            MainReport[10]=Boolean.Parse(root.ChildNodes[10].Attributes[0].Value);
            MainReport[11]=Boolean.Parse(root.ChildNodes[11].Attributes[0].Value);
            MainReport[12]=Boolean.Parse(root.ChildNodes[12].Attributes[0].Value);
            MainReport[13]=Boolean.Parse(root.ChildNodes[13].Attributes[0].Value);
            MainReport[14]=Boolean.Parse(root.ChildNodes[14].Attributes[0].Value);
            MainReport[15]=Boolean.Parse(root.ChildNodes[15].Attributes[0].Value);
            MainReport[16] = Boolean.Parse(root.ChildNodes[16].Attributes[0].Value);

            //Узел настроек видимости полей отчёта по просроченным заданиям
            root = xml.DocumentElement.ChildNodes[3];

            OutOfTimeRep[0]=Boolean.Parse(root.ChildNodes[0].Attributes[0].Value);
            OutOfTimeRep[1]=Boolean.Parse(root.ChildNodes[1].Attributes[0].Value);
            OutOfTimeRep[2]=Boolean.Parse(root.ChildNodes[2].Attributes[0].Value);
            OutOfTimeRep[3]=Boolean.Parse(root.ChildNodes[3].Attributes[0].Value);
            OutOfTimeRep[4]=Boolean.Parse(root.ChildNodes[4].Attributes[0].Value);
            OutOfTimeRep[5]=Boolean.Parse(root.ChildNodes[5].Attributes[0].Value);
            OutOfTimeRep[6]=Boolean.Parse(root.ChildNodes[6].Attributes[0].Value);
            OutOfTimeRep[7]=Boolean.Parse(root.ChildNodes[7].Attributes[0].Value);
            OutOfTimeRep[8]=Boolean.Parse(root.ChildNodes[8].Attributes[0].Value);
            OutOfTimeRep[9]=Boolean.Parse(root.ChildNodes[9].Attributes[0].Value);
            OutOfTimeRep[10]=Boolean.Parse(root.ChildNodes[10].Attributes[0].Value);
            OutOfTimeRep[11]=Boolean.Parse(root.ChildNodes[11].Attributes[0].Value);
            OutOfTimeRep[12]=Boolean.Parse(root.ChildNodes[12].Attributes[0].Value);
            OutOfTimeRep[13]=Boolean.Parse(root.ChildNodes[13].Attributes[0].Value);
            OutOfTimeRep[14]=Boolean.Parse(root.ChildNodes[14].Attributes[0].Value);
            OutOfTimeRep[15]=Boolean.Parse(root.ChildNodes[15].Attributes[0].Value);
            OutOfTimeRep[16]=Boolean.Parse(root.ChildNodes[16].Attributes[0].Value);
            OutOfTimeRep[17] = Boolean.Parse(root.ChildNodes[17].Attributes[0].Value);
        }

        //Функция сохранения настроек
        public void SaveSettings()
        {
            FileStream fs = new FileStream("settings.xml", FileMode.Create);

            XmlTextWriter xml = new XmlTextWriter(fs, Encoding.UTF8);
            xml.Formatting = Formatting.Indented;

            //Делаю XML-like формарирование кода для удобства восприятия
            xml.WriteStartDocument();
            xml.WriteStartElement("Settings");

            //Настройки подключения
            xml.WriteStartElement("Connection");
                xml.WriteStartElement("Host");
                xml.WriteAttributeString("Value", Host);
                xml.WriteEndElement();

                xml.WriteStartElement("Login");
                xml.WriteAttributeString("Value", Login);
                xml.WriteEndElement();

                xml.WriteStartElement("Password");
                xml.WriteAttributeString("Value", Password);
                xml.WriteEndElement();

                xml.WriteStartElement("AutoEnter");
                xml.WriteAttributeString("Value", AutoEnter);
                xml.WriteEndElement();
            xml.WriteEndElement();

            //Настройки фильтрации
            xml.WriteStartElement("Filter");
                xml.WriteStartElement("DateAfter");
                xml.WriteAttributeString("Value", DateAfter.ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("DateBefore");
                xml.WriteAttributeString("Value", DateBefore.ToString());
                xml.WriteEndElement();               

                xml.WriteStartElement("Status");
                xml.WriteAttributeString("Value", Status);
                xml.WriteEndElement();

                xml.WriteStartElement("UseStatus");
                xml.WriteAttributeString("Value", StatusEnabled.ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Priority");
                xml.WriteAttributeString("Value", Priority);
                xml.WriteEndElement();

                xml.WriteStartElement("PriorityStatus");
                xml.WriteAttributeString("Value", PriorityEnabled.ToString());
                xml.WriteEndElement();
            xml.WriteEndElement();

            //Настройки видимости основных полей отчёта
            xml.WriteStartElement("Total");
                xml.WriteStartElement("Priority");
                xml.WriteAttributeString("Value", MainReport[0].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Status");
                xml.WriteAttributeString("Value", MainReport[1].ToString());
                xml.WriteEndElement();
                
                xml.WriteStartElement("Category");
                xml.WriteAttributeString("Value", MainReport[2].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("Filial");
                xml.WriteAttributeString("Value", MainReport[3].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("Podr");
                xml.WriteAttributeString("Value", MainReport[4].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("Address");
                xml.WriteAttributeString("Value", MainReport[5].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("StartDate");
                xml.WriteAttributeString("Value", MainReport[6].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("StartTime");
                xml.WriteAttributeString("Value", MainReport[7].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("TimeToUser");
                xml.WriteAttributeString("Value", MainReport[8].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("ToUser");
                xml.WriteAttributeString("Value", MainReport[9].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("DateOfResolve");
                xml.WriteAttributeString("Value", MainReport[10].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("ResolveTime");
                xml.WriteAttributeString("Value", MainReport[11].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("RealTime");
                xml.WriteAttributeString("Value", MainReport[12].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("Plan");
                xml.WriteAttributeString("Value", MainReport[13].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("PlanSLA");
                xml.WriteAttributeString("Value", MainReport[14].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("Desc");
                xml.WriteAttributeString("Value", MainReport[15].ToString());
                xml.WriteEndElement();  

                xml.WriteStartElement("ResultActions");
                xml.WriteAttributeString("Value", MainReport[16].ToString());
                xml.WriteEndElement();
            xml.WriteEndElement();

            //Настройка видимости полей отчёта по просроченным заданиям
            xml.WriteStartElement("OutOfTime");
                xml.WriteStartElement("Reason");
                xml.WriteAttributeString("Value", OutOfTimeRep[0].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Priority");
                xml.WriteAttributeString("Value", OutOfTimeRep[1].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Status");
                xml.WriteAttributeString("Value", OutOfTimeRep[2].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Category");
                xml.WriteAttributeString("Value", OutOfTimeRep[3].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Filial");
                xml.WriteAttributeString("Value", OutOfTimeRep[4].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Podr");
                xml.WriteAttributeString("Value", OutOfTimeRep[5].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Address");
                xml.WriteAttributeString("Value", OutOfTimeRep[6].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("StartDate");
                xml.WriteAttributeString("Value", OutOfTimeRep[7].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("StartTime");
                xml.WriteAttributeString("Value", OutOfTimeRep[8].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("TimeToUser");
                xml.WriteAttributeString("Value", OutOfTimeRep[9].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("ToUser");
                xml.WriteAttributeString("Value", OutOfTimeRep[10].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("DateOfResolve");
                xml.WriteAttributeString("Value", OutOfTimeRep[11].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("ResolveTime");
                xml.WriteAttributeString("Value", OutOfTimeRep[12].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("RealTime");
                xml.WriteAttributeString("Value", OutOfTimeRep[13].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Plan");
                xml.WriteAttributeString("Value", OutOfTimeRep[14].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("PlanSLA");
                xml.WriteAttributeString("Value", OutOfTimeRep[15].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("Desc");
                xml.WriteAttributeString("Value", OutOfTimeRep[16].ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("ResultActions");
                xml.WriteAttributeString("Value", OutOfTimeRep[17].ToString());
                xml.WriteEndElement();  
            xml.WriteEndElement();

            xml.WriteEndElement();
            xml.WriteEndDocument();

            xml.Close();
            fs.Close();
        }
    }
}
