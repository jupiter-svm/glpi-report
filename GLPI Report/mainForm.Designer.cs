namespace GLPI_Report
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.percLabel = new System.Windows.Forms.Label();
            this.queryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.dBeforeCheckBox = new System.Windows.Forms.CheckBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.dAfterCheckBox = new System.Windows.Forms.CheckBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.beforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.afterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заВчерашнийДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.сНачалаНеделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неделяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.месяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сНачалаМесяцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.заГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сНачалаГодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
            this.основнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.составитьСвойЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиотекаЗапросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоЭффективностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.descRichTextBox = new System.Windows.Forms.RichTextBox();
            this.solWebBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid1ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.приоритетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияЗапросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.филиалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подразделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаПодачиЗапросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяПодачиЗапросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переданоИсполнителюЗапросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комуНазначеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаРазрешенияИнцидентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяРазрешенияИнцидентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реальноеВремяУстраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плановоеВремяУстраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плановреВремяSLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеНеисправностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTimeTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уважительнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неУважительнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customQuerytabPage = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.grid2ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уважительностьПричиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.мониторингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимМониторингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grid1ContextMenuStrip.SuspendLayout();
            this.oTimeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.customQuerytabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.grid2ContextMenuStrip.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.percLabel);
            this.settingsPanel.Controls.Add(this.queryButton);
            this.settingsPanel.Controls.Add(this.groupBox1);
            this.settingsPanel.Controls.Add(this.menuStrip1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1110, 118);
            this.settingsPanel.TabIndex = 0;
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percLabel.Location = new System.Drawing.Point(919, 61);
            this.percLabel.Name = "percLabel";
            this.percLabel.Size = new System.Drawing.Size(0, 16);
            this.percLabel.TabIndex = 2;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(829, 34);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 71);
            this.queryButton.TabIndex = 1;
            this.queryButton.Text = "Запрос";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriorityCheckBox);
            this.groupBox1.Controls.Add(this.dBeforeCheckBox);
            this.groupBox1.Controls.Add(this.statusCheckBox);
            this.groupBox1.Controls.Add(this.dAfterCheckBox);
            this.groupBox1.Controls.Add(this.priorityComboBox);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.beforeDateTimePicker);
            this.groupBox1.Controls.Add(this.afterDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // PriorityCheckBox
            // 
            this.PriorityCheckBox.AutoSize = true;
            this.PriorityCheckBox.Location = new System.Drawing.Point(494, 50);
            this.PriorityCheckBox.Name = "PriorityCheckBox";
            this.PriorityCheckBox.Size = new System.Drawing.Size(80, 17);
            this.PriorityCheckBox.TabIndex = 11;
            this.PriorityCheckBox.Text = "Приоритет";
            this.PriorityCheckBox.UseVisualStyleBackColor = true;
            this.PriorityCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCheckBox_CheckedChanged);
            // 
            // dBeforeCheckBox
            // 
            this.dBeforeCheckBox.AutoSize = true;
            this.dBeforeCheckBox.Checked = true;
            this.dBeforeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dBeforeCheckBox.Location = new System.Drawing.Point(421, 23);
            this.dBeforeCheckBox.Name = "dBeforeCheckBox";
            this.dBeforeCheckBox.Size = new System.Drawing.Size(153, 17);
            this.dBeforeCheckBox.TabIndex = 10;
            this.dBeforeCheckBox.Text = "Дата подачи запроса, до";
            this.dBeforeCheckBox.UseVisualStyleBackColor = true;
            this.dBeforeCheckBox.CheckedChanged += new System.EventHandler(this.dBeforeCheckBox_CheckedChanged);
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusCheckBox.Checked = true;
            this.statusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusCheckBox.Location = new System.Drawing.Point(83, 50);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(99, 17);
            this.statusCheckBox.TabIndex = 9;
            this.statusCheckBox.Text = "Статус заявки";
            this.statusCheckBox.UseVisualStyleBackColor = false;
            this.statusCheckBox.CheckedChanged += new System.EventHandler(this.statusCheckBox_CheckedChanged);
            // 
            // dAfterCheckBox
            // 
            this.dAfterCheckBox.AutoSize = true;
            this.dAfterCheckBox.Checked = true;
            this.dAfterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dAfterCheckBox.Location = new System.Drawing.Point(11, 23);
            this.dAfterCheckBox.Name = "dAfterCheckBox";
            this.dAfterCheckBox.Size = new System.Drawing.Size(171, 17);
            this.dAfterCheckBox.TabIndex = 8;
            this.dAfterCheckBox.Text = "Дата подачи запроса, после";
            this.dAfterCheckBox.UseVisualStyleBackColor = true;
            this.dAfterCheckBox.CheckedChanged += new System.EventHandler(this.dAfterCheckBox_CheckedChanged);
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.Enabled = false;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "Как минимум Очень высокий",
            "Как минимум Высокий",
            "Как минимум Средний",
            "Как минимум Низкий",
            "Как минимум Очень низкий",
            "Наивысший",
            "Очень высокий",
            "Высокий",
            "Средний",
            "Низкий",
            "Очень низкий"});
            this.priorityComboBox.Location = new System.Drawing.Point(580, 45);
            this.priorityComboBox.MaxDropDownItems = 13;
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(200, 21);
            this.priorityComboBox.TabIndex = 7;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Новая",
            "В работе (назначена)",
            "В работе (запланирована)",
            "Ожидающие решения",
            "Решённые",
            "Закрыты",
            "Не закрыты",
            "Решённые + Закрыто"});
            this.statusComboBox.Location = new System.Drawing.Point(188, 47);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // beforeDateTimePicker
            // 
            this.beforeDateTimePicker.Location = new System.Drawing.Point(580, 19);
            this.beforeDateTimePicker.Name = "beforeDateTimePicker";
            this.beforeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.beforeDateTimePicker.TabIndex = 3;
            // 
            // afterDateTimePicker
            // 
            this.afterDateTimePicker.Location = new System.Drawing.Point(188, 19);
            this.afterDateTimePicker.Name = "afterDateTimePicker";
            this.afterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.afterDateTimePicker.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.запросToolStripMenuItem,
            this.библиотекаЗапросовToolStripMenuItem,
            this.мониторингToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузкаВExcelToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деньToolStripMenuItem,
            this.заВчерашнийДеньToolStripMenuItem,
            this.toolStripMenuItem17,
            this.сНачалаНеделиToolStripMenuItem,
            this.неделяToolStripMenuItem,
            this.toolStripMenuItem18,
            this.месяцToolStripMenuItem,
            this.сНачалаМесяцаToolStripMenuItem,
            this.toolStripMenuItem19,
            this.заГодToolStripMenuItem,
            this.сНачалаГодаToolStripMenuItem,
            this.toolStripMenuItem20,
            this.основнойToolStripMenuItem,
            this.toolStripSeparator2,
            this.составитьСвойЗапросToolStripMenuItem});
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросToolStripMenuItem.Text = "Запросы";
            // 
            // деньToolStripMenuItem
            // 
            this.деньToolStripMenuItem.Name = "деньToolStripMenuItem";
            this.деньToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.деньToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.деньToolStripMenuItem.Text = "За день";
            this.деньToolStripMenuItem.Click += new System.EventHandler(this.деньToolStripMenuItem_Click);
            // 
            // заВчерашнийДеньToolStripMenuItem
            // 
            this.заВчерашнийДеньToolStripMenuItem.Name = "заВчерашнийДеньToolStripMenuItem";
            this.заВчерашнийДеньToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.заВчерашнийДеньToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.заВчерашнийДеньToolStripMenuItem.Text = "За вчерашний день";
            this.заВчерашнийДеньToolStripMenuItem.Click += new System.EventHandler(this.заВчерашнийДеньToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(262, 6);
            // 
            // сНачалаНеделиToolStripMenuItem
            // 
            this.сНачалаНеделиToolStripMenuItem.Name = "сНачалаНеделиToolStripMenuItem";
            this.сНачалаНеделиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.сНачалаНеделиToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.сНачалаНеделиToolStripMenuItem.Text = "С начала недели";
            this.сНачалаНеделиToolStripMenuItem.Click += new System.EventHandler(this.сНачалаНеделиToolStripMenuItem_Click);
            // 
            // неделяToolStripMenuItem
            // 
            this.неделяToolStripMenuItem.Name = "неделяToolStripMenuItem";
            this.неделяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
            this.неделяToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.неделяToolStripMenuItem.Text = "За неделю";
            this.неделяToolStripMenuItem.Click += new System.EventHandler(this.неделяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(262, 6);
            // 
            // месяцToolStripMenuItem
            // 
            this.месяцToolStripMenuItem.Name = "месяцToolStripMenuItem";
            this.месяцToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.месяцToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.месяцToolStripMenuItem.Text = "За месяц";
            this.месяцToolStripMenuItem.Click += new System.EventHandler(this.месяцToolStripMenuItem_Click);
            // 
            // сНачалаМесяцаToolStripMenuItem
            // 
            this.сНачалаМесяцаToolStripMenuItem.Name = "сНачалаМесяцаToolStripMenuItem";
            this.сНачалаМесяцаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.сНачалаМесяцаToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.сНачалаМесяцаToolStripMenuItem.Text = "С начала месяца";
            this.сНачалаМесяцаToolStripMenuItem.Click += new System.EventHandler(this.сНачалаМесяцаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(262, 6);
            // 
            // заГодToolStripMenuItem
            // 
            this.заГодToolStripMenuItem.Name = "заГодToolStripMenuItem";
            this.заГодToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Y)));
            this.заГодToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.заГодToolStripMenuItem.Text = "За год";
            this.заГодToolStripMenuItem.Click += new System.EventHandler(this.заГодToolStripMenuItem_Click);
            // 
            // сНачалаГодаToolStripMenuItem
            // 
            this.сНачалаГодаToolStripMenuItem.Name = "сНачалаГодаToolStripMenuItem";
            this.сНачалаГодаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Y)));
            this.сНачалаГодаToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.сНачалаГодаToolStripMenuItem.Text = "С начала года";
            this.сНачалаГодаToolStripMenuItem.Click += new System.EventHandler(this.сНачалаГодаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(262, 6);
            // 
            // основнойToolStripMenuItem
            // 
            this.основнойToolStripMenuItem.Name = "основнойToolStripMenuItem";
            this.основнойToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.основнойToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.основнойToolStripMenuItem.Text = "Текущие параметры";
            this.основнойToolStripMenuItem.Click += new System.EventHandler(this.основнойToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
            // 
            // составитьСвойЗапросToolStripMenuItem
            // 
            this.составитьСвойЗапросToolStripMenuItem.Name = "составитьСвойЗапросToolStripMenuItem";
            this.составитьСвойЗапросToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.составитьСвойЗапросToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.составитьСвойЗапросToolStripMenuItem.Text = "Составить свой запрос";
            this.составитьСвойЗапросToolStripMenuItem.Click += new System.EventHandler(this.составитьСвойЗапросToolStripMenuItem_Click);
            // 
            // библиотекаЗапросовToolStripMenuItem
            // 
            this.библиотекаЗапросовToolStripMenuItem.Name = "библиотекаЗапросовToolStripMenuItem";
            this.библиотекаЗапросовToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.библиотекаЗапросовToolStripMenuItem.Text = "Библиотека запросов";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группыПользователейToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.toolStripMenuItem21,
            this.отчётПоЭффективностиToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // группыПользователейToolStripMenuItem
            // 
            this.группыПользователейToolStripMenuItem.Name = "группыПользователейToolStripMenuItem";
            this.группыПользователейToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.группыПользователейToolStripMenuItem.Text = "Системы";
            this.группыПользователейToolStripMenuItem.Click += new System.EventHandler(this.группыПользователейToolStripMenuItem_Click);
            // 
            // отчётПоЭффективностиToolStripMenuItem
            // 
            this.отчётПоЭффективностиToolStripMenuItem.Name = "отчётПоЭффективностиToolStripMenuItem";
            this.отчётПоЭффективностиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.отчётПоЭффективностиToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.отчётПоЭффективностиToolStripMenuItem.Text = "Отчёт по эффективности";
            this.отчётПоЭффективностиToolStripMenuItem.Click += new System.EventHandler(this.отчётПоЭффективностиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общиеToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // общиеToolStripMenuItem
            // 
            this.общиеToolStripMenuItem.Name = "общиеToolStripMenuItem";
            this.общиеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.общиеToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.общиеToolStripMenuItem.Text = "Общие";
            this.общиеToolStripMenuItem.Click += new System.EventHandler(this.общиеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabsPanel
            // 
            this.tabsPanel.Controls.Add(this.splitContainer1);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabsPanel.Location = new System.Drawing.Point(0, 648);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(1110, 100);
            this.tabsPanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.descRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.solWebBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 100);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.TabIndex = 0;
            // 
            // descRichTextBox
            // 
            this.descRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.descRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.descRichTextBox.Name = "descRichTextBox";
            this.descRichTextBox.ReadOnly = true;
            this.descRichTextBox.Size = new System.Drawing.Size(584, 100);
            this.descRichTextBox.TabIndex = 0;
            this.descRichTextBox.Text = "";
            // 
            // solWebBrowser
            // 
            this.solWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.solWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.solWebBrowser.Name = "solWebBrowser";
            this.solWebBrowser.Size = new System.Drawing.Size(522, 100);
            this.solWebBrowser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 530);
            this.panel1.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainTabPage);
            this.tabControl.Controls.Add(this.oTimeTabPage);
            this.tabControl.Controls.Add(this.customQuerytabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1110, 530);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.dataGridView1);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(1102, 504);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Основной отчёт отдела";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.grid1ContextMenuStrip;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // grid1ContextMenuStrip
            // 
            this.grid1ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приоритетToolStripMenuItem,
            this.статусToolStripMenuItem,
            this.категорияЗапросаToolStripMenuItem,
            this.филиалToolStripMenuItem,
            this.подразделениеToolStripMenuItem,
            this.адресToolStripMenuItem,
            this.датаПодачиЗапросаToolStripMenuItem,
            this.времяПодачиЗапросаToolStripMenuItem,
            this.переданоИсполнителюЗапросаToolStripMenuItem,
            this.комуНазначеноToolStripMenuItem,
            this.датаРазрешенияИнцидентаToolStripMenuItem,
            this.времяРазрешенияИнцидентаToolStripMenuItem,
            this.реальноеВремяУстраненияToolStripMenuItem,
            this.плановоеВремяУстраненияToolStripMenuItem,
            this.плановреВремяSLAToolStripMenuItem,
            this.описаниеНеисправностиToolStripMenuItem,
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem});
            this.grid1ContextMenuStrip.Name = "grid1ContextMenuStrip";
            this.grid1ContextMenuStrip.Size = new System.Drawing.Size(306, 378);
            // 
            // приоритетToolStripMenuItem
            // 
            this.приоритетToolStripMenuItem.Checked = true;
            this.приоритетToolStripMenuItem.CheckOnClick = true;
            this.приоритетToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.приоритетToolStripMenuItem.Name = "приоритетToolStripMenuItem";
            this.приоритетToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.приоритетToolStripMenuItem.Text = "Приоритет";
            this.приоритетToolStripMenuItem.Click += new System.EventHandler(this.приоритетToolStripMenuItem_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.CheckOnClick = true;
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.статусToolStripMenuItem.Text = "Статус";
            this.статусToolStripMenuItem.Click += new System.EventHandler(this.статусToolStripMenuItem_Click);
            // 
            // категорияЗапросаToolStripMenuItem
            // 
            this.категорияЗапросаToolStripMenuItem.Checked = true;
            this.категорияЗапросаToolStripMenuItem.CheckOnClick = true;
            this.категорияЗапросаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.категорияЗапросаToolStripMenuItem.Name = "категорияЗапросаToolStripMenuItem";
            this.категорияЗапросаToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.категорияЗапросаToolStripMenuItem.Text = "Категория запроса";
            this.категорияЗапросаToolStripMenuItem.Click += new System.EventHandler(this.категорияЗапросаToolStripMenuItem_Click);
            // 
            // филиалToolStripMenuItem
            // 
            this.филиалToolStripMenuItem.Checked = true;
            this.филиалToolStripMenuItem.CheckOnClick = true;
            this.филиалToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.филиалToolStripMenuItem.Name = "филиалToolStripMenuItem";
            this.филиалToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.филиалToolStripMenuItem.Text = "Филиал";
            this.филиалToolStripMenuItem.Click += new System.EventHandler(this.филиалToolStripMenuItem_Click);
            // 
            // подразделениеToolStripMenuItem
            // 
            this.подразделениеToolStripMenuItem.Checked = true;
            this.подразделениеToolStripMenuItem.CheckOnClick = true;
            this.подразделениеToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.подразделениеToolStripMenuItem.Name = "подразделениеToolStripMenuItem";
            this.подразделениеToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.подразделениеToolStripMenuItem.Text = "Подразделение";
            this.подразделениеToolStripMenuItem.Click += new System.EventHandler(this.подразделениеToolStripMenuItem_Click);
            // 
            // адресToolStripMenuItem
            // 
            this.адресToolStripMenuItem.Checked = true;
            this.адресToolStripMenuItem.CheckOnClick = true;
            this.адресToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.адресToolStripMenuItem.Name = "адресToolStripMenuItem";
            this.адресToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.адресToolStripMenuItem.Text = "Адрес";
            this.адресToolStripMenuItem.Click += new System.EventHandler(this.адресToolStripMenuItem_Click);
            // 
            // датаПодачиЗапросаToolStripMenuItem
            // 
            this.датаПодачиЗапросаToolStripMenuItem.Checked = true;
            this.датаПодачиЗапросаToolStripMenuItem.CheckOnClick = true;
            this.датаПодачиЗапросаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.датаПодачиЗапросаToolStripMenuItem.Name = "датаПодачиЗапросаToolStripMenuItem";
            this.датаПодачиЗапросаToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.датаПодачиЗапросаToolStripMenuItem.Text = "Дата подачи запроса";
            this.датаПодачиЗапросаToolStripMenuItem.Click += new System.EventHandler(this.датаПодачиЗапросаToolStripMenuItem_Click);
            // 
            // времяПодачиЗапросаToolStripMenuItem
            // 
            this.времяПодачиЗапросаToolStripMenuItem.Checked = true;
            this.времяПодачиЗапросаToolStripMenuItem.CheckOnClick = true;
            this.времяПодачиЗапросаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.времяПодачиЗапросаToolStripMenuItem.Name = "времяПодачиЗапросаToolStripMenuItem";
            this.времяПодачиЗапросаToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.времяПодачиЗапросаToolStripMenuItem.Text = "Время подачи запроса";
            this.времяПодачиЗапросаToolStripMenuItem.Click += new System.EventHandler(this.времяПодачиЗапросаToolStripMenuItem_Click);
            // 
            // переданоИсполнителюЗапросаToolStripMenuItem
            // 
            this.переданоИсполнителюЗапросаToolStripMenuItem.Checked = true;
            this.переданоИсполнителюЗапросаToolStripMenuItem.CheckOnClick = true;
            this.переданоИсполнителюЗапросаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.переданоИсполнителюЗапросаToolStripMenuItem.Name = "переданоИсполнителюЗапросаToolStripMenuItem";
            this.переданоИсполнителюЗапросаToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.переданоИсполнителюЗапросаToolStripMenuItem.Text = "Передано исполнителю запроса";
            this.переданоИсполнителюЗапросаToolStripMenuItem.Click += new System.EventHandler(this.переданоИсполнителюЗапросаToolStripMenuItem_Click);
            // 
            // комуНазначеноToolStripMenuItem
            // 
            this.комуНазначеноToolStripMenuItem.Checked = true;
            this.комуНазначеноToolStripMenuItem.CheckOnClick = true;
            this.комуНазначеноToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.комуНазначеноToolStripMenuItem.Name = "комуНазначеноToolStripMenuItem";
            this.комуНазначеноToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.комуНазначеноToolStripMenuItem.Text = "Кому назначено";
            this.комуНазначеноToolStripMenuItem.Click += new System.EventHandler(this.комуНазначеноToolStripMenuItem_Click);
            // 
            // датаРазрешенияИнцидентаToolStripMenuItem
            // 
            this.датаРазрешенияИнцидентаToolStripMenuItem.Checked = true;
            this.датаРазрешенияИнцидентаToolStripMenuItem.CheckOnClick = true;
            this.датаРазрешенияИнцидентаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.датаРазрешенияИнцидентаToolStripMenuItem.Name = "датаРазрешенияИнцидентаToolStripMenuItem";
            this.датаРазрешенияИнцидентаToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.датаРазрешенияИнцидентаToolStripMenuItem.Text = "Дата разрешения инцидента";
            this.датаРазрешенияИнцидентаToolStripMenuItem.Click += new System.EventHandler(this.датаРазрешенияИнцидентаToolStripMenuItem_Click);
            // 
            // времяРазрешенияИнцидентаToolStripMenuItem
            // 
            this.времяРазрешенияИнцидентаToolStripMenuItem.Checked = true;
            this.времяРазрешенияИнцидентаToolStripMenuItem.CheckOnClick = true;
            this.времяРазрешенияИнцидентаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.времяРазрешенияИнцидентаToolStripMenuItem.Name = "времяРазрешенияИнцидентаToolStripMenuItem";
            this.времяРазрешенияИнцидентаToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.времяРазрешенияИнцидентаToolStripMenuItem.Text = "Время разрешения инцидента";
            this.времяРазрешенияИнцидентаToolStripMenuItem.Click += new System.EventHandler(this.времяРазрешенияИнцидентаToolStripMenuItem_Click);
            // 
            // реальноеВремяУстраненияToolStripMenuItem
            // 
            this.реальноеВремяУстраненияToolStripMenuItem.Checked = true;
            this.реальноеВремяУстраненияToolStripMenuItem.CheckOnClick = true;
            this.реальноеВремяУстраненияToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.реальноеВремяУстраненияToolStripMenuItem.Name = "реальноеВремяУстраненияToolStripMenuItem";
            this.реальноеВремяУстраненияToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.реальноеВремяУстраненияToolStripMenuItem.Text = "Реальное время устранения";
            this.реальноеВремяУстраненияToolStripMenuItem.Click += new System.EventHandler(this.реальноеВремяУстраненияToolStripMenuItem_Click);
            // 
            // плановоеВремяУстраненияToolStripMenuItem
            // 
            this.плановоеВремяУстраненияToolStripMenuItem.Checked = true;
            this.плановоеВремяУстраненияToolStripMenuItem.CheckOnClick = true;
            this.плановоеВремяУстраненияToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.плановоеВремяУстраненияToolStripMenuItem.Name = "плановоеВремяУстраненияToolStripMenuItem";
            this.плановоеВремяУстраненияToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.плановоеВремяУстраненияToolStripMenuItem.Text = "Плановое время устранения";
            this.плановоеВремяУстраненияToolStripMenuItem.Click += new System.EventHandler(this.плановоеВремяУстраненияToolStripMenuItem_Click);
            // 
            // плановреВремяSLAToolStripMenuItem
            // 
            this.плановреВремяSLAToolStripMenuItem.Checked = true;
            this.плановреВремяSLAToolStripMenuItem.CheckOnClick = true;
            this.плановреВремяSLAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.плановреВремяSLAToolStripMenuItem.Name = "плановреВремяSLAToolStripMenuItem";
            this.плановреВремяSLAToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.плановреВремяSLAToolStripMenuItem.Text = "Плановре время SLA";
            this.плановреВремяSLAToolStripMenuItem.Click += new System.EventHandler(this.плановреВремяSLAToolStripMenuItem_Click);
            // 
            // описаниеНеисправностиToolStripMenuItem
            // 
            this.описаниеНеисправностиToolStripMenuItem.Checked = true;
            this.описаниеНеисправностиToolStripMenuItem.CheckOnClick = true;
            this.описаниеНеисправностиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.описаниеНеисправностиToolStripMenuItem.Name = "описаниеНеисправностиToolStripMenuItem";
            this.описаниеНеисправностиToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.описаниеНеисправностиToolStripMenuItem.Text = "Описание неисправности";
            this.описаниеНеисправностиToolStripMenuItem.Click += new System.EventHandler(this.описаниеНеисправностиToolStripMenuItem_Click);
            // 
            // принятыеМерыПричинаНеисправностиToolStripMenuItem
            // 
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.Checked = true;
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.CheckOnClick = true;
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.Name = "принятыеМерыПричинаНеисправностиToolStripMenuItem";
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.Text = "Принятые меры, причина неисправности";
            this.принятыеМерыПричинаНеисправностиToolStripMenuItem.Click += new System.EventHandler(this.принятыеМерыПричинаНеисправностиToolStripMenuItem_Click);
            // 
            // oTimeTabPage
            // 
            this.oTimeTabPage.Controls.Add(this.dataGridView2);
            this.oTimeTabPage.Location = new System.Drawing.Point(4, 22);
            this.oTimeTabPage.Name = "oTimeTabPage";
            this.oTimeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.oTimeTabPage.Size = new System.Drawing.Size(1102, 504);
            this.oTimeTabPage.TabIndex = 1;
            this.oTimeTabPage.Text = "Отчёт по просроченным заявкам";
            this.oTimeTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1096, 498);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_ColumnHeaderMouseClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            this.dataGridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уважительнаяToolStripMenuItem,
            this.неУважительнаяToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
            // 
            // уважительнаяToolStripMenuItem
            // 
            this.уважительнаяToolStripMenuItem.Name = "уважительнаяToolStripMenuItem";
            this.уважительнаяToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.уважительнаяToolStripMenuItem.Text = "Уважительная";
            this.уважительнаяToolStripMenuItem.Click += new System.EventHandler(this.уважительнаяToolStripMenuItem_Click);
            // 
            // неУважительнаяToolStripMenuItem
            // 
            this.неУважительнаяToolStripMenuItem.Name = "неУважительнаяToolStripMenuItem";
            this.неУважительнаяToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.неУважительнаяToolStripMenuItem.Text = "Неуважительная";
            this.неУважительнаяToolStripMenuItem.Click += new System.EventHandler(this.неУважительнаяToolStripMenuItem_Click);
            // 
            // customQuerytabPage
            // 
            this.customQuerytabPage.Controls.Add(this.dataGridView3);
            this.customQuerytabPage.Location = new System.Drawing.Point(4, 22);
            this.customQuerytabPage.Name = "customQuerytabPage";
            this.customQuerytabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customQuerytabPage.Size = new System.Drawing.Size(1102, 504);
            this.customQuerytabPage.TabIndex = 2;
            this.customQuerytabPage.Text = "Составленный запрос";
            this.customQuerytabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1096, 498);
            this.dataGridView3.TabIndex = 0;
            // 
            // grid2ContextMenuStrip
            // 
            this.grid2ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уважительностьПричиныToolStripMenuItem,
            this.toolStripMenuItem1,
            this.статусToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.grid2ContextMenuStrip.Name = "grid1ContextMenuStrip";
            this.grid2ContextMenuStrip.Size = new System.Drawing.Size(306, 400);
            // 
            // уважительностьПричиныToolStripMenuItem
            // 
            this.уважительностьПричиныToolStripMenuItem.Checked = true;
            this.уважительностьПричиныToolStripMenuItem.CheckOnClick = true;
            this.уважительностьПричиныToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.уважительностьПричиныToolStripMenuItem.Name = "уважительностьПричиныToolStripMenuItem";
            this.уважительностьПричиныToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.уважительностьПричиныToolStripMenuItem.Text = "Причина пропуска срока";
            this.уважительностьПричиныToolStripMenuItem.Click += new System.EventHandler(this.уважительностьПричиныToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem1.Text = "Приоритет";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // статусToolStripMenuItem1
            // 
            this.статусToolStripMenuItem1.CheckOnClick = true;
            this.статусToolStripMenuItem1.Name = "статусToolStripMenuItem1";
            this.статусToolStripMenuItem1.Size = new System.Drawing.Size(305, 22);
            this.статусToolStripMenuItem1.Text = "Статус";
            this.статусToolStripMenuItem1.Click += new System.EventHandler(this.статусToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem2.Text = "Категория запроса";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem3.Text = "Филиал";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Checked = true;
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem4.Text = "Подразделение";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Checked = true;
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem5.Text = "Адрес";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Checked = true;
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem6.Text = "Дата подачи запроса";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Checked = true;
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem7.Text = "Время подачи запроса";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Checked = true;
            this.toolStripMenuItem8.CheckOnClick = true;
            this.toolStripMenuItem8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem8.Text = "Передано исполнителю запроса";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Checked = true;
            this.toolStripMenuItem9.CheckOnClick = true;
            this.toolStripMenuItem9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem9.Text = "Кому назначено";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Checked = true;
            this.toolStripMenuItem10.CheckOnClick = true;
            this.toolStripMenuItem10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem10.Text = "Дата разрешения инцидента";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Checked = true;
            this.toolStripMenuItem11.CheckOnClick = true;
            this.toolStripMenuItem11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem11.Text = "Время разрешения инцидента";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Checked = true;
            this.toolStripMenuItem12.CheckOnClick = true;
            this.toolStripMenuItem12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem12.Text = "Реальное время устранения";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Checked = true;
            this.toolStripMenuItem13.CheckOnClick = true;
            this.toolStripMenuItem13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem13.Text = "Плановое время устранения";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Checked = true;
            this.toolStripMenuItem14.CheckOnClick = true;
            this.toolStripMenuItem14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem14.Text = "Плановре время SLA";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Checked = true;
            this.toolStripMenuItem15.CheckOnClick = true;
            this.toolStripMenuItem15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem15.Text = "Описание неисправности";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Checked = true;
            this.toolStripMenuItem16.CheckOnClick = true;
            this.toolStripMenuItem16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(305, 22);
            this.toolStripMenuItem16.Text = "Принятые меры, причина неисправности";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(272, 6);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GLPI Report";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(146, 26);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // мониторингToolStripMenuItem
            // 
            this.мониторингToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимМониторингаToolStripMenuItem});
            this.мониторингToolStripMenuItem.Name = "мониторингToolStripMenuItem";
            this.мониторингToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.мониторингToolStripMenuItem.Text = "Мониторинг";
            // 
            // режимМониторингаToolStripMenuItem
            // 
            this.режимМониторингаToolStripMenuItem.Name = "режимМониторингаToolStripMenuItem";
            this.режимМониторингаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.режимМониторингаToolStripMenuItem.Text = "Режим мониторинга";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 748);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabsPanel);
            this.Controls.Add(this.settingsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLPI Report (Beta)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabsPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grid1ContextMenuStrip.ResumeLayout(false);
            this.oTimeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.customQuerytabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.grid2ContextMenuStrip.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage oTimeTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker beforeDateTimePicker;
        private System.Windows.Forms.DateTimePicker afterDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.CheckBox dAfterCheckBox;
        private System.Windows.Forms.CheckBox PriorityCheckBox;
        private System.Windows.Forms.CheckBox dBeforeCheckBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem уважительнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неУважительнаяToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox descRichTextBox;
        private System.Windows.Forms.WebBrowser solWebBrowser;
        private System.Windows.Forms.Label percLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неделяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem месяцToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip grid1ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem приоритетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорияЗапросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem филиалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подразделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаПодачиЗапросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяПодачиЗапросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переданоИсполнителюЗапросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комуНазначеноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаРазрешенияИнцидентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяРазрешенияИнцидентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реальноеВремяУстраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плановоеВремяУстраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плановреВремяSLAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеНеисправностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятыеМерыПричинаНеисправностиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip grid2ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem уважительностьПричиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem библиотекаЗапросовToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem составитьСвойЗапросToolStripMenuItem;
        private System.Windows.Forms.TabPage customQuerytabPage;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem сНачалаНеделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заВчерашнийДеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётПоЭффективностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem сНачалаМесяцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem сНачалаГодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem21;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem мониторингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимМониторингаToolStripMenuItem;
    }
}