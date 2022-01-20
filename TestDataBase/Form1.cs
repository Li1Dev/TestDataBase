using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDataBase.Controller;

namespace TestDataBase
{
    public partial class Form1 : Form
    {
        Query controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.companyDBDataSet.Сотрудники);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            controller.Delite(kod);
            this.сотрудникиTableAdapter.Fill(this.companyDBDataSet.Сотрудники);
            MessageBox.Show($"Сотрудник под номером {kod} удален"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string newPosition = textBox3.Text;
            controller.ChangePosition(kod, newPosition);
            this.сотрудникиTableAdapter.Fill(this.companyDBDataSet.Сотрудники);
            MessageBox.Show("Должность сотрудника изменена");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.companyDBDataSet.Сотрудники);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
