using System;
using System.IO;
using System.Windows.Forms;

namespace Course
{
    public partial class Form2 : Form
    {
        public static Boolean Logined = false;
        String[] Workers = new String[32];
        public Form2()
        {
            InitializeComponent();
            File.SetAttributes("Log.txt", FileAttributes.Hidden);
            Logined = false;
            if (!File.Exists("Log.txt"))
            {
                StreamWriter file = new StreamWriter("Log.txt");
                file.Close();
            }
            
            this.AcceptButton = AuthButton;
        }

        void fKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    DialogResult Result = MessageBox.Show("Завершить работу?",
                        "Выход", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                        Application.Exit();
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {   
            this.сотрудникиTableAdapter1.Fill(this.courseDataSet1.Сотрудники);
        }

        private void AuthButtonClick(object sender, EventArgs e)
        {
            AuthButtonClickMethod();
        }

        private void AuthButtonClickMethod()
        {
            for (int q = 0; q < dataGridView1.RowCount - 1; ++q)
                Workers[q] = dataGridView1.Rows[q].Cells[1].Value.ToString();
            for (int q = 0; q < dataGridView1.RowCount - 1; ++q)
                if (!Logined)
                {
                    if (loginBox.Text.Length == 0 || passBox.Text.Length == 0)
                        break;
                    else
                        if ((loginBox.Text == Workers[q] && passBox.Text == q.ToString()) || (loginBox.Text == "admin" && passBox.Text == "1234"))
                        {
                            Form1 FindForm = new Form1(loginBox.Text);
                            FindForm.Show();
                            this.Visible = false;
                            Logined = true;
                            break;
                        }
                }
            if (!Logined)
                MessageBox.Show("Вы неверно ввели логин или пароль.", "Ошибка", MessageBoxButtons.OK);
            passBox.Text = "";
        }

        private void WorkersHelpButtonClick(object sender, EventArgs e)
        {
            string temp = "";
            for (int q = 0; q < dataGridView1.RowCount - 1; ++q)
                temp += (q + 1).ToString() + ") " + dataGridView1.Rows[q].Cells[1].Value.ToString() + (q < dataGridView1.RowCount - 2 ? "\n" : "");
            MessageBox.Show(temp, "Сотрудники");
        }
    }
}
