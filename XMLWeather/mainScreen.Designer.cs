namespace XMLWeather
{
    partial class mainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.weatherPicture = new System.Windows.Forms.PictureBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.weatherPicture2 = new System.Windows.Forms.PictureBox();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.conditionLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highestTempLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lowestTempLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(213, 29);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "City Name Here...";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(223, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 28);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(4, 39);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(212, 49);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "Stratford";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 480);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(4, 88);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(212, 28);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "April 2. 2025";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(204, 127);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(80, 36);
            this.currentLabel.TabIndex = 5;
            this.currentLabel.Text = "14*";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherPicture
            // 
            this.weatherPicture.Location = new System.Drawing.Point(204, 39);
            this.weatherPicture.Name = "weatherPicture";
            this.weatherPicture.Size = new System.Drawing.Size(80, 80);
            this.weatherPicture.TabIndex = 6;
            this.weatherPicture.TabStop = false;
            // 
            // conditionLabel
            // 
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.Location = new System.Drawing.Point(3, 122);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(213, 28);
            this.conditionLabel.TabIndex = 7;
            this.conditionLabel.Text = "Partially Cloudy";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(191, 163);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(53, 26);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "14*";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(241, 163);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(53, 26);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "14*";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherPicture2
            // 
            this.weatherPicture2.Location = new System.Drawing.Point(0, 223);
            this.weatherPicture2.Name = "weatherPicture2";
            this.weatherPicture2.Size = new System.Drawing.Size(40, 40);
            this.weatherPicture2.TabIndex = 10;
            this.weatherPicture2.TabStop = false;
            // 
            // dateLabel2
            // 
            this.dateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel2.Location = new System.Drawing.Point(46, 223);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(105, 20);
            this.dateLabel2.TabIndex = 11;
            this.dateLabel2.Text = "Wednesday";
            this.dateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionLabel2
            // 
            this.conditionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel2.Location = new System.Drawing.Point(46, 243);
            this.conditionLabel2.Name = "conditionLabel2";
            this.conditionLabel2.Size = new System.Drawing.Size(105, 20);
            this.conditionLabel2.TabIndex = 12;
            this.conditionLabel2.Text = "Partially Cloudy";
            this.conditionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Highest";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lowest";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestTempLabel
            // 
            this.highestTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestTempLabel.Location = new System.Drawing.Point(155, 238);
            this.highestTempLabel.Name = "highestTempLabel";
            this.highestTempLabel.Size = new System.Drawing.Size(53, 26);
            this.highestTempLabel.TabIndex = 15;
            this.highestTempLabel.Text = "14*";
            this.highestTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Highest";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lowest";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowestTempLabel
            // 
            this.lowestTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestTempLabel.Location = new System.Drawing.Point(218, 238);
            this.lowestTempLabel.Name = "lowestTempLabel";
            this.lowestTempLabel.Size = new System.Drawing.Size(53, 26);
            this.lowestTempLabel.TabIndex = 17;
            this.lowestTempLabel.Text = "14*";
            this.lowestTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lowestTempLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.highestTempLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conditionLabel2);
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.weatherPicture2);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.weatherPicture);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainScreen";
            this.Size = new System.Drawing.Size(320, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.PictureBox weatherPicture;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.PictureBox weatherPicture2;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.Label conditionLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highestTempLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lowestTempLabel;
    }
}
