namespace WinFormsDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ShowMoviesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(70, 94);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 0;
            this.CountButton.Text = "button1";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(224, 102);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(38, 15);
            this.CountLabel.TabIndex = 1;
            this.CountLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(78, 189);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(162, 189);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(88, 280);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(28, 15);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Age";
            // 
            // NudAge
            // 
            this.NudAge.Location = new System.Drawing.Point(162, 280);
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(120, 23);
            this.NudAge.TabIndex = 5;
            this.NudAge.ValueChanged += new System.EventHandler(this.NudAge_ValueChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(82, 358);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 15);
            this.MessageLabel.TabIndex = 6;
            // 
            // ShowMoviesButton
            // 
            this.ShowMoviesButton.Location = new System.Drawing.Point(82, 412);
            this.ShowMoviesButton.Name = "ShowMoviesButton";
            this.ShowMoviesButton.Size = new System.Drawing.Size(111, 23);
            this.ShowMoviesButton.TabIndex = 7;
            this.ShowMoviesButton.Text = "Show Movies";
            this.ShowMoviesButton.UseVisualStyleBackColor = true;
            this.ShowMoviesButton.Click += new System.EventHandler(this.ShowMoviesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowMoviesButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.NudAge);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CountButton;
        private Label CountLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label AgeLabel;
        private NumericUpDown NudAge;
        private Label MessageLabel;
        private Button ShowMoviesButton;
    }
}