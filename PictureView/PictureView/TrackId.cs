using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureView
{
    class TrackId
    {
        string strFolderName = "MFG";
        string strImagErrorMsg = "Picture Not Found!!!";
        string strPictureView = "*.jpg*";
        string strProductXML = "*.csv*";

        FrmMain frmMn = FrmMain.getInstance();
        
        public bool getTrackIdPictureView()
        {
            try
            {
                foreach (string folderName in Directory.GetDirectories(frmMn.textBoxDirectory.txt + "\\", ))
                {

                }

            }
        }
    }
}
