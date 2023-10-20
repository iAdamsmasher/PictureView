using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PictureView
{
    class TrackId
    {
        string strImagErrorMsg = "Picture Not Found!!!";
        string strPictureView = "*.jpg*";


        FrmMain frmMn = FrmMain.getInstance();

        public void getTrackIdPictureView(string TrackId)
        {
            try
            {
                foreach (string pictureName in Directory.GetFiles(frmMn.textBoxDirectory.Text + "\\", strPictureView, SearchOption.AllDirectories))
                {
                    frmMn.progressBarUpDate(1);
                    if (pictureName.Contains(TrackId))
                        frmMn.comboBoxTrFailure.Items.Add(pictureName);

                }
            }
            catch
            {
                MessageBox.Show(strImagErrorMsg);
                frmMn.textBoxTrackId.Text = "";
            }

        }
        public void clearAll()
        {
            frmMn.comboBoxTrFailure.Items.Clear();
            frmMn.comboBoxTrFailure.Text = "";
            frmMn.textBoxTrackId.Text = "";
            frmMn.pictureBoxTrFailure.Image = Properties.Resources.Default;

        }
    }
}
