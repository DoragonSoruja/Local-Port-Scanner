using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Port_Scanner
{
    public partial class portScanner : Form
    {
        private static ManualResetEvent connectDone = new ManualResetEvent(false);

        public portScanner()
        {
            InitializeComponent();
        }

        private void newScan_Click(object sender, EventArgs eventArgs)
        {
            scanProgress.Value = 0;
            scanProgress.Visible = true;
            Cursor = Cursors.WaitCursor;
            resultBox.Clear();

            if(inputIP.Text.Trim() == "")
            {
                Cursor = Cursors.Default;   
                MessageBox.Show("Enter in a valid IP address.");
                return;
            }

            if(port1.Text.Trim() == "")
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Enter a port number.");
                return;
            }

            int firstPort = int.Parse(port1.Text);

            try
            {
                using (var client = new TcpClient())
                {
                    if (singlePorting.Checked)
                    {
                        client.Connect(inputIP.Text.ToString(), firstPort);
                        resultBox.Text += ("Port " + port1.Text + " is Open.\n" + Environment.NewLine + "-------------------------------" + Environment.NewLine);
                    }
                    else
                    {
                        int progress = 100 / (int.Parse(port2.Text) - firstPort);
                        for(int x = firstPort; x <= int.Parse(port2.Text); x++)
                        {
                            try
                            {
                                TcpClient secondClient = new TcpClient();
                                secondClient.Connect(inputIP.Text.ToString(), x);
                                resultBox.Text += ("Port " + x.ToString() + " is Open.\n" + Environment.NewLine + "-------------------------------" + Environment.NewLine);
                            }
                            catch (Exception)
                            {
                                resultBox.Text += "Port " + x.ToString() + " is Closed.\n" + Environment.NewLine + "-------------------------------" + Environment.NewLine;
                            }
                            scanProgress.Value += progress;
                        }
                    }
                }
            }
            catch (Exception)
            {
                if (singlePorting.Checked) { resultBox.Text += "Port " + firstPort.ToString() + " is Closed.\n" + Environment.NewLine + "-------------------------------" + Environment.NewLine; }
            }

            scanProgress.Value = 100;
            Cursor = Cursors.Default;
            scanProgress.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(singlePorting.Checked)
            {
                label3.Visible = false;
                port2.Visible = false;
            }
            else
            {
                label3.Visible = true;
                port2.Visible = true;
            }
        }
    }
}
