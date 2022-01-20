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
    public partial class Form2 : Form
    {
        Query controller;
        public Form2()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string surname = textBox3.Text;
            string position = textBox4.Text;
            controller.Add(kod, name, surname, position);
            MessageBox.Show("Сотрудник добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
