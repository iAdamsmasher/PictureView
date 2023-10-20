using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureView
{
    public partial class FrmMain : Form
    {
        string strPictureViewErrorMsg = "Error to Load the Picture View";
        TrackId TrId;
        public static FrmMain INSTANCEFrm = null;

        public FrmMain()
        {
            INSTANCEFrm = this;
            InitializeComponent();
        }

        public static FrmMain getInstance()
        {
            if (INSTANCEFrm == null)
                INSTANCEFrm = new FrmMain();
            return INSTANCEFrm;
        }
        private void comboBoxTrFailure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pictureName = string.Empty;
            pictureName = comboBoxTrFailure.SelectedItem.ToString();

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            comboBoxTrFailure.Items.Clear();
            defineProgressBar();
            TrId = new TrackId();
            if (textBoxTrackId.Text.Length != 10)
            {
                MessageBox.Show("TrackId Inválido", "TrackId - Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTrackId.Text = "";
            }
            else
            {
                TrId.getTrackIdPictureView(textBoxTrackId.Text);
                textBoxTrackId.Text = "";
            }
        }
        public void progressBarUpDate(int value)
        {
            if (progressBarTrackId.Value == 100)
            {

            }
            else
                progressBarTrackId.Value += value;
        }
        public void defineProgressBar()
        {
            progressBarTrackId.Minimum = 0;
            progressBarTrackId.Maximum = 100;
            progressBarTrackId.Value = 0;
        }
        private void comboBoxTrFailure_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                pictureBoxTrFailure.Image = Image.FromFile(comboBoxTrFailure.Text);
            }
            catch
            {
                MessageBox.Show(strPictureViewErrorMsg);
            }
        }
    }
}

