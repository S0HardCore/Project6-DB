using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Course
{
    public partial class Form1 : Form
    {
        public static String
            Account, Log = "Log.txt";
        public static FileStream LogFile;
        public static String[] FiltersText = new String[7]
            {
                "[Название] LIKE'%'",
                "[Описание] LIKE'%'",
                "[ФИО] LIKE'%'",
                "[Телефон] LIKE'%'",
                "[Место находки] LIKE '%'",
                "",
                ""
            };
        public static Boolean FiltersEnabled = true;
        public Form1(String _Account)
        {
            Account = _Account;
            File.SetAttributes(Log, FileAttributes.Normal);
            using (StreamWriter sw = File.AppendText(Log))
            sw.WriteLine(DateTime.Now.ToString() + " " + Account + " перешел на форму Находки.");
            FiltersEnabled = true;
            InitializeComponent();
            //this.KeyUp += fKeyUp;
            FilterFoundTimeFrom.Value = FilterRegTimeFrom.Value = DateTime.Now.AddMonths(-1);
            FilterFoundTimeTo.Value = FilterRegTimeTo.Value = DateTime.Now.AddMonths(1);
            FiltersText[5] = string.Format("[Время находки] >= '{0}' AND [Время находки] <= '{1}'",
                    FilterFoundTimeFrom.Value, FilterFoundTimeTo.Value);
            FiltersText[6] = string.Format("[Время регистрации] >= '{0}' AND [Время регистрации] <= '{1}'",
                    FilterRegTimeFrom.Value, FilterRegTimeTo.Value);
            учетнаяЗаписьToolStripMenuItem.Text = "Учетная запись [" + Account + "]";
        }

        void fKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                DialogResult Result = MessageBox.Show("Завершить работу?",
                            "Выход", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    using (StreamWriter sw = File.AppendText(Log))
                        sw.WriteLine(DateTime.Now.ToString() + " " + Account + " завершил программу.");
                    Application.Exit();
                }
            }
        }

        Boolean FormSwitching = false;

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!FormSwitching)
                Application.Exit();
            else
            {
                FormSwitching = false;
                base.OnClosing(e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.находкиTableAdapter1.Fill(this.courseDataSet1.Находки);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " разлогинился.");
            Form2 AuthForm = new Form2();
            AuthForm.Show();
            FormSwitching = true;
            this.Close();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            режимРаботыToolStripMenuItem.Text = "Режим работы [Просмотр]";
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " перешел в режим просмотра.");
            LostTable.ReadOnly = true;
            LostTable.AllowUserToDeleteRows = false;
            LostTable.AllowUserToAddRows = false;
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            режимРаботыToolStripMenuItem.Text = "Режим работы [Редактирование]";
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " перешел в режим редактирования.");
            LostTable.ReadOnly = false;
            LostTable.AllowUserToDeleteRows = true;
            LostTable.AllowUserToAddRows = true;
        }

        private void UpdateChangesButtonClick(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы действительно хотите сохранить изменения в базе?", "Сохранить изменения", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                using (StreamWriter sw = File.AppendText(Log))
                    sw.WriteLine(DateTime.Now.ToString() + " " + Account + " сохранил изменения.");
                this.находкиTableAdapter.Update(courseDataSet.Находки);
            }
        }

        private void FilterNameTextChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxName.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[0] = "[Название] LIKE'" + FilterName.Text + "%'";
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterDescriptionTextChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxDescription.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[1] = "[Описание] LIKE'" + FilterDescription.Text + "%'";
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterFIOTextChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxFIO.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[2] = "[ФИО] LIKE'" + FilterFIO.Text + "%'";
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterPhoneTextChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxPhone.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[3] = "[Телефон] LIKE'" + FilterPhone.Text + "%'";
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterSpotTextChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxSpot.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[4] = "[Место находки] LIKE'" + FilterSpot.Text + "%'";
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterFoundTimeToValueChanged(object sender, EventArgs e)
        {
            FilterFoundTimeFromValueChanged(sender, e);
        }

        private void FilterRegTimeToValueChanged(object sender, EventArgs e)
        {
            FilterRegTimeFromValueChanged(sender, e);
        }

        private void FilterFoundTimeFromValueChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxFoundTime.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[5] = string.Format("[Время находки] >= '{0}' AND [Время находки] <= '{1}'",
                    FilterFoundTimeFrom.Value, FilterFoundTimeTo.Value);
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterRegTimeFromValueChanged(object sender, EventArgs e)
        {
            if (FiltersEnabled && CheckBoxRegTime.Checked && LostTable.DataSource == находкиBindingSource)
            {
                FiltersText[6] = string.Format("[Время регистрации] >= '{0}' AND [Время регистрации] <= '{1}'",
                    FilterRegTimeFrom.Value, FilterRegTimeTo.Value);
                находкиBindingSource.Filter = CombineFilter();
            }
        }

        private void FilterSwitchButtonClick(object sender, EventArgs e)
        {
            if (!FiltersEnabled)
            {
                this.Width += 75;
                this.Height += 60;
                LostTable.Location = new Point(LostTable.Location.X, LostTable.Location.Y + 35);
                FilterSwitchButton.Location = new Point(FilterSwitchButton.Location.X, FilterSwitchButton.Location.Y + 35);
                UpdateChangesButton.Location = new Point(UpdateChangesButton.Location.X + 37, UpdateChangesButton.Location.Y + 35);
                FormSwitchButton.Location = new Point(FormSwitchButton.Left + 37, FormSwitchButton.Top + 45);
                FiltersEnabled = CheckBoxSpot.Visible = CheckBoxDescription.Visible = CheckBoxFIO.Visible = CheckBoxFoundTime.Visible = 
                    CheckBoxName.Visible = CheckBoxPhone.Visible = CheckBoxRegTime.Visible = FilterDescription.Visible = FilterFIO.Visible = FilterSpot.Visible =
                    FilterFoundTimeFrom.Visible = FilterFoundTimeTo.Visible = FilterName.Visible = FilterPhone.Visible = FilterRegTimeFrom.Visible = FilterRegTimeTo.Visible = 
                    DescriptionLabel.Visible = FIOLabel.Visible = FoundTimeLabel.Visible = NameLabel.Visible = PhoneLabel.Visible = RegTimeLabel.Visible = SpotLabel.Visible = true;
            }
            else
            {
                this.Width -= 75;
                this.Height -= 60;
                LostTable.Location = new Point(LostTable.Location.X, LostTable.Location.Y - 35);
                FilterSwitchButton.Location = new Point(FilterSwitchButton.Location.X, FilterSwitchButton.Location.Y - 35);
                UpdateChangesButton.Location = new Point(UpdateChangesButton.Location.X - 37, UpdateChangesButton.Location.Y - 35);
                FormSwitchButton.Location = new Point(FormSwitchButton.Location.X - 37, FormSwitchButton.Location.Y - 45);
                FiltersEnabled = CheckBoxSpot.Visible = CheckBoxDescription.Visible = CheckBoxFIO.Visible = CheckBoxFoundTime.Visible =
                    CheckBoxName.Visible = CheckBoxPhone.Visible = CheckBoxRegTime.Visible = FilterDescription.Visible = FilterFIO.Visible = FilterSpot.Visible =
                    FilterFoundTimeFrom.Visible = FilterFoundTimeTo.Visible = FilterName.Visible = FilterPhone.Visible = FilterRegTimeFrom.Visible = FilterRegTimeTo.Visible =
                    DescriptionLabel.Visible = FIOLabel.Visible = FoundTimeLabel.Visible = NameLabel.Visible = PhoneLabel.Visible = RegTimeLabel.Visible = SpotLabel.Visible = false;
            }
        }

        public String CombineFilter()
        {
            string CombinedFilter = String.Empty;
            if (CheckBoxName.Checked)
                CombinedFilter += FiltersText[0];
            if (CheckBoxDescription.Checked)
                CombinedFilter += (CheckBoxName.Checked ? " AND " : "") + FiltersText[1];
            if (CheckBoxFIO.Checked)
                CombinedFilter += (CheckBoxName.Checked || CheckBoxDescription.Checked ? " AND " : "") + FiltersText[2];
            if (CheckBoxPhone.Checked)
                CombinedFilter += (CheckBoxName.Checked || CheckBoxDescription.Checked || CheckBoxFIO.Checked ? " AND " : "") + FiltersText[3];
            if (CheckBoxSpot.Checked)
                CombinedFilter += (CheckBoxName.Checked || CheckBoxDescription.Checked || CheckBoxFIO.Checked || CheckBoxPhone.Checked ?
                    " AND " : "") + FiltersText[4];
            if (CheckBoxFoundTime.Checked)
                CombinedFilter += (CheckBoxName.Checked || CheckBoxDescription.Checked || CheckBoxFIO.Checked || CheckBoxPhone.Checked
                    || CheckBoxSpot.Checked ? " AND " : "") + FiltersText[5];
            if (CheckBoxRegTime.Checked)
                CombinedFilter += (CheckBoxName.Checked || CheckBoxDescription.Checked || CheckBoxFIO.Checked || CheckBoxPhone.Checked
                    || CheckBoxFoundTime.Checked || CheckBoxSpot.Checked ? " AND " : "") + FiltersText[6];
            //MessageBox.Show(CombinedFilter);
            return CombinedFilter;
        }

        private void CheckBoxNameStateChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
            if (!CheckBoxName.Checked)
                FilterName.Text = "";
        }

        private void CheckBoxDescriptionStateChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
            if (!CheckBoxDescription.Checked)
                FilterDescription.Text = "";
        }

        private void CheckBoxFIOStateChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
            if (!CheckBoxFIO.Checked)
                FilterFIO.Text = "";
        }

        private void CheckBoxPhoneStateChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
            if (!CheckBoxPhone.Checked)
                FilterPhone.Text = "";
        }

        private void CheckBoxFoundTimeStateChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxRegTimeStateChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }


        private void CheckBoxSpotCheckedChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
            if (!CheckBoxSpot.Checked)
                FilterSpot.Text = "";
        }

        private void LostsButtonClick(object sender, EventArgs e)
        {
            Form3 LostsForm = new Form3(Account);
            LostsForm.Show();
            this.Visible = false;
        }

        private void сотрудникиToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (Account == "admin")
            {
                Form4 WorkersForm = new Form4();
                WorkersForm.ShowDialog();
            }
            else
                MessageBox.Show("У вас нет доступа.");
        }

        private void логToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText(Log));
        }
    }
}
