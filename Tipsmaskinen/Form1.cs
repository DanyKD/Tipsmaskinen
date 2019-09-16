using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipsmaskinen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
            FileLoader böcker = new FileLoader();
            böcker.LäsFrånFilen();
            Bok randomBok = böcker.getRandomBok(TipsBox.Text);
            TipsBox.Text = randomBok.ToString();
            }
            catch
            {
                var result = MessageBox.Show("Det finns inga böcker eller ingen fil", "Stop",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Stop);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NyBok nybok = new NyBok();
            nybok.Show();
        }
    }
}
