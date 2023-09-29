using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureView
{
    class TrackId
    {
        string strFolderName = "MFG";
        string strImagErrorMsg = "Picture Not Found!!!";
        string strPictureView = "*.jpg*";
        string strProductXML = "*.csv*";

        public void clearAllLog()
        {
            frmMn.comboBoxTrFailure.Items.Clear();
            frmMn.comboBoxTrFailure.Text = "";
            frmMn.textBoxTrackId.Text = "";
            frmMn.pictureBoxTrFailure.Image = Properties.Resources.Default;
            
        }

        FrmMain frmMn = FrmMain.getInstance();
        
        public bool getTrackIdPictureView()
        {
            try
            {
                foreach (string folderName in Directory.GetDirectories(frmMn.textBoxTrackId.Text + "\\", ))
                {

                }

            }
        }
    }
}
