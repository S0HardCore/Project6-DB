namespace Course
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.потериTableAdapter1 = new Course.CourseDataSet1TableAdapters.ПотериTableAdapter();
            this.LostsTable = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПотериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПотериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОбращенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.находкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet11 = new Course.CourseDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учетнаяЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateChangesButton = new System.Windows.Forms.Button();
            this.CheckBoxSpot = new System.Windows.Forms.CheckBox();
            this.CheckBoxRegTime = new System.Windows.Forms.CheckBox();
            this.CheckBoxFoundTime = new System.Windows.Forms.CheckBox();
            this.CheckBoxPhone = new System.Windows.Forms.CheckBox();
            this.CheckBoxFIO = new System.Windows.Forms.CheckBox();
            this.CheckBoxDescription = new System.Windows.Forms.CheckBox();
            this.CheckBoxName = new System.Windows.Forms.CheckBox();
            this.FilterSwitchButton = new System.Windows.Forms.Button();
            this.SpotLabel = new System.Windows.Forms.Label();
            this.FilterSpot = new System.Windows.Forms.TextBox();
            this.FilterRegTimeTo = new System.Windows.Forms.DateTimePicker();
            this.FilterFoundTimeTo = new System.Windows.Forms.DateTimePicker();
            this.RegTimeLabel = new System.Windows.Forms.Label();
            this.FilterRegTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.FoundTimeLabel = new System.Windows.Forms.Label();
            this.FilterFoundTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FilterPhone = new System.Windows.Forms.TextBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FilterFIO = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FilterDescription = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FilterName = new System.Windows.Forms.TextBox();
            this.FormSwitchButton = new System.Windows.Forms.Button();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LostsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.находкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet11)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // потериTableAdapter1
            // 
            this.потериTableAdapter1.ClearBeforeFill = true;
            // 
            // LostsTable
            // 
            this.LostsTable.AllowUserToAddRows = false;
            this.LostsTable.AllowUserToDeleteRows = false;
            this.LostsTable.AllowUserToResizeColumns = false;
            this.LostsTable.AllowUserToResizeRows = false;
            this.LostsTable.AutoGenerateColumns = false;
            this.LostsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LostsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LostsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.местоПотериDataGridViewTextBoxColumn,
            this.времяПотериDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.времяОбращенияDataGridViewTextBoxColumn});
            this.LostsTable.DataSource = this.находкиBindingSource;
            this.LostsTable.Location = new System.Drawing.Point(12, 70);
            this.LostsTable.Name = "LostsTable";
            this.LostsTable.ReadOnly = true;
            this.LostsTable.Size = new System.Drawing.Size(900, 284);
            this.LostsTable.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 53;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 84;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.Width = 88;
            // 
            // местоПотериDataGridViewTextBoxColumn
            // 
            this.местоПотериDataGridViewTextBoxColumn.DataPropertyName = "Место потери";
            this.местоПотериDataGridViewTextBoxColumn.HeaderText = "Место потери";
            this.местоПотериDataGridViewTextBoxColumn.Name = "местоПотериDataGridViewTextBoxColumn";
            this.местоПотериDataGridViewTextBoxColumn.ReadOnly = true;
            this.местоПотериDataGridViewTextBoxColumn.Width = 103;
            // 
            // времяПотериDataGridViewTextBoxColumn
            // 
            this.времяПотериDataGridViewTextBoxColumn.DataPropertyName = "Время потери";
            this.времяПотериDataGridViewTextBoxColumn.HeaderText = "Время потери";
            this.времяПотериDataGridViewTextBoxColumn.Name = "времяПотериDataGridViewTextBoxColumn";
            this.времяПотериDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяПотериDataGridViewTextBoxColumn.Width = 104;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 59;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонDataGridViewTextBoxColumn.Width = 85;
            // 
            // времяОбращенияDataGridViewTextBoxColumn
            // 
            this.времяОбращенияDataGridViewTextBoxColumn.DataPropertyName = "Время обращения";
            this.времяОбращенияDataGridViewTextBoxColumn.HeaderText = "Время обращения";
            this.времяОбращенияDataGridViewTextBoxColumn.Name = "времяОбращенияDataGridViewTextBoxColumn";
            this.времяОбращенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяОбращенияDataGridViewTextBoxColumn.Width = 124;
            // 
            // находкиBindingSource
            // 
            this.находкиBindingSource.DataMember = "Потери";
            this.находкиBindingSource.DataSource = this.courseDataSet11;
            // 
            // courseDataSet11
            // 
            this.courseDataSet11.DataSetName = "CourseDataSet1";
            this.courseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетнаяЗаписьToolStripMenuItem,
            this.режимРаботыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учетнаяЗаписьToolStripMenuItem
            // 
            this.учетнаяЗаписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.логToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.учетнаяЗаписьToolStripMenuItem.Name = "учетнаяЗаписьToolStripMenuItem";
            this.учетнаяЗаписьToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.учетнаяЗаписьToolStripMenuItem.Text = "Учетная запись";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItemClick);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.UpdateChangesButton.Location = new System.Drawing.Point(951, 305);
            this.UpdateChangesButton.Name = "UpdateChangesButton";
            this.UpdateChangesButton.Size = new System.Drawing.Size(78, 50);
            this.UpdateChangesButton.TabIndex = 3;
            this.UpdateChangesButton.Text = "Сохранить изменения";
            this.UpdateChangesButton.UseVisualStyleBackColor = true;
            this.UpdateChangesButton.Click += new System.EventHandler(this.UpdateChangesButtonClick);
            // 
            // CheckBoxSpot
            // 
            this.CheckBoxSpot.AutoSize = true;
            this.CheckBoxSpot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxSpot.Location = new System.Drawing.Point(918, 152);
            this.CheckBoxSpot.Name = "CheckBoxSpot";
            this.CheckBoxSpot.Size = new System.Drawing.Size(110, 17);
            this.CheckBoxSpot.TabIndex = 36;
            this.CheckBoxSpot.Text = "По месту потери";
            this.CheckBoxSpot.UseVisualStyleBackColor = true;
            this.CheckBoxSpot.CheckStateChanged += new System.EventHandler(this.CheckBoxSpotStateChanged);
            // 
            // CheckBoxRegTime
            // 
            this.CheckBoxRegTime.AutoSize = true;
            this.CheckBoxRegTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxRegTime.Location = new System.Drawing.Point(918, 206);
            this.CheckBoxRegTime.Name = "CheckBoxRegTime";
            this.CheckBoxRegTime.Size = new System.Drawing.Size(144, 17);
            this.CheckBoxRegTime.TabIndex = 35;
            this.CheckBoxRegTime.Text = "По времени обращения";
            this.CheckBoxRegTime.UseVisualStyleBackColor = true;
            this.CheckBoxRegTime.CheckStateChanged += new System.EventHandler(this.CheckBoxRegTimeStateChanged);
            // 
            // CheckBoxFoundTime
            // 
            this.CheckBoxFoundTime.AutoSize = true;
            this.CheckBoxFoundTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxFoundTime.Location = new System.Drawing.Point(918, 188);
            this.CheckBoxFoundTime.Name = "CheckBoxFoundTime";
            this.CheckBoxFoundTime.Size = new System.Drawing.Size(123, 17);
            this.CheckBoxFoundTime.TabIndex = 34;
            this.CheckBoxFoundTime.Text = "По времени потери";
            this.CheckBoxFoundTime.UseVisualStyleBackColor = true;
            this.CheckBoxFoundTime.CheckStateChanged += new System.EventHandler(this.CheckBoxFoundTimeStateChanged);
            // 
            // CheckBoxPhone
            // 
            this.CheckBoxPhone.AutoSize = true;
            this.CheckBoxPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPhone.Location = new System.Drawing.Point(918, 170);
            this.CheckBoxPhone.Name = "CheckBoxPhone";
            this.CheckBoxPhone.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxPhone.TabIndex = 33;
            this.CheckBoxPhone.Text = "По телефону";
            this.CheckBoxPhone.UseVisualStyleBackColor = true;
            this.CheckBoxPhone.CheckStateChanged += new System.EventHandler(this.CheckBoxPhoneStateChanged);
            // 
            // CheckBoxFIO
            // 
            this.CheckBoxFIO.AutoSize = true;
            this.CheckBoxFIO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxFIO.Location = new System.Drawing.Point(918, 134);
            this.CheckBoxFIO.Name = "CheckBoxFIO";
            this.CheckBoxFIO.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxFIO.TabIndex = 32;
            this.CheckBoxFIO.Text = "По ФИО";
            this.CheckBoxFIO.UseVisualStyleBackColor = true;
            this.CheckBoxFIO.CheckStateChanged += new System.EventHandler(this.CheckBoxFIOStateChanged);
            // 
            // CheckBoxDescription
            // 
            this.CheckBoxDescription.AutoSize = true;
            this.CheckBoxDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxDescription.Location = new System.Drawing.Point(918, 116);
            this.CheckBoxDescription.Name = "CheckBoxDescription";
            this.CheckBoxDescription.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxDescription.TabIndex = 31;
            this.CheckBoxDescription.Text = "По описанию";
            this.CheckBoxDescription.UseVisualStyleBackColor = true;
            this.CheckBoxDescription.CheckStateChanged += new System.EventHandler(this.CheckBoxDescriptionStateChanged);
            // 
            // CheckBoxName
            // 
            this.CheckBoxName.AutoSize = true;
            this.CheckBoxName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxName.Location = new System.Drawing.Point(918, 98);
            this.CheckBoxName.Name = "CheckBoxName";
            this.CheckBoxName.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxName.TabIndex = 30;
            this.CheckBoxName.Text = "По названию";
            this.CheckBoxName.UseVisualStyleBackColor = true;
            this.CheckBoxName.CheckStateChanged += new System.EventHandler(this.CheckBoxNameStateChanged);
            // 
            // FilterSwitchButton
            // 
            this.FilterSwitchButton.Location = new System.Drawing.Point(918, 70);
            this.FilterSwitchButton.Name = "FilterSwitchButton";
            this.FilterSwitchButton.Size = new System.Drawing.Size(70, 22);
            this.FilterSwitchButton.TabIndex = 29;
            this.FilterSwitchButton.Text = "Фильтр";
            this.FilterSwitchButton.UseVisualStyleBackColor = true;
            this.FilterSwitchButton.Click += new System.EventHandler(this.FilterSwitchButtonClick);
            // 
            // SpotLabel
            // 
            this.SpotLabel.AutoSize = true;
            this.SpotLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpotLabel.Location = new System.Drawing.Point(606, 25);
            this.SpotLabel.Name = "SpotLabel";
            this.SpotLabel.Size = new System.Drawing.Size(42, 14);
            this.SpotLabel.TabIndex = 52;
            this.SpotLabel.Text = "Место";
            // 
            // FilterSpot
            // 
            this.FilterSpot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterSpot.Location = new System.Drawing.Point(596, 42);
            this.FilterSpot.MaxLength = 64;
            this.FilterSpot.Name = "FilterSpot";
            this.FilterSpot.Size = new System.Drawing.Size(80, 22);
            this.FilterSpot.TabIndex = 51;
            this.FilterSpot.TextChanged += new System.EventHandler(this.FilterSpotTextChanged);
            // 
            // FilterRegTimeTo
            // 
            this.FilterRegTimeTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterRegTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterRegTimeTo.Location = new System.Drawing.Point(925, 42);
            this.FilterRegTimeTo.Name = "FilterRegTimeTo";
            this.FilterRegTimeTo.Size = new System.Drawing.Size(75, 21);
            this.FilterRegTimeTo.TabIndex = 50;
            this.FilterRegTimeTo.ValueChanged += new System.EventHandler(this.FilterRegTimeToValueChanged);
            // 
            // FilterFoundTimeTo
            // 
            this.FilterFoundTimeTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFoundTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterFoundTimeTo.Location = new System.Drawing.Point(763, 42);
            this.FilterFoundTimeTo.Name = "FilterFoundTimeTo";
            this.FilterFoundTimeTo.Size = new System.Drawing.Size(75, 21);
            this.FilterFoundTimeTo.TabIndex = 49;
            this.FilterFoundTimeTo.ValueChanged += new System.EventHandler(this.FilterFoundTimeToValueChanged);
            // 
            // RegTimeLabel
            // 
            this.RegTimeLabel.AutoSize = true;
            this.RegTimeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegTimeLabel.Location = new System.Drawing.Point(858, 25);
            this.RegTimeLabel.Name = "RegTimeLabel";
            this.RegTimeLabel.Size = new System.Drawing.Size(111, 14);
            this.RegTimeLabel.TabIndex = 48;
            this.RegTimeLabel.Text = "Время обращения";
            // 
            // FilterRegTimeFrom
            // 
            this.FilterRegTimeFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterRegTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterRegTimeFrom.Location = new System.Drawing.Point(844, 42);
            this.FilterRegTimeFrom.Name = "FilterRegTimeFrom";
            this.FilterRegTimeFrom.Size = new System.Drawing.Size(75, 21);
            this.FilterRegTimeFrom.TabIndex = 47;
            this.FilterRegTimeFrom.ValueChanged += new System.EventHandler(this.FilterRegTimeFromValueChanged);
            // 
            // FoundTimeLabel
            // 
            this.FoundTimeLabel.AutoSize = true;
            this.FoundTimeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoundTimeLabel.Location = new System.Drawing.Point(708, 25);
            this.FoundTimeLabel.Name = "FoundTimeLabel";
            this.FoundTimeLabel.Size = new System.Drawing.Size(88, 14);
            this.FoundTimeLabel.TabIndex = 46;
            this.FoundTimeLabel.Text = "Время потери";
            // 
            // FilterFoundTimeFrom
            // 
            this.FilterFoundTimeFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFoundTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterFoundTimeFrom.Location = new System.Drawing.Point(682, 42);
            this.FilterFoundTimeFrom.Name = "FilterFoundTimeFrom";
            this.FilterFoundTimeFrom.Size = new System.Drawing.Size(75, 21);
            this.FilterFoundTimeFrom.TabIndex = 45;
            this.FilterFoundTimeFrom.ValueChanged += new System.EventHandler(this.FilterFoundTimeFromValueChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(518, 25);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(60, 14);
            this.PhoneLabel.TabIndex = 44;
            this.PhoneLabel.Text = "Телефон";
            // 
            // FilterPhone
            // 
            this.FilterPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterPhone.Location = new System.Drawing.Point(510, 42);
            this.FilterPhone.MaxLength = 64;
            this.FilterPhone.Name = "FilterPhone";
            this.FilterPhone.Size = new System.Drawing.Size(80, 22);
            this.FilterPhone.TabIndex = 43;
            this.FilterPhone.TextChanged += new System.EventHandler(this.FilterPhoneTextChanged);
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(355, 25);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(34, 14);
            this.FIOLabel.TabIndex = 42;
            this.FIOLabel.Text = "ФИО";
            // 
            // FilterFIO
            // 
            this.FilterFIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterFIO.Location = new System.Drawing.Point(304, 42);
            this.FilterFIO.MaxLength = 256;
            this.FilterFIO.Name = "FilterFIO";
            this.FilterFIO.Size = new System.Drawing.Size(200, 22);
            this.FilterFIO.TabIndex = 41;
            this.FilterFIO.WordWrap = false;
            this.FilterFIO.TextChanged += new System.EventHandler(this.FilterFIOTextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(166, 25);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 14);
            this.DescriptionLabel.TabIndex = 40;
            this.DescriptionLabel.Text = "Описание";
            // 
            // FilterDescription
            // 
            this.FilterDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterDescription.Location = new System.Drawing.Point(98, 42);
            this.FilterDescription.MaxLength = 256;
            this.FilterDescription.Name = "FilterDescription";
            this.FilterDescription.Size = new System.Drawing.Size(200, 22);
            this.FilterDescription.TabIndex = 39;
            this.FilterDescription.WordWrap = false;
            this.FilterDescription.TextChanged += new System.EventHandler(this.FilterDescriptionTextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(23, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 14);
            this.NameLabel.TabIndex = 38;
            this.NameLabel.Text = "Название";
            // 
            // FilterName
            // 
            this.FilterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterName.Location = new System.Drawing.Point(12, 42);
            this.FilterName.MaxLength = 64;
            this.FilterName.Name = "FilterName";
            this.FilterName.Size = new System.Drawing.Size(80, 22);
            this.FilterName.TabIndex = 37;
            this.FilterName.TextChanged += new System.EventHandler(this.FilterNameTextChanged);
            // 
            // FormSwitchButton
            // 
            this.FormSwitchButton.Location = new System.Drawing.Point(934, 371);
            this.FormSwitchButton.Name = "FormSwitchButton";
            this.FormSwitchButton.Size = new System.Drawing.Size(95, 23);
            this.FormSwitchButton.TabIndex = 53;
            this.FormSwitchButton.Text = "Находки";
            this.FormSwitchButton.UseVisualStyleBackColor = true;
            this.FormSwitchButton.Click += new System.EventHandler(this.FindsButtonClick);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // логToolStripMenuItem
            // 
            this.логToolStripMenuItem.Name = "логToolStripMenuItem";
            this.логToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.логToolStripMenuItem.Text = "Лог";
            this.логToolStripMenuItem.Click += new System.EventHandler(this.логToolStripMenuItemClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 416);
            this.Controls.Add(this.FormSwitchButton);
            this.Controls.Add(this.SpotLabel);
            this.Controls.Add(this.FilterSpot);
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
            this.Controls.Add(this.CheckBoxSpot);
            this.Controls.Add(this.CheckBoxRegTime);
            this.Controls.Add(this.CheckBoxFoundTime);
            this.Controls.Add(this.CheckBoxPhone);
            this.Controls.Add(this.CheckBoxFIO);
            this.Controls.Add(this.CheckBoxDescription);
            this.Controls.Add(this.CheckBoxName);
            this.Controls.Add(this.FilterSwitchButton);
            this.Controls.Add(this.UpdateChangesButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LostsTable);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пропажи";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LostsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.находкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet11)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CourseDataSet1TableAdapters.ПотериTableAdapter потериTableAdapter1;
        private System.Windows.Forms.DataGridView LostsTable;
        private CourseDataSet1 courseDataSet11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учетнаяЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.Button UpdateChangesButton;
        private System.Windows.Forms.CheckBox CheckBoxSpot;
        private System.Windows.Forms.CheckBox CheckBoxRegTime;
        private System.Windows.Forms.CheckBox CheckBoxFoundTime;
        private System.Windows.Forms.CheckBox CheckBoxPhone;
        private System.Windows.Forms.CheckBox CheckBoxFIO;
        private System.Windows.Forms.CheckBox CheckBoxDescription;
        private System.Windows.Forms.CheckBox CheckBoxName;
        private System.Windows.Forms.Button FilterSwitchButton;
        private System.Windows.Forms.Label SpotLabel;
        private System.Windows.Forms.TextBox FilterSpot;
        private System.Windows.Forms.DateTimePicker FilterRegTimeTo;
        private System.Windows.Forms.DateTimePicker FilterFoundTimeTo;
        private System.Windows.Forms.Label RegTimeLabel;
        private System.Windows.Forms.DateTimePicker FilterRegTimeFrom;
        private System.Windows.Forms.Label FoundTimeLabel;
        private System.Windows.Forms.DateTimePicker FilterFoundTimeFrom;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox FilterPhone;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox FilterFIO;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox FilterDescription;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox FilterName;
        private System.Windows.Forms.Button FormSwitchButton;
        private System.Windows.Forms.BindingSource находкиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоПотериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПотериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОбращенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логToolStripMenuItem;
    }
}