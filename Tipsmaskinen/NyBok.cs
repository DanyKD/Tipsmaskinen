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
    public partial class NyBok : Form
    {
        public NyBok()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void NyBok_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Den här knappen för att spara den nya boken i filen
        private void AddButton_Click(object sender, EventArgs e)
        {
            try {
            //lägg all textboxboxdata i en sträng för att lägga till i filen
            string nybok = TitelTextBox.Text + "###" + SkribentTextBox.Text + "###" + TypComboBox.SelectedItem + "###true";
            //skapa en ny fileloader klass
            FileLoader fileloader = new FileLoader();
            // skriv ny bok till filen
            fileloader.SkrivTillFilen(nybok);
            // medelande till användar att ny bok här lagts till filen
            MessageBox.Show("Ny bok har lagts till i filen", "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            // Stänga ny bok form
            this.Close();
            }
            catch
            {
                // medelande om det inte kunde läggas till en ny bok
                MessageBox.Show("Det finns fel att lägga till en ny bok ", "Stop",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
