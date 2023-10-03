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
using System.ComponentModel;

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

        public partial class FrmMain : Form
        {
           /* public Form1()
            {
                InitializeComponent();
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.WorkerSupportsCancellation = true;
            }
            */

            private void buttonSearch_Click(object sender, EventArgs e)
        {
            TrId = new TrackId();
            TrId.clearAll();
            if (textBoxTrackId.TextLength != 10)
            {
                MessageBox.Show("TrackId Inválido", "TrackId - Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                progressBarTrackId.Maximum = 100;
                progressBarTrackId.Step = 1;
                progressBarTrackId.Value = 0;
                backgroundWorker
            }

        }
    }
}
