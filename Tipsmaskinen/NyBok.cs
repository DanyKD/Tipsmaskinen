﻿using System;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string nybok = TitelTextBox.Text + "###" + SkribentTextBox.Text + "###" + TypComboBox.SelectedItem + "###true";
            FileLoader fileloader = new FileLoader();
            fileloader.SkrivTillFilen(nybok);
            this.Close();
        }
    }
}
