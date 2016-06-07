namespace Course
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet1 = new Course.CourseDataSet1();
            this.courseDataSet = new Course.CourseDataSet();
            this.находкиTableAdapter = new Course.CourseDataSetTableAdapters.НаходкиTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учетнаяЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateChangesButton = new System.Windows.Forms.Button();
            this.FilterName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FilterDescription = new System.Windows.Forms.TextBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FilterFIO = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FilterPhone = new System.Windows.Forms.TextBox();
            this.FilterFoundTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.FoundTimeLabel = new System.Windows.Forms.Label();
            this.RegTimeLabel = new System.Windows.Forms.Label();
            this.FilterRegTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.FilterFoundTimeTo = new System.Windows.Forms.DateTimePicker();
            this.FilterRegTimeTo = new System.Windows.Forms.DateTimePicker();
            this.FilterSwitchButton = new System.Windows.Forms.Button();
            this.CheckBoxName = new System.Windows.Forms.CheckBox();
            this.CheckBoxDescription = new System.Windows.Forms.CheckBox();
            this.CheckBoxFIO = new System.Windows.Forms.CheckBox();
            this.CheckBoxPhone = new System.Windows.Forms.CheckBox();
            this.CheckBoxFoundTime = new System.Windows.Forms.CheckBox();
            this.CheckBoxRegTime = new System.Windows.Forms.CheckBox();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.находкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.находкиTableAdapter1 = new Course.CourseDataSet1TableAdapters.НаходкиTableAdapter();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяНаходкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоНаходкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostTable = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяНаходкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоНаходкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяРегистрацииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterSpot = new System.Windows.Forms.TextBox();
            this.CheckBoxSpot = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.находкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.courseDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // courseDataSet1
            // 
            this.courseDataSet1.DataSetName = "CourseDataSet1";
            this.courseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "CourseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // находкиTableAdapter
            // 
            this.находкиTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетнаяЗаписьToolStripMenuItem,
            this.режимРаботыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учетнаяЗаписьToolStripMenuItem
            // 
            this.учетнаяЗаписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.учетнаяЗаписьToolStripMenuItem.Name = "учетнаяЗаписьToolStripMenuItem";
            this.учетнаяЗаписьToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.учетнаяЗаписьToolStripMenuItem.Text = "Учетная запись";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // режимРаботыToolStripMenuItem
            // 
            this.режимРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.режимРаботыToolStripMenuItem.Name = "режимРаботыToolStripMenuItem";
            this.режимРаботыToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.режимРаботыToolStripMenuItem.Text = "Режим работы [Просмотр]";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            this.редактированиеToolStripMenuItem.Click += new System.EventHandler(this.редактированиеToolStripMenuItem_Click);
            // 
            // UpdateChangesButton
            // 
            this.UpdateChangesButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateChangesButton.Location = new System.Drawing.Point(951, 313);
            this.UpdateChangesButton.Name = "UpdateChangesButton";
            this.UpdateChangesButton.Size = new System.Drawing.Size(78, 50);
            this.UpdateChangesButton.TabIndex = 2;
            this.UpdateChangesButton.Text = "Сохранить изменения";
            this.UpdateChangesButton.UseVisualStyleBackColor = true;
            this.UpdateChangesButton.Click += new System.EventHandler(this.UpdateChangesButtonClick);
            // 
            // FilterName
            // 
            this.FilterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterName.Location = new System.Drawing.Point(12, 44);
            this.FilterName.MaxLength = 64;
            this.FilterName.Name = "FilterName";
            this.FilterName.Size = new System.Drawing.Size(80, 22);
            this.FilterName.TabIndex = 3;
            this.FilterName.TextChanged += new System.EventHandler(this.FilterNameTextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(23, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 14);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Название";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(166, 27);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 14);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Описание";
            // 
            // FilterDescription
            // 
            this.FilterDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterDescription.Location = new System.Drawing.Point(98, 44);
            this.FilterDescription.MaxLength = 256;
            this.FilterDescription.Name = "FilterDescription";
            this.FilterDescription.Size = new System.Drawing.Size(200, 22);
            this.FilterDescription.TabIndex = 5;
            this.FilterDescription.WordWrap = false;
            this.FilterDescription.TextChanged += new System.EventHandler(this.FilterDescriptionTextChanged);
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(355, 27);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(100, 14);
            this.FIOLabel.TabIndex = 8;
            this.FIOLabel.Text = "ФИО нашедшего";
            // 
            // FilterFIO
            // 
            this.FilterFIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterFIO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFIO.Location = new System.Drawing.Point(304, 44);
            this.FilterFIO.MaxLength = 256;
            this.FilterFIO.Name = "FilterFIO";
            this.FilterFIO.Size = new System.Drawing.Size(200, 22);
            this.FilterFIO.TabIndex = 7;
            this.FilterFIO.WordWrap = false;
            this.FilterFIO.TextChanged += new System.EventHandler(this.FilterFIOTextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(518, 27);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(60, 14);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "Телефон";
            // 
            // FilterPhone
            // 
            this.FilterPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterPhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterPhone.Location = new System.Drawing.Point(510, 44);
            this.FilterPhone.MaxLength = 64;
            this.FilterPhone.Name = "FilterPhone";
            this.FilterPhone.Size = new System.Drawing.Size(80, 22);
            this.FilterPhone.TabIndex = 9;
            this.FilterPhone.TextChanged += new System.EventHandler(this.FilterPhoneTextChanged);
            // 
            // FilterFoundTimeFrom
            // 
            this.FilterFoundTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterFoundTimeFrom.Location = new System.Drawing.Point(682, 44);
            this.FilterFoundTimeFrom.Name = "FilterFoundTimeFrom";
            this.FilterFoundTimeFrom.Size = new System.Drawing.Size(75, 20);
            this.FilterFoundTimeFrom.TabIndex = 11;
            this.FilterFoundTimeFrom.ValueChanged += new System.EventHandler(this.FilterFoundTimeFromValueChanged);
            // 
            // FoundTimeLabel
            // 
            this.FoundTimeLabel.AutoSize = true;
            this.FoundTimeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoundTimeLabel.Location = new System.Drawing.Point(708, 27);
            this.FoundTimeLabel.Name = "FoundTimeLabel";
            this.FoundTimeLabel.Size = new System.Drawing.Size(93, 14);
            this.FoundTimeLabel.TabIndex = 12;
            this.FoundTimeLabel.Text = "Время находки";
            // 
            // RegTimeLabel
            // 
            this.RegTimeLabel.AutoSize = true;
            this.RegTimeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegTimeLabel.Location = new System.Drawing.Point(858, 27);
            this.RegTimeLabel.Name = "RegTimeLabel";
            this.RegTimeLabel.Size = new System.Drawing.Size(119, 14);
            this.RegTimeLabel.TabIndex = 14;
            this.RegTimeLabel.Text = "Время регистрации";
            // 
            // FilterRegTimeFrom
            // 
            this.FilterRegTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterRegTimeFrom.Location = new System.Drawing.Point(844, 44);
            this.FilterRegTimeFrom.Name = "FilterRegTimeFrom";
            this.FilterRegTimeFrom.Size = new System.Drawing.Size(75, 20);
            this.FilterRegTimeFrom.TabIndex = 13;
            this.FilterRegTimeFrom.ValueChanged += new System.EventHandler(this.FilterRegTimeFromValueChanged);
            // 
            // FilterFoundTimeTo
            // 
            this.FilterFoundTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterFoundTimeTo.Location = new System.Drawing.Point(763, 44);
            this.FilterFoundTimeTo.Name = "FilterFoundTimeTo";
            this.FilterFoundTimeTo.Size = new System.Drawing.Size(75, 20);
            this.FilterFoundTimeTo.TabIndex = 15;
            this.FilterFoundTimeTo.ValueChanged += new System.EventHandler(this.FilterFoundTimeToValueChanged);
            // 
            // FilterRegTimeTo
            // 
            this.FilterRegTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterRegTimeTo.Location = new System.Drawing.Point(925, 44);
            this.FilterRegTimeTo.Name = "FilterRegTimeTo";
            this.FilterRegTimeTo.Size = new System.Drawing.Size(75, 20);
            this.FilterRegTimeTo.TabIndex = 16;
            this.FilterRegTimeTo.ValueChanged += new System.EventHandler(this.FilterRegTimeToValueChanged);
            // 
            // FilterSwitchButton
            // 
            this.FilterSwitchButton.Location = new System.Drawing.Point(918, 69);
            this.FilterSwitchButton.Name = "FilterSwitchButton";
            this.FilterSwitchButton.Size = new System.Drawing.Size(70, 22);
            this.FilterSwitchButton.TabIndex = 17;
            this.FilterSwitchButton.Text = "Фильтр";
            this.FilterSwitchButton.UseVisualStyleBackColor = true;
            this.FilterSwitchButton.Click += new System.EventHandler(this.FilterSwitchButtonClick);
            // 
            // CheckBoxName
            // 
            this.CheckBoxName.AutoSize = true;
            this.CheckBoxName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxName.Location = new System.Drawing.Point(918, 97);
            this.CheckBoxName.Name = "CheckBoxName";
            this.CheckBoxName.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxName.TabIndex = 18;
            this.CheckBoxName.Text = "По названию";
            this.CheckBoxName.UseVisualStyleBackColor = true;
            this.CheckBoxName.CheckStateChanged += new System.EventHandler(this.CheckBoxNameStateChanged);
            // 
            // CheckBoxDescription
            // 
            this.CheckBoxDescription.AutoSize = true;
            this.CheckBoxDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxDescription.Location = new System.Drawing.Point(918, 115);
            this.CheckBoxDescription.Name = "CheckBoxDescription";
            this.CheckBoxDescription.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxDescription.TabIndex = 19;
            this.CheckBoxDescription.Text = "По описанию";
            this.CheckBoxDescription.UseVisualStyleBackColor = true;
            this.CheckBoxDescription.CheckStateChanged += new System.EventHandler(this.CheckBoxDescriptionStateChanged);
            // 
            // CheckBoxFIO
            // 
            this.CheckBoxFIO.AutoSize = true;
            this.CheckBoxFIO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxFIO.Location = new System.Drawing.Point(918, 133);
            this.CheckBoxFIO.Name = "CheckBoxFIO";
            this.CheckBoxFIO.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxFIO.TabIndex = 20;
            this.CheckBoxFIO.Text = "По ФИО";
            this.CheckBoxFIO.UseVisualStyleBackColor = true;
            this.CheckBoxFIO.CheckStateChanged += new System.EventHandler(this.CheckBoxFIOStateChanged);
            // 
            // CheckBoxPhone
            // 
            this.CheckBoxPhone.AutoSize = true;
            this.CheckBoxPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPhone.Location = new System.Drawing.Point(918, 152);
            this.CheckBoxPhone.Name = "CheckBoxPhone";
            this.CheckBoxPhone.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxPhone.TabIndex = 21;
            this.CheckBoxPhone.Text = "По телефону";
            this.CheckBoxPhone.UseVisualStyleBackColor = true;
            this.CheckBoxPhone.CheckStateChanged += new System.EventHandler(this.CheckBoxPhoneStateChanged);
            // 
            // CheckBoxFoundTime
            // 
            this.CheckBoxFoundTime.AutoSize = true;
            this.CheckBoxFoundTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxFoundTime.Location = new System.Drawing.Point(918, 189);
            this.CheckBoxFoundTime.Name = "CheckBoxFoundTime";
            this.CheckBoxFoundTime.Size = new System.Drawing.Size(130, 17);
            this.CheckBoxFoundTime.TabIndex = 22;
            this.CheckBoxFoundTime.Text = "По времени находки";
            this.CheckBoxFoundTime.UseVisualStyleBackColor = true;
            this.CheckBoxFoundTime.CheckStateChanged += new System.EventHandler(this.CheckBoxFoundTimeStateChanged);
            // 
            // CheckBoxRegTime
            // 
            this.CheckBoxRegTime.AutoSize = true;
            this.CheckBoxRegTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxRegTime.Location = new System.Drawing.Point(918, 207);
            this.CheckBoxRegTime.Name = "CheckBoxRegTime";
            this.CheckBoxRegTime.Size = new System.Drawing.Size(151, 17);
            this.CheckBoxRegTime.TabIndex = 23;
            this.CheckBoxRegTime.Text = "По времени регистрации";
            this.CheckBoxRegTime.UseVisualStyleBackColor = true;
            this.CheckBoxRegTime.CheckStateChanged += new System.EventHandler(this.CheckBoxRegTimeStateChanged);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 52;
            // 
            // находкиBindingSource
            // 
            this.находкиBindingSource.DataMember = "Находки";
            this.находкиBindingSource.DataSource = this.bindingSource1;
            // 
            // находкиTableAdapter1
            // 
            this.находкиTableAdapter1.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn1.Width = 52;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 80;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.Width = 81;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 55;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонDataGridViewTextBoxColumn.Width = 76;
            // 
            // времяНаходкиDataGridViewTextBoxColumn
            // 
            this.времяНаходкиDataGridViewTextBoxColumn.DataPropertyName = "Время находки";
            this.времяНаходкиDataGridViewTextBoxColumn.HeaderText = "Время находки";
            this.времяНаходкиDataGridViewTextBoxColumn.Name = "времяНаходкиDataGridViewTextBoxColumn";
            this.времяНаходкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяНаходкиDataGridViewTextBoxColumn.Width = 99;
            // 
            // местоНаходкиDataGridViewTextBoxColumn
            // 
            this.местоНаходкиDataGridViewTextBoxColumn.DataPropertyName = "Место находки";
            this.местоНаходкиDataGridViewTextBoxColumn.HeaderText = "Место находки";
            this.местоНаходкиDataGridViewTextBoxColumn.Name = "местоНаходкиDataGridViewTextBoxColumn";
            this.местоНаходкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // времяРегистрацииDataGridViewTextBoxColumn
            // 
            this.времяРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Время регистрации";
            this.времяРегистрацииDataGridViewTextBoxColumn.HeaderText = "Время регистрации";
            this.времяРегистрацииDataGridViewTextBoxColumn.Name = "времяРегистрацииDataGridViewTextBoxColumn";
            this.времяРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяРегистрацииDataGridViewTextBoxColumn.Width = 118;
            // 
            // LostTable
            // 
            this.LostTable.AllowUserToAddRows = false;
            this.LostTable.AllowUserToDeleteRows = false;
            this.LostTable.AllowUserToResizeColumns = false;
            this.LostTable.AllowUserToResizeRows = false;
            this.LostTable.AutoGenerateColumns = false;
            this.LostTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LostTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LostTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn2,
            this.названиеDataGridViewTextBoxColumn1,
            this.описаниеDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn1,
            this.телефонDataGridViewTextBoxColumn1,
            this.времяНаходкиDataGridViewTextBoxColumn1,
            this.местоНаходкиDataGridViewTextBoxColumn1,
            this.времяРегистрацииDataGridViewTextBoxColumn1});
            this.LostTable.DataSource = this.находкиBindingSource;
            this.LostTable.Location = new System.Drawing.Point(12, 70);
            this.LostTable.Name = "LostTable";
            this.LostTable.ReadOnly = true;
            this.LostTable.Size = new System.Drawing.Size(900, 284);
            this.LostTable.TabIndex = 24;
            // 
            // кодDataGridViewTextBoxColumn2
            // 
            this.кодDataGridViewTextBoxColumn2.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn2.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn2.Name = "кодDataGridViewTextBoxColumn2";
            this.кодDataGridViewTextBoxColumn2.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn2.Width = 51;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn1.Width = 82;
            // 
            // описаниеDataGridViewTextBoxColumn1
            // 
            this.описаниеDataGridViewTextBoxColumn1.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn1.Name = "описаниеDataGridViewTextBoxColumn1";
            this.описаниеDataGridViewTextBoxColumn1.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn1.Width = 82;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn1.Width = 59;
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            this.телефонDataGridViewTextBoxColumn1.ReadOnly = true;
            this.телефонDataGridViewTextBoxColumn1.Width = 77;
            // 
            // времяНаходкиDataGridViewTextBoxColumn1
            // 
            this.времяНаходкиDataGridViewTextBoxColumn1.DataPropertyName = "Время находки";
            this.времяНаходкиDataGridViewTextBoxColumn1.HeaderText = "Время находки";
            this.времяНаходкиDataGridViewTextBoxColumn1.Name = "времяНаходкиDataGridViewTextBoxColumn1";
            this.времяНаходкиDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // местоНаходкиDataGridViewTextBoxColumn1
            // 
            this.местоНаходкиDataGridViewTextBoxColumn1.DataPropertyName = "Место находки";
            this.местоНаходкиDataGridViewTextBoxColumn1.HeaderText = "Место находки";
            this.местоНаходкиDataGridViewTextBoxColumn1.Name = "местоНаходкиDataGridViewTextBoxColumn1";
            this.местоНаходкиDataGridViewTextBoxColumn1.ReadOnly = true;
            this.местоНаходкиDataGridViewTextBoxColumn1.Width = 99;
            // 
            // времяРегистрацииDataGridViewTextBoxColumn1
            // 
            this.времяРегистрацииDataGridViewTextBoxColumn1.DataPropertyName = "Время регистрации";
            this.времяРегистрацииDataGridViewTextBoxColumn1.HeaderText = "Время регистрации";
            this.времяРегистрацииDataGridViewTextBoxColumn1.Name = "времяРегистрацииDataGridViewTextBoxColumn1";
            this.времяРегистрацииDataGridViewTextBoxColumn1.ReadOnly = true;
            this.времяРегистрацииDataGridViewTextBoxColumn1.Width = 121;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Пропажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LostsButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(606, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Место";
            // 
            // FilterSpot
            // 
            this.FilterSpot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterSpot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterSpot.Location = new System.Drawing.Point(596, 44);
            this.FilterSpot.MaxLength = 64;
            this.FilterSpot.Name = "FilterSpot";
            this.FilterSpot.Size = new System.Drawing.Size(80, 22);
            this.FilterSpot.TabIndex = 26;
            this.FilterSpot.TextChanged += new System.EventHandler(this.FilterSpotTextChanged);
            // 
            // CheckBoxSpot
            // 
            this.CheckBoxSpot.AutoSize = true;
            this.CheckBoxSpot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxSpot.Location = new System.Drawing.Point(918, 171);
            this.CheckBoxSpot.Name = "CheckBoxSpot";
            this.CheckBoxSpot.Size = new System.Drawing.Size(71, 17);
            this.CheckBoxSpot.TabIndex = 28;
            this.CheckBoxSpot.Text = "По месту";
            this.CheckBoxSpot.UseVisualStyleBackColor = true;
            this.CheckBoxSpot.CheckedChanged += new System.EventHandler(this.CheckBoxSpotCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 416);
            this.Controls.Add(this.CheckBoxSpot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterSpot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LostTable);
            this.Controls.Add(this.CheckBoxRegTime);
            this.Controls.Add(this.CheckBoxFoundTime);
            this.Controls.Add(this.CheckBoxPhone);
            this.Controls.Add(this.CheckBoxFIO);
            this.Controls.Add(this.CheckBoxDescription);
            this.Controls.Add(this.CheckBoxName);
            this.Controls.Add(this.FilterSwitchButton);
            this.Controls.Add(this.FilterRegTimeTo);
            this.Controls.Add(this.FilterFoundTimeTo);
            this.Controls.Add(this.RegTimeLabel);
            this.Controls.Add(this.FilterRegTimeFrom);
            this.Controls.Add(this.FoundTimeLabel);
            this.Controls.Add(this.FilterFoundTimeFrom);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.FilterPhone);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.FilterFIO);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.FilterDescription);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FilterName);
            this.Controls.Add(this.UpdateChangesButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Находки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.находкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private CourseDataSet courseDataSet;
        private System.Windows.Forms.DataGridView FindsTable;
        private CourseDataSetTableAdapters.НаходкиTableAdapter находкиTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учетнаяЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.Button UpdateChangesButton;
        private System.Windows.Forms.TextBox FilterName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox FilterDescription;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox FilterFIO;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox FilterPhone;
        private System.Windows.Forms.DateTimePicker FilterFoundTimeFrom;
        private System.Windows.Forms.Label FoundTimeLabel;
        private System.Windows.Forms.Label RegTimeLabel;
        private System.Windows.Forms.DateTimePicker FilterRegTimeFrom;
        private System.Windows.Forms.DateTimePicker FilterFoundTimeTo;
        private System.Windows.Forms.DateTimePicker FilterRegTimeTo;
        private System.Windows.Forms.Button FilterSwitchButton;
        private System.Windows.Forms.CheckBox CheckBoxName;
        private System.Windows.Forms.CheckBox CheckBoxDescription;
        private System.Windows.Forms.CheckBox CheckBoxFIO;
        private System.Windows.Forms.CheckBox CheckBoxPhone;
        private System.Windows.Forms.CheckBox CheckBoxFoundTime;
        private System.Windows.Forms.CheckBox CheckBoxRegTime;
        private CourseDataSet1 courseDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource находкиBindingSource;
        private CourseDataSet1TableAdapters.НаходкиTableAdapter находкиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяНаходкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоНаходкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView LostTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяНаходкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоНаходкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяРегистрацииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterSpot;
        private System.Windows.Forms.CheckBox CheckBoxSpot;
    }
}

