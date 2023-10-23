namespace PictureView
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.textBoxTrackId = new System.Windows.Forms.TextBox();
            this.labelTrackId = new System.Windows.Forms.Label();
            this.pictureBoxTrFailure = new System.Windows.Forms.PictureBox();
            this.comboBoxTrFailure = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.progressBarTrackId = new System.Windows.Forms.ProgressBar();
            this.labelPictureView = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrFailure)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(43, 38);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(148, 26);
            this.textBoxTrackId.TabIndex = 0;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackId.ForeColor = System.Drawing.Color.Green;
            this.labelTrackId.Location = new System.Drawing.Point(43, 12);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(77, 22);
            this.labelTrackId.TabIndex = 1;
            this.labelTrackId.Text = "TrackId";
            // 
            // pictureBoxTrFailure
            // 
            this.pictureBoxTrFailure.Image = global::PictureView.Properties.Resources.Default;
            this.pictureBoxTrFailure.Location = new System.Drawing.Point(12, 150);
            this.pictureBoxTrFailure.Name = "pictureBoxTrFailure";
            this.pictureBoxTrFailure.Size = new System.Drawing.Size(1398, 603);
            this.pictureBoxTrFailure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrFailure.TabIndex = 2;
            this.pictureBoxTrFailure.TabStop = false;
            // 
            // comboBoxTrFailure
            // 
            this.comboBoxTrFailure.FormattingEnabled = true;
            this.comboBoxTrFailure.Location = new System.Drawing.Point(12, 116);
            this.comboBoxTrFailure.Name = "comboBoxTrFailure";
            this.comboBoxTrFailure.Size = new System.Drawing.Size(771, 28);
            this.comboBoxTrFailure.TabIndex = 3;
            this.comboBoxTrFailure.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrFailure_SelectedIndexChanged_1);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(204, 31);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 40);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(806, 116);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(428, 26);
            this.textBoxDirectory.TabIndex = 5;
            this.textBoxDirectory.Text = "C:\\CAMERA_FAIL_DATA\\BLEMISH";
            // 
            // progressBarTrackId
            // 
            this.progressBarTrackId.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBarTrackId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBarTrackId.Location = new System.Drawing.Point(43, 74);
            this.progressBarTrackId.Name = "progressBarTrackId";
            this.progressBarTrackId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarTrackId.Size = new System.Drawing.Size(366, 19);
            this.progressBarTrackId.TabIndex = 6;
            // 
            // labelPictureView
            // 
            this.labelPictureView.AutoSize = true;
            this.labelPictureView.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPictureView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPictureView.Location = new System.Drawing.Point(634, 13);
            this.labelPictureView.Name = "labelPictureView";
            this.labelPictureView.Size = new System.Drawing.Size(326, 61);
            this.labelPictureView.TabIndex = 7;
            this.labelPictureView.Text = "JOT Picture View";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDirectory.Location = new System.Drawing.Point(802, 93);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(77, 23);
            this.labelDirectory.TabIndex = 8;
            this.labelDirectory.Text = "Directory";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDeveloper.Location = new System.Drawing.Point(1245, 1);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(165, 15);
            this.labelDeveloper.TabIndex = 9;
            this.labelDeveloper.Text = "Developed by Matheus.Paiva";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 758);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelPictureView);
            this.Controls.Add(this.progressBarTrackId);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxTrFailure);
            this.Controls.Add(this.pictureBoxTrFailure);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxTrackId);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrFailure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTrackId;
        public System.Windows.Forms.TextBox textBoxTrackId;
        public System.Windows.Forms.PictureBox pictureBoxTrFailure;
        public System.Windows.Forms.ComboBox comboBoxTrFailure;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.ProgressBar progressBarTrackId;
        public System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Label labelPictureView;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Label labelDeveloper;
    }
}

