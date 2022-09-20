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
    
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
        }
        

        async private void Form2_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            MessageBox.Show("Для лучшего расчета вклада, указывайте сроки в годах\nПример <1, 2.5 ,4>", "Примечание",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Sum;
                double Term;
                
                
                if(textBox1.Text != "" && textBox2.Text != "")
                {
                    Sum = Convert.ToDouble(textBox1.Text);
                    Term = Convert.ToDouble(textBox2.Text);
                    label4.Text =  $"Создан вклад на сумму {Sum} рублей и сроком на {Term} лет ".ToString();
                }
                else
                {
                    label4.Text = "Данные не указаны";
                }    


            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double percent = 0.04;
            //Вклад бессрочный
            try
            {
                
                if (textBox1.Text != "")
                {
                    double bbs = Convert.ToDouble(textBox1.Text);
                    double result = (bbs * percent * 365) / 100 / 100;
                    double result2 = (bbs * 0.02 * 30) / 100;
                    label4.Text = "Вклад создан, начисление в год " + result + " ₽ " +
                        "\nНачислений в месяц =" + result2 + " ₽".ToString();
                }
                else
                {
                    label4.Text = "Введите сумму вклада";

                }
            }
            catch
            {

            }
            
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Вклад Льготный 

            try
            {
                double percent = 3.2;
                if (textBox1.Text != "")
                {
                    double sum = Convert.ToDouble(textBox1.Text);
                    double result = (sum * percent * 365) / 100 / 100;
                    double resul = (sum * 0.9 * 30) / 100 / 100;
                    label4.Text = "Вы создали льготный вклад, на сумму " + sum +
                        "\nСумма процентов за год " + result + "Сумма процентов за месяц " + resul;
                }
                else
                {
                    label4.Text = "Введите сумму вклада";
                }
            }
            catch 
            {
                
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Премиальный
            double pricent = 12;
            
            try
            {
                
                bool next;
                double number = 4;

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double Sum = Convert.ToDouble(textBox1.Text);
                    double Term = Convert.ToDouble(textBox2.Text);
                    next = true;
                    if(next == true)
                    {
                        if (Term > number)
                        {
                            double result = (Sum * pricent * Term) / 100; //Сумма процентов за весь срок вклада
                            double resul = (Sum * 0.4 * 30) / 100 / 2; //Сумма начислений в месяц
                            label4.Text = $"Создан вклад на сумму {Sum} и сроком на {Term} лет" +
                                $"\nСумма начисленных процентов за {Term} лет составит {result} рублей" +
                                $" \n Cумма начислений в месяц составит {resul}";

                        }
                        else
                        {
                            label4.Text = "Вы указали не верный срок, мимальный 4 года";
                        }
                    }
                   
                }
                else
                {
                    label4.Text = "Вы не указали данные";
                    next = false;
                    
                }
                
            }
            catch
            {

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Вклад Выгодный
            try
            {
                double princent = 7;
                if (textBox1.Text != "")
                {
                    double sum = Convert.ToDouble(textBox1.Text);
                    double result = (sum * princent * 365) / 100 / 100;
                    double resul = (sum * 1.9 * 30) / 100 / 100;
                    label4.Text = "Создан вклад на сумму " + sum + "\nначисленные процеты за год " + result +
                        "\nначисленные проценты за месяц" + resul;
                }
            }
            catch
            {

            }
            
        }
        private void подробнееОВкладахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Close();
        }
        

        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox2.Text.Remove(textBox1.Text.Length -1);
                textBox1.SelectionStart = textBox1.TextLength;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength -1);
                textBox2.SelectionStart = textBox2.TextLength;
            }
        }
    }
}
