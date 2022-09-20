using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BankCredit
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели логин");
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
            }
            else
            {
                if(textBox1.TextLength < 11)
                {
                    MessageBox.Show("Указан не верный логин");
                }
                else
                {
                    if(textBox2.TextLength < 8)
                    {
                        MessageBox.Show("Вы указали короткий пароль");
                    }
                    else
                    {
                        Hide();
                        Form10 VkladTinkoff = new Form10();
                        VkladTinkoff.ShowDialog();
                        Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, "[^0-9-a-z-A-Z]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength - 1);
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }
    }
}
