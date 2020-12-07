using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    
    public partial class Form1 : Form
    {
        List<IDetails> Details = new List<IDetails>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Samochod samochod = new Samochod(textBox1.Text, textBox3.Text, Convert.ToInt32(textBox5.Text));
          Details.Add(samochod);
          textBox7.AppendText(textBox1.Text + textBox3.Text + Environment.NewLine);        
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Jacht jacht = new Jacht(textBox2.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text));
          Details.Add(jacht);
          textBox8.AppendText(textBox2.Text + textBox4.Text + Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (IDetails Detail in Details)
            {
                textBox9.AppendText(Detail.GetInfo() + Environment.NewLine);
            }
        }
    }
}
