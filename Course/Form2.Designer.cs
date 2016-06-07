namespace Course
{
    partial class Form2
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.courseDataSet1 = new Course.CourseDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter1 = new Course.CourseDataSetTableAdapters.СотрудникиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkersHelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Location = new System.Drawing.Point(19, 43);
            this.loginBox.MaxLength = 16;
            this.loginBox.Name = "loginBox";
            this.loginBox.ShortcutsEnabled = false;
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // passBox
            // 
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Location = new System.Drawing.Point(19, 97);
            this.passBox.MaxLength = 16;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '•';
            this.passBox.ShortcutsEnabled = false;
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 3;
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(24, 136);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(90, 30);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Вход";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButtonClick);
            // 
            // courseDataSet1
            // 
            this.courseDataSet1.DataSetName = "CourseDataSet";
            this.courseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Сотрудники";
            this.bindingSource1.DataSource = this.courseDataSet1;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.сменаDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-36, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // сменаDataGridViewTextBoxColumn
            // 
            this.сменаDataGridViewTextBoxColumn.DataPropertyName = "Смена";
            this.сменаDataGridViewTextBoxColumn.HeaderText = "Смена";
            this.сменаDataGridViewTextBoxColumn.Name = "сменаDataGridViewTextBoxColumn";
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            // 
            // WorkersHelpButton
            // 
            this.WorkersHelpButton.BackgroundImage = global::Course.Properties.Resources.help;
            this.WorkersHelpButton.Location = new System.Drawing.Point(113, 1);
            this.WorkersHelpButton.Name = "WorkersHelpButton";
            this.WorkersHelpButton.Size = new System.Drawing.Size(24, 24);
            this.WorkersHelpButton.TabIndex = 6;
            this.WorkersHelpButton.UseVisualStyleBackColor = true;
            this.WorkersHelpButton.Click += new System.EventHandler(this.WorkersHelpButtonClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 190);
            this.Controls.Add(this.WorkersHelpButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button AuthButton;
        private CourseDataSet courseDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CourseDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button WorkersHelpButton;
    }
}