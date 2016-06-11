using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.courseDataSet11.Сотрудники);
        }

        private void WorkersSaveButtonClick(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы действительно хотите сохранить изменения в базе?", "Сохранить изменения", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
                this.сотрудникиTableAdapter.Update(courseDataSet11.Сотрудники);
        }

        private void WorkersCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
