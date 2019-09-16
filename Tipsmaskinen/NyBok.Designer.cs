namespace Tipsmaskinen
{
    partial class NyBok
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.TitelLabel = new System.Windows.Forms.Label();
            this.SkribentLabel = new System.Windows.Forms.Label();
            this.TypLabel = new System.Windows.Forms.Label();
            this.TitelTextBox = new System.Windows.Forms.TextBox();
            this.SkribentTextBox = new System.Windows.Forms.TextBox();
            this.TypComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // TitelLabel
            // 
            this.TitelLabel.AutoSize = true;
            this.TitelLabel.Location = new System.Drawing.Point(28, 44);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(33, 13);
            this.TitelLabel.TabIndex = 0;
            this.TitelLabel.Text = "Titel: ";
            this.TitelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SkribentLabel
            // 
            this.SkribentLabel.AutoSize = true;
            this.SkribentLabel.Location = new System.Drawing.Point(12, 92);
            this.SkribentLabel.Name = "SkribentLabel";
            this.SkribentLabel.Size = new System.Drawing.Size(49, 13);
            this.SkribentLabel.TabIndex = 1;
            this.SkribentLabel.Text = "Skribent:";
            // 
            // TypLabel
            // 
            this.TypLabel.AutoSize = true;
            this.TypLabel.Location = new System.Drawing.Point(33, 148);
            this.TypLabel.Name = "TypLabel";
            this.TypLabel.Size = new System.Drawing.Size(28, 13);
            this.TypLabel.TabIndex = 2;
            this.TypLabel.Text = "Typ:";
            // 
            // TitelTextBox
            // 
            this.TitelTextBox.Location = new System.Drawing.Point(101, 44);
            this.TitelTextBox.Name = "TitelTextBox";
            this.TitelTextBox.Size = new System.Drawing.Size(153, 20);
            this.TitelTextBox.TabIndex = 3;
            // 
            // SkribentTextBox
            // 
            this.SkribentTextBox.Location = new System.Drawing.Point(101, 92);
            this.SkribentTextBox.Name = "SkribentTextBox";
            this.SkribentTextBox.Size = new System.Drawing.Size(153, 20);
            this.SkribentTextBox.TabIndex = 4;
            // 
            // TypComboBox
            // 
            this.TypComboBox.FormattingEnabled = true;
            this.TypComboBox.Items.AddRange(new object[] {
            "Tidskrift",
            "Roman",
            "Novellsamling"});
            this.TypComboBox.Location = new System.Drawing.Point(101, 140);
            this.TypComboBox.Name = "TypComboBox";
            this.TypComboBox.Size = new System.Drawing.Size(153, 21);
            this.TypComboBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(36, 223);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 40);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(197, 223);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 40);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NyBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 306);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TypComboBox);
            this.Controls.Add(this.SkribentTextBox);
            this.Controls.Add(this.TitelTextBox);
            this.Controls.Add(this.TypLabel);
            this.Controls.Add(this.SkribentLabel);
            this.Controls.Add(this.TitelLabel);
            this.Name = "NyBok";
            this.Text = "NyBok";
            this.Load += new System.EventHandler(this.NyBok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox TypComboBox;
        private System.Windows.Forms.TextBox SkribentTextBox;
        private System.Windows.Forms.TextBox TitelTextBox;
        private System.Windows.Forms.Label TypLabel;
        private System.Windows.Forms.Label SkribentLabel;
        private System.Windows.Forms.Label TitelLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}