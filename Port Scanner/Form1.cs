using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;

namespace Port_Scanner
{
    public partial class portScanner : Form
    {
        private static ManualResetEvent connectDone = new ManualResetEvent(false);

        public portScanner()
        {
            InitializeComponent();
        }

        private void portScan(object sender, EventArgs eventArgs)
        {
            scanProgress.Value = 0;
            scanProgress.Visible = true;
            Cursor = Cursors.WaitCursor;

            if (inputIP.Text.Trim() == "" || inputIP.Text == "Ex: 192.168.1.1")
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
                TcpClient client = new TcpClient();
                if (singlePorting.Checked)
                {
                    client.Connect(inputIP.Text.ToString(), firstPort);
                    portStatus(firstPort, true);
                }
                else
                {
                    int progress = 100 / (int.Parse(port2.Text) - firstPort);
                    for(int x = firstPort; x <= int.Parse(port2.Text); x++)
                    {
                        TcpClient secondClient = new TcpClient();
                        var connect = secondClient.BeginConnect(inputIP.Text.ToString(), x, null, null);

                        if(connect.AsyncWaitHandle.WaitOne(100))
                        {
                            portStatus(x, true);
                        }
                        else
                        {
                            portStatus(x, false);
                        }
                        scanProgress.Value += progress;
                    }
                }
            }
            catch (Exception)
            {
                if (singlePorting.Checked) { portStatus(firstPort, false); }
            }

        scanProgress.Value = 100;
        Cursor = Cursors.Default;
        //scanProgress.Visible = false;
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

        private void portStatus(int portNum, bool opened)
        {
            if(opened)
            {
                portList.Items.Add(new ListViewItem(new string[] { portNum.ToString(), "Open"}));
            }
            else
            {
                portList.Items.Add(new ListViewItem(new string[] { portNum.ToString(), "Closed" }));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            portList.Items.Clear();
        }

        private void inputIP_Enter(object sender, EventArgs e)
        {
            if(inputIP.Text == "Ex: 192.168.1.1")
            {
                inputIP.Text = "";
                inputIP.ForeColor = Color.Black;
            }
        }

        private void inputIP_Leave(object sender, EventArgs e)
        {
            if (inputIP.Text == "")
            {
                inputIP.Text = "Ex: 192.168.1.1";
                inputIP.ForeColor = Color.Silver;
            }
        }
    }
}
