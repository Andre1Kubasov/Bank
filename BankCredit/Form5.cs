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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }
        async private void Form5_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            MessageBox.Show("Пример для вводимых карт карты \n0000.0000.0000.0000");
        }

        private void вернутьсяВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog(); 
            Close();
        }
        

        void button1_Click(object sender, EventArgs e)
        {

            try
            {
                

                if (textBox1.Text == "")
                {
                    label3.Text = "Вы не ввели номер карты";                    
                }
                else if(textBox2.Text == "")
                {
                    label3.Text = "Вы не ввели пароль";                   
                }
                else
                {
                    if(textBox1.TextLength < 14)
                    {
                        MessageBox.Show("Карта введена не корректно");
                    }
                    else
                    {
                        if(textBox2.TextLength < 8)
                        {
                            MessageBox.Show("Пароль введен не корректно");
                        }
                        else
                        {
                            MessageBox.Show("Добрый день!");
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
            
            if (Regex.IsMatch(textBox1.Text, "[^0-9-.]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
       

    }
}
