using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Samochod s1 = new Samochod();
            s1.marka = "Fiat";
            s1.model = "98";
            s1.paliwo = "benzyna";
            tabSamochodow.Add(s1);
            reflist();
            Samochod s2 = new Samochod();
            s2.marka = "Audi";
            s2.model = "TT";
            s2.paliwo = "98";
            tabSamochodow.Add(s2);
            reflist();
            Samochod s3 = new Samochod();
            s3.marka = "Pagani";
            s3.model = "Zonda";
            s3.paliwo = "bio3";
            tabSamochodow.Add(s3);
            reflist();
        }

        public void reflist()
        {
            listBox1.Items.Clear();
            foreach (Samochod s in tabSamochodow)
            {
                listBox1.Items.Add(s.marka + " " + s.model + " " + s.paliwo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(numericUpDown1.Text);
            int b = Int32.Parse(numericUpDown2.Text);
            textBox4.Text = tabSamochodow[a][b];
            reflist();

        }

        List<Samochod> tabSamochodow = new List<Samochod>();

        private void button1_Click(object sender, EventArgs e)
        {

            Samochod s = new Samochod();
            s.marka = textBox1.Text;
            s.model = textBox2.Text;
            s.paliwo = textBox3.Text;
            tabSamochodow.Add(s);
            reflist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox5.Text);
            int b = Int32.Parse(textBox6.Text);
            tabSamochodow[a][b] = textBox7.Text;
            reflist();
        }
    }
}
