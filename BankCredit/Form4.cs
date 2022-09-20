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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            Close();
        }
    }
}
