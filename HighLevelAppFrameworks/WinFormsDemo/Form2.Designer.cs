namespace WinFormsDemo
{
    partial class Form2
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
            this.LoadMoviesButton = new System.Windows.Forms.Button();
            this.MoviesDGV = new System.Windows.Forms.DataGridView();
            this.NudMovieYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMovieYear)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMoviesButton
            // 
            this.LoadMoviesButton.Location = new System.Drawing.Point(493, 385);
            this.LoadMoviesButton.Name = "LoadMoviesButton";
            this.LoadMoviesButton.Size = new System.Drawing.Size(135, 23);
            this.LoadMoviesButton.TabIndex = 0;
            this.LoadMoviesButton.Text = "Load Movies";
            this.LoadMoviesButton.UseVisualStyleBackColor = true;
            this.LoadMoviesButton.Click += new System.EventHandler(this.LoadMoviesButton_Click);
            // 
            // MoviesDGV
            // 
            this.MoviesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesDGV.Location = new System.Drawing.Point(8, 13);
            this.MoviesDGV.Name = "MoviesDGV";
            this.MoviesDGV.RowTemplate.Height = 25;
            this.MoviesDGV.Size = new System.Drawing.Size(780, 316);
            this.MoviesDGV.TabIndex = 1;
            // 
            // NudMovieYear
            // 
            this.NudMovieYear.Location = new System.Drawing.Point(153, 381);
            this.NudMovieYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.NudMovieYear.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.NudMovieYear.Name = "NudMovieYear";
            this.NudMovieYear.Size = new System.Drawing.Size(151, 23);
            this.NudMovieYear.TabIndex = 2;
            this.NudMovieYear.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.NudMovieYear.ValueChanged += new System.EventHandler(this.NudMovieYear_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NudMovieYear);
            this.Controls.Add(this.MoviesDGV);
            this.Controls.Add(this.LoadMoviesButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMovieYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoadMoviesButton;
        private DataGridView MoviesDGV;
        private NumericUpDown NudMovieYear;
    }
}