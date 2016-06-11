using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Course
{
    public partial class Form3 : Form
    {
        public static String
            Account, Log = "Log.txt";
        public static Random getRandom = new Random();
        public static Boolean
            FiltersEnabled = true, FormSwitching = false;
        public static String[] FiltersText = new String[7];
        public static Boolean[] FiltersCheckers = new Boolean[7];
        public Form3(String _Account)
        {
            Account = _Account;
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " перешел на форму Пропажи.");
            InitializeComponent();
            this.BackgroundImage = null;
            FiltersEnabled = true;
            for (int a = 0; a < 7; ++a)
                FiltersCheckers[a] = false;
            //this.KeyUp += fKeyUp;
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

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " перешел в режим просмотра.");
            режимРаботыToolStripMenuItem.Text = "Режим работы [Просмотр]";
            LostsTable.ReadOnly = true;
            LostsTable.AllowUserToDeleteRows = false;
            LostsTable.AllowUserToAddRows = false;
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " перешел в режим редактирования.");
            режимРаботыToolStripMenuItem.Text = "Режим работы [Редактирование]";
            LostsTable.ReadOnly = false;
            LostsTable.AllowUserToDeleteRows = true;
            LostsTable.AllowUserToAddRows = true;
        }

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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(Log))
                sw.WriteLine(DateTime.Now.ToString() + " " + Account + " разлогинился.");
            Form2 AuthForm = new Form2();
            AuthForm.Show();
            FormSwitching = true;
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.потериTableAdapter1.Fill(this.courseDataSet11.Потери);
        }

        private void UpdateChangesButtonClick(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы действительно хотите сохранить изменения в базе?", "Сохранить изменения", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                using (StreamWriter sw = File.AppendText(Log))
                    sw.WriteLine(DateTime.Now.ToString() + " " + Account + " сохранил изменения.");
                this.потериTableAdapter1.Update(courseDataSet11.Потери);
            }
        }

        public String CombineFilter()
        {
            string CombinedFilter = String.Empty;
            FiltersText = new String[7]{
                "[Название] LIKE'" + FilterName.Text + "%'",
                "[Описание] LIKE'" + FilterDescription.Text + "%'",
                "[ФИО] LIKE'" + FilterFIO.Text + "%'",
                "[Телефон] LIKE'" + FilterPhone.Text + "%'",
                "[Место потери] LIKE'" + FilterSpot.Text + "%'",
                "[Время потери] >= '" + FilterFoundTimeFrom.Value.ToString() + "' AND [Время потери] <= '" + FilterFoundTimeTo.Value.ToString() + "'",
                "[Время обращения] >= '" + FilterRegTimeFrom.Value.ToString() + "' AND [Время обращения] <= '" + FilterRegTimeTo.Value.ToString() + "'"
            };
            for (int a = 0; a < 7; ++a)
            {
                if (FiltersCheckers[a])
                    CombinedFilter += FiltersText[a];
                CombinedFilter += (CombinedFilter != "" && a != 6 && FiltersCheckers[a + 1] ? " AND " : "");
            }
            //MessageBox.Show(CombinedFilter);
            return (FiltersEnabled ? CombinedFilter : "");
        }

        private void FindsButtonClick(object sender, EventArgs e)
        {
            Form1 FindForm = new Form1(Account);
            FindForm.Show();
            this.Visible = false;
        }

        private void FilterNameTextChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterDescriptionTextChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterFIOTextChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterPhoneTextChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterSpotTextChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterFoundTimeToValueChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterRegTimeToValueChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterFoundTimeFromValueChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterRegTimeFromValueChanged(object sender, EventArgs e)
        {
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxNameStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[0] = CheckBoxName.Checked;
            if (!CheckBoxName.Checked)
                FilterName.Text = "";
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxDescriptionStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[1] = CheckBoxDescription.Checked;
            if (!CheckBoxDescription.Checked)
                FilterDescription.Text = "";
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxFIOStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[2] = CheckBoxFIO.Checked;
            if (!CheckBoxFIO.Checked)
                FilterFIO.Text = "";
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxPhoneStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[3] = CheckBoxPhone.Checked;
            if (!CheckBoxPhone.Checked)
                FilterPhone.Text = "";
            находкиBindingSource.Filter = CombineFilter();
        }
        
        private void CheckBoxSpotStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[4] = CheckBoxSpot.Checked;
            if (!CheckBoxSpot.Checked)
                FilterSpot.Text = "";
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxFoundTimeStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[5] = CheckBoxFoundTime.Checked;
            находкиBindingSource.Filter = CombineFilter();
        }

        private void CheckBoxRegTimeStateChanged(object sender, EventArgs e)
        {
            FiltersCheckers[6] = CheckBoxRegTime.Checked;
            находкиBindingSource.Filter = CombineFilter();
        }

        private void FilterSwitchButtonClick(object sender, EventArgs e)
        {
            if (!FiltersEnabled)
            {
                this.Width += 75;
                this.Height += 60;
                LostsTable.Location = new Point(LostsTable.Location.X, LostsTable.Location.Y + 35);
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
                LostsTable.Location = new Point(LostsTable.Location.X, LostsTable.Location.Y - 35);
                FilterSwitchButton.Location = new Point(FilterSwitchButton.Location.X, FilterSwitchButton.Location.Y - 35);
                UpdateChangesButton.Location = new Point(UpdateChangesButton.Location.X - 37, UpdateChangesButton.Location.Y - 35);
                FormSwitchButton.Location = new Point(FormSwitchButton.Location.X - 37, FormSwitchButton.Location.Y - 45);
                FiltersEnabled = CheckBoxSpot.Visible = CheckBoxDescription.Visible = CheckBoxFIO.Visible = CheckBoxFoundTime.Visible =
                    CheckBoxName.Visible = CheckBoxPhone.Visible = CheckBoxRegTime.Visible = FilterDescription.Visible = FilterFIO.Visible = FilterSpot.Visible =
                    FilterFoundTimeFrom.Visible = FilterFoundTimeTo.Visible = FilterName.Visible = FilterPhone.Visible = FilterRegTimeFrom.Visible = FilterRegTimeTo.Visible =
                    DescriptionLabel.Visible = FIOLabel.Visible = FoundTimeLabel.Visible = NameLabel.Visible = PhoneLabel.Visible = RegTimeLabel.Visible = SpotLabel.Visible = false;
            }
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
            if (Account == "admin")
                System.Diagnostics.Process.Start("Log.txt");
            else
                MessageBox.Show("У вас нет доступа.");
        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.BackgroundImage = Properties.Resources.bg2;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.White;
        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Gray;
        }

        private void случайныйЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.FromArgb(getRandom.Next(63, 255), getRandom.Next(63, 255), getRandom.Next(63, 255));
        }

    }
}
