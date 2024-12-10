using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void unitPriceTestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(unitPriceTestBox.Text, out int price))
            {
                if(int.TryParse(volumeTextBox.Text, out int volume))
                {
                    int amount = price * volume;
                    amountLabel.Text = amount.ToString("C");
                }
                else
                {
                    amountLabel.Text = "個数を入力";
                }
            }else
            {
                amountLabel.Text = "金額を入力";
            }
             
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
