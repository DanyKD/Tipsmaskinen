namespace Tipsmaskinen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TipsBox = new System.Windows.Forms.TextBox();
            this.TipsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipsBox
            // 
            this.TipsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipsBox.Location = new System.Drawing.Point(12, 13);
            this.TipsBox.Name = "TipsBox";
            this.TipsBox.Size = new System.Drawing.Size(528, 20);
            this.TipsBox.TabIndex = 0;
            this.TipsBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TipsButton
            // 
            this.TipsButton.Location = new System.Drawing.Point(12, 49);
            this.TipsButton.Name = "TipsButton";
            this.TipsButton.Size = new System.Drawing.Size(100, 34);
            this.TipsButton.TabIndex = 1;
            this.TipsButton.Text = "Tipsa mig!";
            this.TipsButton.UseVisualStyleBackColor = true;
            this.TipsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 104);
            this.Controls.Add(this.TipsButton);
            this.Controls.Add(this.TipsBox);
            this.Name = "Form1";
            this.Text = "Tipsmaskinen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TipsBox;
        private System.Windows.Forms.Button TipsButton;
    }
}

