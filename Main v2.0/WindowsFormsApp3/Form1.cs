using System;

using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace WindowsFormsApp3
{
    public partial class EduCredit : Form
    {
        public int counter = 0;
        public bool globalNet = true;

        public EduCredit()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            MainWindow.Navigate("https://enter.vlevski.eu/educredit/main/?id="+ Timestamp);

            timer1.Start();
            timer1.Interval = 1000;
        }

        private void MainWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (counter <= 100)
                {
                    counter += 20;
                }

                if (counter >= 100)
                {
                    bool netconnection = NetworkInterface.GetIsNetworkAvailable();
                    counter = 0;

                    DriveInfo c = new DriveInfo("C");
                    double cAvailableSpace = c.AvailableFreeSpace / (1024 * 1024);

                    if ( cAvailableSpace < 1024 ) //MEGABYTES
                    {
                        noSpace.Icon = SystemIcons.Exclamation;
                        noSpace.BalloonTipTitle = "No available space";
                        noSpace.BalloonTipText = "There is not enough space on drive C!";
                        noSpace.BalloonTipIcon = ToolTipIcon.Error;
                        noSpace.Visible = true;
                        noSpace.ShowBalloonTip(5000);
                        this.Enabled = false;
                    }


                    if ( netconnection == true && globalNet == true )
                    {
                        noInternet.Icon = SystemIcons.Exclamation;
                        noInternet.BalloonTipTitle = "No internet";
                        noInternet.BalloonTipText = "There was a problem connecting to the itnernet!";
                        noInternet.BalloonTipIcon = ToolTipIcon.Info;
                        noInternet.Visible = true;
                        noInternet.ShowBalloonTip(5000);
                        this.Enabled = false;
                        netLabel.Visible = true;
                        globalNet = false;
                    }

                    else if ( netconnection == false && globalNet == false )
                    {
                        globalNet = true;

                        this.Enabled = true;
                        netLabel.Visible = false;
                    }
                }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }

        private void netLabel_Click(object sender, EventArgs e)
        {

        }
    }
}