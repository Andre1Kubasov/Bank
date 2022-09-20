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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Регистрация не возможна, вы не указали имя");
                }
                else if(textBox2.Text == "")
                {
                    MessageBox.Show("Регистрация не возможна, вы не указали фамилию");
                }
                else if(textBox4.Text == "")
                {
                    MessageBox.Show("Регистрация не возможна, не указана дата рождения");
                }
                else if(textBox5.Text == "")
                {
                    MessageBox.Show("Регистрация не возможна, не указан номер");
                }
                else
                {
                    string name = textBox1.Text;
                    string famy = textBox2.Text;
                    if(textBox4.TextLength < 10)
                    {
                        MessageBox.Show("Дата рождения указана не верно");
                    }
                    else
                    {
                        if(textBox5.TextLength < 11)
                        {
                            MessageBox.Show("Номер указан не верно");
                        }
                        else
                        {
                            MessageBox.Show($"Успешно создана карта на {name} {famy}" +
                                $"\nномер карты 4705 6787 5678 8899");
                            Hide();
                            Form8 form8 = new Form8();
                            form8.ShowDialog();
                            Close();
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox1.Text, "[^а-я-А-Я-a-z-A-Z]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox2.Text, "[^а-я - А-Я - a-z-A-Z]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength - 1);
                textBox2.SelectionStart = textBox2.TextLength;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, "[^0-9-.]"))
            {
                textBox4.Text = textBox4.Text.Remove(textBox4.TextLength - 1);
                textBox4.SelectionStart = textBox4.TextLength;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                textBox5.Text = textBox5.Text.Remove(textBox5.TextLength - 1);
                textBox5.SelectionStart = textBox5.TextLength;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();  
            form4.ShowDialog();
            Close();
        }
    }
}
