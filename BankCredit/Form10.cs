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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Term = Convert.ToInt32(textBox1.Text);
                int Sum = Convert.ToInt32(textBox1.Text);
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Вы не указали срок вклада");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Вы не указали сумму вклада");
                }
                else
                {
                    if (textBox1.TextLength > 2 && textBox1.Text == "0")
                    {
                        MessageBox.Show("Не читаемая информация, попробуйте еще раз");
                    }
                    else
                    {
                        if (textBox2.TextLength > 7 && textBox2.Text == "0")
                        {
                            MessageBox.Show("Не читаемая информация, попробуйте еще раз");
                        }
                        else
                        {
                            label3.Text = $"Создан бессрочный вклад на сумму {Sum} месяцев и сроком на {Term}";
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Term = 8;
                textBox1.Text = Term.ToString();
                double Sum = Convert.ToDouble(textBox2.Text);
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Не указана сумма");
                }
                else
                {

                    label3.Text = $"Создан вклад сроком {Term} месяцев и на сумму {Sum}";
                }
            }
            catch
            {

            }

            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Term = 12;
                textBox1.Text = Term.ToString();
                double Sum = Convert.ToDouble(textBox2.Text);
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Не указана сумма");
                }
                else
                {
                    label3.Text = $"Создан вклад сроком {Term} месяцев и суммой {Sum}";
                }
            }
            catch
            {

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox1.Text, "^[0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, "^[0-9]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }

        private void выйтиВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void бессрочныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void семейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void накопительныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
