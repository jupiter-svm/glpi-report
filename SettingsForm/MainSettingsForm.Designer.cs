namespace SettingsForm
{
    partial class MainSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.priorityCheckBox = new System.Windows.Forms.CheckBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.dateBeforeCheckBox = new System.Windows.Forms.CheckBox();
            this.dateAfterCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resActionsMainCheckBox = new System.Windows.Forms.CheckBox();
            this.descMainCheckBox = new System.Windows.Forms.CheckBox();
            this.planSLAMainCheckBox = new System.Windows.Forms.CheckBox();
            this.planMainCheckBox = new System.Windows.Forms.CheckBox();
            this.realTimeMainCheckBox = new System.Windows.Forms.CheckBox();
            this.resolveTimeMainCheckBox = new System.Windows.Forms.CheckBox();
            this.dateOfResolveMainCheckBox = new System.Windows.Forms.CheckBox();
            this.toUserMainCheckBox = new System.Windows.Forms.CheckBox();
            this.timeToUserMainCheckBox = new System.Windows.Forms.CheckBox();
            this.startTimeMainCheckBox = new System.Windows.Forms.CheckBox();
            this.startDateMainCheckBox = new System.Windows.Forms.CheckBox();
            this.addressMainCheckBox = new System.Windows.Forms.CheckBox();
            this.podrMainCheckBox = new System.Windows.Forms.CheckBox();
            this.filialMainCheckBox = new System.Windows.Forms.CheckBox();
            this.catMainCheckBox = new System.Windows.Forms.CheckBox();
            this.statusMainCheckBox = new System.Windows.Forms.CheckBox();
            this.priMainCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resActionsSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.descSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.planSLASecondCheckBox = new System.Windows.Forms.CheckBox();
            this.planSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.realTimeSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.resolveTimeSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.dateOfResolveSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.toUserSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.timeToUserSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.startTimeSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.startDateSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.addressSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.podrSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.filialSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.catSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.statusSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.priSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.reasonSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.autoEnterCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priorityComboBox);
            this.groupBox1.Controls.Add(this.priorityCheckBox);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.statusCheckBox);
            this.groupBox1.Controls.Add(this.dateBeforeCheckBox);
            this.groupBox1.Controls.Add(this.dateAfterCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фильтрации";
            // 
            // priorityComboBox
            // 
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
            this.priorityComboBox.Location = new System.Drawing.Point(458, 60);
            this.priorityComboBox.MaxDropDownItems = 13;
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(200, 21);
            this.priorityComboBox.TabIndex = 5;
            // 
            // priorityCheckBox
            // 
            this.priorityCheckBox.AutoSize = true;
            this.priorityCheckBox.Location = new System.Drawing.Point(381, 64);
            this.priorityCheckBox.Name = "priorityCheckBox";
            this.priorityCheckBox.Size = new System.Drawing.Size(80, 17);
            this.priorityCheckBox.TabIndex = 4;
            this.priorityCheckBox.Text = "Приоритет";
            this.priorityCheckBox.UseVisualStyleBackColor = true;
            this.priorityCheckBox.CheckedChanged += new System.EventHandler(this.priorityCheckBox_CheckedChanged);
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
            this.statusComboBox.Location = new System.Drawing.Point(124, 60);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 21);
            this.statusComboBox.TabIndex = 3;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Checked = true;
            this.statusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusCheckBox.Location = new System.Drawing.Point(19, 64);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(99, 17);
            this.statusCheckBox.TabIndex = 2;
            this.statusCheckBox.Text = "Статус заявки";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            this.statusCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // dateBeforeCheckBox
            // 
            this.dateBeforeCheckBox.AutoSize = true;
            this.dateBeforeCheckBox.Checked = true;
            this.dateBeforeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateBeforeCheckBox.Location = new System.Drawing.Point(381, 30);
            this.dateBeforeCheckBox.Name = "dateBeforeCheckBox";
            this.dateBeforeCheckBox.Size = new System.Drawing.Size(225, 17);
            this.dateBeforeCheckBox.TabIndex = 1;
            this.dateBeforeCheckBox.Text = "Использовать дату подачи запроса, до";
            this.dateBeforeCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateAfterCheckBox
            // 
            this.dateAfterCheckBox.AutoSize = true;
            this.dateAfterCheckBox.Checked = true;
            this.dateAfterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateAfterCheckBox.Location = new System.Drawing.Point(19, 30);
            this.dateAfterCheckBox.Name = "dateAfterCheckBox";
            this.dateAfterCheckBox.Size = new System.Drawing.Size(243, 17);
            this.dateAfterCheckBox.TabIndex = 0;
            this.dateAfterCheckBox.Text = "Использовать дату подачи запроса, после";
            this.dateAfterCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resActionsMainCheckBox);
            this.groupBox2.Controls.Add(this.descMainCheckBox);
            this.groupBox2.Controls.Add(this.planSLAMainCheckBox);
            this.groupBox2.Controls.Add(this.planMainCheckBox);
            this.groupBox2.Controls.Add(this.realTimeMainCheckBox);
            this.groupBox2.Controls.Add(this.resolveTimeMainCheckBox);
            this.groupBox2.Controls.Add(this.dateOfResolveMainCheckBox);
            this.groupBox2.Controls.Add(this.toUserMainCheckBox);
            this.groupBox2.Controls.Add(this.timeToUserMainCheckBox);
            this.groupBox2.Controls.Add(this.startTimeMainCheckBox);
            this.groupBox2.Controls.Add(this.startDateMainCheckBox);
            this.groupBox2.Controls.Add(this.addressMainCheckBox);
            this.groupBox2.Controls.Add(this.podrMainCheckBox);
            this.groupBox2.Controls.Add(this.filialMainCheckBox);
            this.groupBox2.Controls.Add(this.catMainCheckBox);
            this.groupBox2.Controls.Add(this.statusMainCheckBox);
            this.groupBox2.Controls.Add(this.priMainCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видимость полей основного отчёта";
            // 
            // resActionsMainCheckBox
            // 
            this.resActionsMainCheckBox.AutoSize = true;
            this.resActionsMainCheckBox.Checked = true;
            this.resActionsMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resActionsMainCheckBox.Location = new System.Drawing.Point(9, 111);
            this.resActionsMainCheckBox.Name = "resActionsMainCheckBox";
            this.resActionsMainCheckBox.Size = new System.Drawing.Size(235, 17);
            this.resActionsMainCheckBox.TabIndex = 16;
            this.resActionsMainCheckBox.Text = "Принятые меры, причина неисправности";
            this.resActionsMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // descMainCheckBox
            // 
            this.descMainCheckBox.AutoSize = true;
            this.descMainCheckBox.Checked = true;
            this.descMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.descMainCheckBox.Location = new System.Drawing.Point(599, 88);
            this.descMainCheckBox.Name = "descMainCheckBox";
            this.descMainCheckBox.Size = new System.Drawing.Size(156, 17);
            this.descMainCheckBox.TabIndex = 15;
            this.descMainCheckBox.Text = "Описание неисправности";
            this.descMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // planSLAMainCheckBox
            // 
            this.planSLAMainCheckBox.AutoSize = true;
            this.planSLAMainCheckBox.Checked = true;
            this.planSLAMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.planSLAMainCheckBox.Location = new System.Drawing.Point(599, 65);
            this.planSLAMainCheckBox.Name = "planSLAMainCheckBox";
            this.planSLAMainCheckBox.Size = new System.Drawing.Size(134, 17);
            this.planSLAMainCheckBox.TabIndex = 14;
            this.planSLAMainCheckBox.Text = "Плановое время SLA";
            this.planSLAMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // planMainCheckBox
            // 
            this.planMainCheckBox.AutoSize = true;
            this.planMainCheckBox.Checked = true;
            this.planMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.planMainCheckBox.Location = new System.Drawing.Point(599, 42);
            this.planMainCheckBox.Name = "planMainCheckBox";
            this.planMainCheckBox.Size = new System.Drawing.Size(172, 17);
            this.planMainCheckBox.TabIndex = 13;
            this.planMainCheckBox.Text = "Плановое время устранения";
            this.planMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // realTimeMainCheckBox
            // 
            this.realTimeMainCheckBox.AutoSize = true;
            this.realTimeMainCheckBox.Checked = true;
            this.realTimeMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realTimeMainCheckBox.Location = new System.Drawing.Point(600, 19);
            this.realTimeMainCheckBox.Name = "realTimeMainCheckBox";
            this.realTimeMainCheckBox.Size = new System.Drawing.Size(171, 17);
            this.realTimeMainCheckBox.TabIndex = 12;
            this.realTimeMainCheckBox.Text = "Реальное время устранения";
            this.realTimeMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // resolveTimeMainCheckBox
            // 
            this.resolveTimeMainCheckBox.AutoSize = true;
            this.resolveTimeMainCheckBox.Checked = true;
            this.resolveTimeMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resolveTimeMainCheckBox.Location = new System.Drawing.Point(351, 88);
            this.resolveTimeMainCheckBox.Name = "resolveTimeMainCheckBox";
            this.resolveTimeMainCheckBox.Size = new System.Drawing.Size(180, 17);
            this.resolveTimeMainCheckBox.TabIndex = 11;
            this.resolveTimeMainCheckBox.Text = "Время разрешения инцидента";
            this.resolveTimeMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateOfResolveMainCheckBox
            // 
            this.dateOfResolveMainCheckBox.AutoSize = true;
            this.dateOfResolveMainCheckBox.Checked = true;
            this.dateOfResolveMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateOfResolveMainCheckBox.Location = new System.Drawing.Point(351, 65);
            this.dateOfResolveMainCheckBox.Name = "dateOfResolveMainCheckBox";
            this.dateOfResolveMainCheckBox.Size = new System.Drawing.Size(173, 17);
            this.dateOfResolveMainCheckBox.TabIndex = 10;
            this.dateOfResolveMainCheckBox.Text = "Дата разрешения инцидента";
            this.dateOfResolveMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // toUserMainCheckBox
            // 
            this.toUserMainCheckBox.AutoSize = true;
            this.toUserMainCheckBox.Checked = true;
            this.toUserMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toUserMainCheckBox.Location = new System.Drawing.Point(351, 42);
            this.toUserMainCheckBox.Name = "toUserMainCheckBox";
            this.toUserMainCheckBox.Size = new System.Drawing.Size(108, 17);
            this.toUserMainCheckBox.TabIndex = 9;
            this.toUserMainCheckBox.Text = "Кому назначено";
            this.toUserMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeToUserMainCheckBox
            // 
            this.timeToUserMainCheckBox.AutoSize = true;
            this.timeToUserMainCheckBox.Checked = true;
            this.timeToUserMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeToUserMainCheckBox.Location = new System.Drawing.Point(352, 19);
            this.timeToUserMainCheckBox.Name = "timeToUserMainCheckBox";
            this.timeToUserMainCheckBox.Size = new System.Drawing.Size(191, 17);
            this.timeToUserMainCheckBox.TabIndex = 8;
            this.timeToUserMainCheckBox.Text = "Передано исполнителю запроса";
            this.timeToUserMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // startTimeMainCheckBox
            // 
            this.startTimeMainCheckBox.AutoSize = true;
            this.startTimeMainCheckBox.Checked = true;
            this.startTimeMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startTimeMainCheckBox.Location = new System.Drawing.Point(172, 88);
            this.startTimeMainCheckBox.Name = "startTimeMainCheckBox";
            this.startTimeMainCheckBox.Size = new System.Drawing.Size(142, 17);
            this.startTimeMainCheckBox.TabIndex = 7;
            this.startTimeMainCheckBox.Text = "Время подачи запроса";
            this.startTimeMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateMainCheckBox
            // 
            this.startDateMainCheckBox.AutoSize = true;
            this.startDateMainCheckBox.Checked = true;
            this.startDateMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startDateMainCheckBox.Location = new System.Drawing.Point(172, 65);
            this.startDateMainCheckBox.Name = "startDateMainCheckBox";
            this.startDateMainCheckBox.Size = new System.Drawing.Size(135, 17);
            this.startDateMainCheckBox.TabIndex = 6;
            this.startDateMainCheckBox.Text = "Дата подачи запроса";
            this.startDateMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressMainCheckBox
            // 
            this.addressMainCheckBox.AutoSize = true;
            this.addressMainCheckBox.Checked = true;
            this.addressMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressMainCheckBox.Location = new System.Drawing.Point(172, 42);
            this.addressMainCheckBox.Name = "addressMainCheckBox";
            this.addressMainCheckBox.Size = new System.Drawing.Size(57, 17);
            this.addressMainCheckBox.TabIndex = 5;
            this.addressMainCheckBox.Text = "Адрес";
            this.addressMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // podrMainCheckBox
            // 
            this.podrMainCheckBox.AutoSize = true;
            this.podrMainCheckBox.Checked = true;
            this.podrMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.podrMainCheckBox.Location = new System.Drawing.Point(173, 19);
            this.podrMainCheckBox.Name = "podrMainCheckBox";
            this.podrMainCheckBox.Size = new System.Drawing.Size(106, 17);
            this.podrMainCheckBox.TabIndex = 4;
            this.podrMainCheckBox.Text = "Подразделение";
            this.podrMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // filialMainCheckBox
            // 
            this.filialMainCheckBox.AutoSize = true;
            this.filialMainCheckBox.Checked = true;
            this.filialMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filialMainCheckBox.Location = new System.Drawing.Point(9, 88);
            this.filialMainCheckBox.Name = "filialMainCheckBox";
            this.filialMainCheckBox.Size = new System.Drawing.Size(67, 17);
            this.filialMainCheckBox.TabIndex = 3;
            this.filialMainCheckBox.Text = "Филиал";
            this.filialMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // catMainCheckBox
            // 
            this.catMainCheckBox.AutoSize = true;
            this.catMainCheckBox.Checked = true;
            this.catMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.catMainCheckBox.Location = new System.Drawing.Point(9, 65);
            this.catMainCheckBox.Name = "catMainCheckBox";
            this.catMainCheckBox.Size = new System.Drawing.Size(124, 17);
            this.catMainCheckBox.TabIndex = 2;
            this.catMainCheckBox.Text = "Категория запроса";
            this.catMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusMainCheckBox
            // 
            this.statusMainCheckBox.AutoSize = true;
            this.statusMainCheckBox.Location = new System.Drawing.Point(9, 42);
            this.statusMainCheckBox.Name = "statusMainCheckBox";
            this.statusMainCheckBox.Size = new System.Drawing.Size(99, 17);
            this.statusMainCheckBox.TabIndex = 1;
            this.statusMainCheckBox.Text = "Статус заявки";
            this.statusMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // priMainCheckBox
            // 
            this.priMainCheckBox.AutoSize = true;
            this.priMainCheckBox.Checked = true;
            this.priMainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.priMainCheckBox.Location = new System.Drawing.Point(10, 19);
            this.priMainCheckBox.Name = "priMainCheckBox";
            this.priMainCheckBox.Size = new System.Drawing.Size(80, 17);
            this.priMainCheckBox.TabIndex = 0;
            this.priMainCheckBox.Text = "Приоритет";
            this.priMainCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resActionsSecondCheckBox);
            this.groupBox3.Controls.Add(this.descSecondCheckBox);
            this.groupBox3.Controls.Add(this.planSLASecondCheckBox);
            this.groupBox3.Controls.Add(this.planSecondCheckBox);
            this.groupBox3.Controls.Add(this.realTimeSecondCheckBox);
            this.groupBox3.Controls.Add(this.resolveTimeSecondCheckBox);
            this.groupBox3.Controls.Add(this.dateOfResolveSecondCheckBox);
            this.groupBox3.Controls.Add(this.toUserSecondCheckBox);
            this.groupBox3.Controls.Add(this.timeToUserSecondCheckBox);
            this.groupBox3.Controls.Add(this.startTimeSecondCheckBox);
            this.groupBox3.Controls.Add(this.startDateSecondCheckBox);
            this.groupBox3.Controls.Add(this.addressSecondCheckBox);
            this.groupBox3.Controls.Add(this.podrSecondCheckBox);
            this.groupBox3.Controls.Add(this.filialSecondCheckBox);
            this.groupBox3.Controls.Add(this.catSecondCheckBox);
            this.groupBox3.Controls.Add(this.statusSecondCheckBox);
            this.groupBox3.Controls.Add(this.priSecondCheckBox);
            this.groupBox3.Controls.Add(this.reasonSecondCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Видимость полей отчёта по просроченным заявкам";
            // 
            // resActionsSecondCheckBox
            // 
            this.resActionsSecondCheckBox.AutoSize = true;
            this.resActionsSecondCheckBox.Checked = true;
            this.resActionsSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resActionsSecondCheckBox.Location = new System.Drawing.Point(172, 111);
            this.resActionsSecondCheckBox.Name = "resActionsSecondCheckBox";
            this.resActionsSecondCheckBox.Size = new System.Drawing.Size(235, 17);
            this.resActionsSecondCheckBox.TabIndex = 17;
            this.resActionsSecondCheckBox.Text = "Принятые меры, причина неисправности";
            this.resActionsSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // descSecondCheckBox
            // 
            this.descSecondCheckBox.AutoSize = true;
            this.descSecondCheckBox.Checked = true;
            this.descSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.descSecondCheckBox.Location = new System.Drawing.Point(10, 111);
            this.descSecondCheckBox.Name = "descSecondCheckBox";
            this.descSecondCheckBox.Size = new System.Drawing.Size(156, 17);
            this.descSecondCheckBox.TabIndex = 16;
            this.descSecondCheckBox.Text = "Описание неисправности";
            this.descSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // planSLASecondCheckBox
            // 
            this.planSLASecondCheckBox.AutoSize = true;
            this.planSLASecondCheckBox.Checked = true;
            this.planSLASecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.planSLASecondCheckBox.Location = new System.Drawing.Point(599, 88);
            this.planSLASecondCheckBox.Name = "planSLASecondCheckBox";
            this.planSLASecondCheckBox.Size = new System.Drawing.Size(134, 17);
            this.planSLASecondCheckBox.TabIndex = 15;
            this.planSLASecondCheckBox.Text = "Плановре время SLA";
            this.planSLASecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // planSecondCheckBox
            // 
            this.planSecondCheckBox.AutoSize = true;
            this.planSecondCheckBox.Checked = true;
            this.planSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.planSecondCheckBox.Location = new System.Drawing.Point(599, 65);
            this.planSecondCheckBox.Name = "planSecondCheckBox";
            this.planSecondCheckBox.Size = new System.Drawing.Size(172, 17);
            this.planSecondCheckBox.TabIndex = 14;
            this.planSecondCheckBox.Text = "Плановое время устранения";
            this.planSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // realTimeSecondCheckBox
            // 
            this.realTimeSecondCheckBox.AutoSize = true;
            this.realTimeSecondCheckBox.Checked = true;
            this.realTimeSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realTimeSecondCheckBox.Location = new System.Drawing.Point(600, 42);
            this.realTimeSecondCheckBox.Name = "realTimeSecondCheckBox";
            this.realTimeSecondCheckBox.Size = new System.Drawing.Size(171, 17);
            this.realTimeSecondCheckBox.TabIndex = 13;
            this.realTimeSecondCheckBox.Text = "Реальное время устранения";
            this.realTimeSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // resolveTimeSecondCheckBox
            // 
            this.resolveTimeSecondCheckBox.AutoSize = true;
            this.resolveTimeSecondCheckBox.Checked = true;
            this.resolveTimeSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resolveTimeSecondCheckBox.Location = new System.Drawing.Point(600, 19);
            this.resolveTimeSecondCheckBox.Name = "resolveTimeSecondCheckBox";
            this.resolveTimeSecondCheckBox.Size = new System.Drawing.Size(180, 17);
            this.resolveTimeSecondCheckBox.TabIndex = 12;
            this.resolveTimeSecondCheckBox.Text = "Время разрешения инцидента";
            this.resolveTimeSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateOfResolveSecondCheckBox
            // 
            this.dateOfResolveSecondCheckBox.AutoSize = true;
            this.dateOfResolveSecondCheckBox.Checked = true;
            this.dateOfResolveSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateOfResolveSecondCheckBox.Location = new System.Drawing.Point(351, 88);
            this.dateOfResolveSecondCheckBox.Name = "dateOfResolveSecondCheckBox";
            this.dateOfResolveSecondCheckBox.Size = new System.Drawing.Size(173, 17);
            this.dateOfResolveSecondCheckBox.TabIndex = 11;
            this.dateOfResolveSecondCheckBox.Text = "Дата разрешения инцидента";
            this.dateOfResolveSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // toUserSecondCheckBox
            // 
            this.toUserSecondCheckBox.AutoSize = true;
            this.toUserSecondCheckBox.Checked = true;
            this.toUserSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toUserSecondCheckBox.Location = new System.Drawing.Point(351, 65);
            this.toUserSecondCheckBox.Name = "toUserSecondCheckBox";
            this.toUserSecondCheckBox.Size = new System.Drawing.Size(108, 17);
            this.toUserSecondCheckBox.TabIndex = 10;
            this.toUserSecondCheckBox.Text = "Кому назначено";
            this.toUserSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeToUserSecondCheckBox
            // 
            this.timeToUserSecondCheckBox.AutoSize = true;
            this.timeToUserSecondCheckBox.Checked = true;
            this.timeToUserSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeToUserSecondCheckBox.Location = new System.Drawing.Point(351, 42);
            this.timeToUserSecondCheckBox.Name = "timeToUserSecondCheckBox";
            this.timeToUserSecondCheckBox.Size = new System.Drawing.Size(146, 17);
            this.timeToUserSecondCheckBox.TabIndex = 9;
            this.timeToUserSecondCheckBox.Text = "Передано исполнителю";
            this.timeToUserSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // startTimeSecondCheckBox
            // 
            this.startTimeSecondCheckBox.AutoSize = true;
            this.startTimeSecondCheckBox.Checked = true;
            this.startTimeSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startTimeSecondCheckBox.Location = new System.Drawing.Point(351, 19);
            this.startTimeSecondCheckBox.Name = "startTimeSecondCheckBox";
            this.startTimeSecondCheckBox.Size = new System.Drawing.Size(142, 17);
            this.startTimeSecondCheckBox.TabIndex = 8;
            this.startTimeSecondCheckBox.Text = "Время подачи запроса";
            this.startTimeSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateSecondCheckBox
            // 
            this.startDateSecondCheckBox.AutoSize = true;
            this.startDateSecondCheckBox.Checked = true;
            this.startDateSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startDateSecondCheckBox.Location = new System.Drawing.Point(172, 88);
            this.startDateSecondCheckBox.Name = "startDateSecondCheckBox";
            this.startDateSecondCheckBox.Size = new System.Drawing.Size(135, 17);
            this.startDateSecondCheckBox.TabIndex = 7;
            this.startDateSecondCheckBox.Text = "Дата подачи запроса";
            this.startDateSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressSecondCheckBox
            // 
            this.addressSecondCheckBox.AutoSize = true;
            this.addressSecondCheckBox.Checked = true;
            this.addressSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressSecondCheckBox.Location = new System.Drawing.Point(172, 65);
            this.addressSecondCheckBox.Name = "addressSecondCheckBox";
            this.addressSecondCheckBox.Size = new System.Drawing.Size(57, 17);
            this.addressSecondCheckBox.TabIndex = 6;
            this.addressSecondCheckBox.Text = "Адрес";
            this.addressSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // podrSecondCheckBox
            // 
            this.podrSecondCheckBox.AutoSize = true;
            this.podrSecondCheckBox.Checked = true;
            this.podrSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.podrSecondCheckBox.Location = new System.Drawing.Point(172, 42);
            this.podrSecondCheckBox.Name = "podrSecondCheckBox";
            this.podrSecondCheckBox.Size = new System.Drawing.Size(106, 17);
            this.podrSecondCheckBox.TabIndex = 5;
            this.podrSecondCheckBox.Text = "Подразделение";
            this.podrSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // filialSecondCheckBox
            // 
            this.filialSecondCheckBox.AutoSize = true;
            this.filialSecondCheckBox.Checked = true;
            this.filialSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filialSecondCheckBox.Location = new System.Drawing.Point(172, 19);
            this.filialSecondCheckBox.Name = "filialSecondCheckBox";
            this.filialSecondCheckBox.Size = new System.Drawing.Size(67, 17);
            this.filialSecondCheckBox.TabIndex = 4;
            this.filialSecondCheckBox.Text = "Филиал";
            this.filialSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // catSecondCheckBox
            // 
            this.catSecondCheckBox.AutoSize = true;
            this.catSecondCheckBox.Checked = true;
            this.catSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.catSecondCheckBox.Location = new System.Drawing.Point(10, 88);
            this.catSecondCheckBox.Name = "catSecondCheckBox";
            this.catSecondCheckBox.Size = new System.Drawing.Size(124, 17);
            this.catSecondCheckBox.TabIndex = 3;
            this.catSecondCheckBox.Text = "Категория запроса";
            this.catSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusSecondCheckBox
            // 
            this.statusSecondCheckBox.AutoSize = true;
            this.statusSecondCheckBox.Location = new System.Drawing.Point(10, 65);
            this.statusSecondCheckBox.Name = "statusSecondCheckBox";
            this.statusSecondCheckBox.Size = new System.Drawing.Size(99, 17);
            this.statusSecondCheckBox.TabIndex = 2;
            this.statusSecondCheckBox.Text = "Статус заявки";
            this.statusSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // priSecondCheckBox
            // 
            this.priSecondCheckBox.AutoSize = true;
            this.priSecondCheckBox.Checked = true;
            this.priSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.priSecondCheckBox.Location = new System.Drawing.Point(10, 42);
            this.priSecondCheckBox.Name = "priSecondCheckBox";
            this.priSecondCheckBox.Size = new System.Drawing.Size(80, 17);
            this.priSecondCheckBox.TabIndex = 1;
            this.priSecondCheckBox.Text = "Приоритет";
            this.priSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // reasonSecondCheckBox
            // 
            this.reasonSecondCheckBox.AutoSize = true;
            this.reasonSecondCheckBox.Checked = true;
            this.reasonSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reasonSecondCheckBox.Location = new System.Drawing.Point(10, 19);
            this.reasonSecondCheckBox.Name = "reasonSecondCheckBox";
            this.reasonSecondCheckBox.Size = new System.Drawing.Size(152, 17);
            this.reasonSecondCheckBox.TabIndex = 0;
            this.reasonSecondCheckBox.Text = "Причина пропуска срока";
            this.reasonSecondCheckBox.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(322, 555);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(403, 555);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.autoEnterCheckBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.passTextBox);
            this.groupBox4.Controls.Add(this.logintextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.hostTextBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 92);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры подключения";
            // 
            // autoEnterCheckBox
            // 
            this.autoEnterCheckBox.AutoSize = true;
            this.autoEnterCheckBox.Location = new System.Drawing.Point(19, 24);
            this.autoEnterCheckBox.Name = "autoEnterCheckBox";
            this.autoEnterCheckBox.Size = new System.Drawing.Size(323, 17);
            this.autoEnterCheckBox.TabIndex = 7;
            this.autoEnterCheckBox.Text = "Автоматически входить с указанными учётными данными";
            this.autoEnterCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(435, 56);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(155, 20);
            this.passTextBox.TabIndex = 5;
            this.passTextBox.Text = "glpidb";
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(225, 56);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(155, 20);
            this.logintextBox.TabIndex = 3;
            this.logintextBox.Text = "glpidb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(53, 56);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostTextBox.TabIndex = 1;
            this.hostTextBox.Text = "10.164.30.34";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хост";
            // 
            // MainSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainSettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.CheckBox dateBeforeCheckBox;
        private System.Windows.Forms.CheckBox dateAfterCheckBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.CheckBox priorityCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox resActionsMainCheckBox;
        private System.Windows.Forms.CheckBox descMainCheckBox;
        private System.Windows.Forms.CheckBox planSLAMainCheckBox;
        private System.Windows.Forms.CheckBox planMainCheckBox;
        private System.Windows.Forms.CheckBox realTimeMainCheckBox;
        private System.Windows.Forms.CheckBox resolveTimeMainCheckBox;
        private System.Windows.Forms.CheckBox dateOfResolveMainCheckBox;
        private System.Windows.Forms.CheckBox toUserMainCheckBox;
        private System.Windows.Forms.CheckBox timeToUserMainCheckBox;
        private System.Windows.Forms.CheckBox startTimeMainCheckBox;
        private System.Windows.Forms.CheckBox startDateMainCheckBox;
        private System.Windows.Forms.CheckBox addressMainCheckBox;
        private System.Windows.Forms.CheckBox podrMainCheckBox;
        private System.Windows.Forms.CheckBox filialMainCheckBox;
        private System.Windows.Forms.CheckBox catMainCheckBox;
        private System.Windows.Forms.CheckBox statusMainCheckBox;
        private System.Windows.Forms.CheckBox priMainCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox startDateSecondCheckBox;
        private System.Windows.Forms.CheckBox addressSecondCheckBox;
        private System.Windows.Forms.CheckBox podrSecondCheckBox;
        private System.Windows.Forms.CheckBox filialSecondCheckBox;
        private System.Windows.Forms.CheckBox catSecondCheckBox;
        private System.Windows.Forms.CheckBox statusSecondCheckBox;
        private System.Windows.Forms.CheckBox priSecondCheckBox;
        private System.Windows.Forms.CheckBox reasonSecondCheckBox;
        private System.Windows.Forms.CheckBox resActionsSecondCheckBox;
        private System.Windows.Forms.CheckBox descSecondCheckBox;
        private System.Windows.Forms.CheckBox planSLASecondCheckBox;
        private System.Windows.Forms.CheckBox planSecondCheckBox;
        private System.Windows.Forms.CheckBox realTimeSecondCheckBox;
        private System.Windows.Forms.CheckBox resolveTimeSecondCheckBox;
        private System.Windows.Forms.CheckBox dateOfResolveSecondCheckBox;
        private System.Windows.Forms.CheckBox toUserSecondCheckBox;
        private System.Windows.Forms.CheckBox timeToUserSecondCheckBox;
        private System.Windows.Forms.CheckBox startTimeSecondCheckBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.CheckBox autoEnterCheckBox;
    }
}