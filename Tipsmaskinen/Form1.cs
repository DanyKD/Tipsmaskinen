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

        // få en slumpmässig bok
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            // skapa en fileloader klass
            FileLoader böcker = new FileLoader();
            // läs alla böcker från filen
            böcker.LäsFrånFilen();
             //få en slumpmässig bok
            Bok randomBok = böcker.getRandomBok(TipsBox.Text);
             // Skriv ut en slumpmässig bok på text box
             TipsBox.Text = randomBok.ToString();
            }
            catch
            {
                //medelande om det inte kunde det finns fel i filen
                var result = MessageBox.Show("Det finns inga böcker eller ingen fil", "Stop",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Stop);
            }
        }
        // den här knappen för att visa den nya bokformen
        private void button1_Click_1(object sender, EventArgs e)
        {
            //skapa en ny bok form
            NyBok nybok = new NyBok();
            // visa formen
            nybok.Show();
        }
    }
}
