using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BankCredit
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }



        private void выбратьДругойВкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form6 = new Form6();
            form6.ShowDialog();
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int term = Convert.ToInt32(textBox1.Text);
                int sum = Convert.ToInt32(textBox1.Text);
                if (textBox1.Text == "")
                {
                    label3.Text = "Вы не указали срок";
                }
                else if (textBox2.Text == "")
                {
                    label3.Text = "Вы не указали сумму";
                }
                else
                {

                    if (textBox1.TextLength <= 0 && textBox1.TextLength > 24)
                    {
                        MessageBox.Show("Вы ввели не корректный срок, введите от 1 до 24 месяцев");
                    }
                    else
                    {
                        if (textBox2.TextLength <= 0)
                        {
                            MessageBox.Show("Не верная сумма");
                        }
                        else
                        {
                            label3.Text = $"Вы создали конверт сроком{term} и на сумму {sum} ";
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
                int Term = 24;

                textBox1.Text = Term.ToString();
                double Sum = Convert.ToDouble(textBox2.Text);

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Вы не ввели сумму");
                }
                else
                {
                    MessageBox.Show("Создан вклад");
                    double result = Sum / 100 * 2.6;
                    label3.Text = $"За {Term} месяцев потенциальный доход от {Sum} рублей\nСоставит {result} руб.";
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
                int Term = Convert.ToInt16(textBox1.Text);
                double Sum = Convert.ToDouble(textBox2.Text);
                string MaxTerm = "8";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Вы не указали срок вклада");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Вы не указали сумму");
                }
                else
                {
                    if (textBox1.Text.Length < 8 && textBox1.TextLength > 36)
                    {
                        MessageBox.Show("Вы указали не допустисый срок для данного вклада");
                    }
                    else
                    {
                        MessageBox.Show("Вклад создан");
                        double result = Sum / 100 * 4.7;
                        label3.Text = $"За {Term} месяцев потенциальный доход от {Sum} рублей\nСоставит {result} руб.";
                    }
                }
            }
            catch
            {

            }
        }

        private void информацияПоВкладамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int Term = 48;
                textBox1.Text = Term.ToString();
                double Sum = Convert.ToDouble(textBox2.Text);
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Вы не ввели сумму");
                }
                else
                {
                    double result = Sum / 100 * 9;
                    label3.Text = $"За {Term} месяцев потенциальный доход от {Sum} рублей\nСоставит {result} руб.";
                }
            }
            catch
            {

            }
        }

        private void конвертToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При создании конверта Вы можете указать срок хранения ваших финансов не более 12 месяцев." +
                "\nПроцент не начисляется, снимать и пополнять можно в любой момент");
        }

        private void накопительныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Накопительный вклад начисляет Вам 2.6% годовых на остаточную суммц вклада." +
                "\nЕсть возможность оформить от 1 месяца до 24 месяцев. Пополнять и снимать финсф можете в любой момент.");
        }

        private void семейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вклад семейный начисляет Вам 4.7% годовых на остаточную сумму вклада." +
                "\nОформить данный вклад можно от 8 месяцев до 36 месяцев." +
                "\nМинимальная сумма для создания вклада 100 000 рублей.");
        }

        private void премиальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вклад премиальный создается на 48 месяцев и 9% годовых." +
                "\nВклад можно пополянть в любой момент, для снятия денег раньше сроко, нужно будет закрывать вклад.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                textBox1.SelectionStart = textBox1.TextLength;
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox2.Text, "[^0-9-,]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength - 1);
                textBox2.SelectionStart = textBox2.TextLength;
            }
        }
    }
}
