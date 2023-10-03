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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrFailure)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(43, 38);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(314, 26);
            this.textBoxTrackId.TabIndex = 0;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(43, 12);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(62, 20);
            this.labelTrackId.TabIndex = 1;
            this.labelTrackId.Text = "TrackId";
            // 
            // pictureBoxTrFailure
            // 
            this.pictureBoxTrFailure.Image = global::PictureView.Properties.Resources.Default;
            this.pictureBoxTrFailure.Location = new System.Drawing.Point(12, 150);
            this.pictureBoxTrFailure.Name = "pictureBoxTrFailure";
            this.pictureBoxTrFailure.Size = new System.Drawing.Size(1031, 509);
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
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(377, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(147, 41);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(572, 38);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(428, 26);
            this.textBoxDirectory.TabIndex = 5;
            this.textBoxDirectory.Text = "C:\\CAMERA_FAIL_DATA\\BLEMISH";
            // 
            // progressBarTrackId
            // 
            this.progressBarTrackId.Location = new System.Drawing.Point(43, 70);
            this.progressBarTrackId.Name = "progressBarTrackId";
            this.progressBarTrackId.Size = new System.Drawing.Size(314, 10);
            this.progressBarTrackId.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 671);
            this.Controls.Add(this.progressBarTrackId);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxTrFailure);
            this.Controls.Add(this.pictureBoxTrFailure);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxTrackId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
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
        private System.Windows.Forms.TextBox textBoxDirectory;
        public System.Windows.Forms.ProgressBar progressBarTrackId;
    }
}

