using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TrId = new TrackId();
            TrackId.

        }
    }
}
