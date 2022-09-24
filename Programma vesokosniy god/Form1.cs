using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma_vesokosniy_god
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n, t;
            n = int.Parse(textBox1.Text);
            t = (n % 4);
            if (t == 0)
                textBox1.Text = "Ура! год високосный";
            else
                textBox1.Text = "Год не високосный :(";
        }
    }
}
