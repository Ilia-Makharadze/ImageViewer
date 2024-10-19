namespace assignment4
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
            this.MainPhoto = new System.Windows.Forms.PictureBox();
            this.PreviousPhoto = new System.Windows.Forms.PictureBox();
            this.NextPhoto = new System.Windows.Forms.PictureBox();
            this.DirectoryBox = new System.Windows.Forms.ComboBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CheckLoop = new System.Windows.Forms.CheckBox();
            this.RecursiveSearch = new System.Windows.Forms.CheckBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPhoto
            // 
            this.MainPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPhoto.Location = new System.Drawing.Point(366, 70);
            this.MainPhoto.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MainPhoto.Name = "MainPhoto";
            this.MainPhoto.Size = new System.Drawing.Size(268, 150);
            this.MainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPhoto.TabIndex = 0;
            this.MainPhoto.TabStop = false;
            this.MainPhoto.Click += new System.EventHandler(this.MainPhoto_Click);
            // 
            // PreviousPhoto
            // 
            this.PreviousPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousPhoto.Location = new System.Drawing.Point(366, 301);
            this.PreviousPhoto.MaximumSize = new System.Drawing.Size(300, 200);
            this.PreviousPhoto.Name = "PreviousPhoto";
            this.PreviousPhoto.Size = new System.Drawing.Size(100, 59);
            this.PreviousPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousPhoto.TabIndex = 1;
            this.PreviousPhoto.TabStop = false;
            this.PreviousPhoto.Click += new System.EventHandler(this.PreviousPhoto_Click);
            // 
            // NextPhoto
            // 
            this.NextPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPhoto.Location = new System.Drawing.Point(523, 301);
            this.NextPhoto.MaximumSize = new System.Drawing.Size(300, 200);
            this.NextPhoto.Name = "NextPhoto";
            this.NextPhoto.Size = new System.Drawing.Size(100, 50);
            this.NextPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextPhoto.TabIndex = 2;
            this.NextPhoto.TabStop = false;
            this.NextPhoto.Click += new System.EventHandler(this.NextPhoto_Click);
            // 
            // DirectoryBox
            // 
            this.DirectoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryBox.FormattingEnabled = true;
            this.DirectoryBox.Location = new System.Drawing.Point(78, 70);
            this.DirectoryBox.MaximumSize = new System.Drawing.Size(121, 0);
            this.DirectoryBox.Name = "DirectoryBox";
            this.DirectoryBox.Size = new System.Drawing.Size(121, 21);
            this.DirectoryBox.TabIndex = 3;
            this.DirectoryBox.SelectedIndexChanged += new System.EventHandler(this.DirectoryBox_SelectedIndexChanged);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousButton.Location = new System.Drawing.Point(48, 324);
            this.PreviousButton.MaximumSize = new System.Drawing.Size(150, 46);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(176, 324);
            this.NextButton.MaximumSize = new System.Drawing.Size(150, 46);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CheckLoop
            // 
            this.CheckLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckLoop.AutoSize = true;
            this.CheckLoop.Location = new System.Drawing.Point(78, 145);
            this.CheckLoop.MaximumSize = new System.Drawing.Size(111, 17);
            this.CheckLoop.Name = "CheckLoop";
            this.CheckLoop.Size = new System.Drawing.Size(50, 17);
            this.CheckLoop.TabIndex = 6;
            this.CheckLoop.Text = "Loop";
            this.CheckLoop.UseVisualStyleBackColor = true;
            this.CheckLoop.CheckedChanged += new System.EventHandler(this.CheckLoop_CheckedChanged);
            // 
            // RecursiveSearch
            // 
            this.RecursiveSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecursiveSearch.AutoSize = true;
            this.RecursiveSearch.Location = new System.Drawing.Point(193, 145);
            this.RecursiveSearch.MaximumSize = new System.Drawing.Size(111, 17);
            this.RecursiveSearch.Name = "RecursiveSearch";
            this.RecursiveSearch.Size = new System.Drawing.Size(111, 17);
            this.RecursiveSearch.TabIndex = 7;
            this.RecursiveSearch.Text = "Recursive Search";
            this.RecursiveSearch.UseVisualStyleBackColor = true;
            this.RecursiveSearch.CheckedChanged += new System.EventHandler(this.RecursiveSearch_CheckedChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.Location = new System.Drawing.Point(62, 250);
            this.PlayButton.MaximumSize = new System.Drawing.Size(150, 46);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 168);
            this.textBox1.MaximumSize = new System.Drawing.Size(100, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 648);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.RecursiveSearch);
            this.Controls.Add(this.CheckLoop);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.DirectoryBox);
            this.Controls.Add(this.NextPhoto);
            this.Controls.Add(this.PreviousPhoto);
            this.Controls.Add(this.MainPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPhoto;
        private System.Windows.Forms.PictureBox PreviousPhoto;
        private System.Windows.Forms.PictureBox NextPhoto;
        private System.Windows.Forms.ComboBox DirectoryBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckBox CheckLoop;
        private System.Windows.Forms.CheckBox RecursiveSearch;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

