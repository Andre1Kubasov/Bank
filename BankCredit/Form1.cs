using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCredit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form9 form9 = new Form9();
            form9.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 sberbank = new Form2();
            sberbank.ShowDialog();
            Close();
        }

       
    }
}
