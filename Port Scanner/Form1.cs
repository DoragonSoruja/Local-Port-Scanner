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
            Cursor = Cursors.WaitCursor;
        
            if(inputIP.Text.Trim() == "")
            {
                Cursor = Cursors.Default;   
                MessageBox.Show("Enter in a valid IP address");
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
                        resultBox.Text += ("Port " + port1.Text + " is Open\n" + Environment.NewLine);
                    }
                    else
                    {
                        for(int x = firstPort; x <= int.Parse(port2.Text); x++)
                        {
                            try
                            {
                                using (var secondClient = new TcpClient())
                                {

                                    client.Connect(inputIP.Text.ToString(), x);
                                    resultBox.Text += ("Port " + port1.Text + " is Open\n" + Environment.NewLine);
                                }
                            }
                            catch(Exception e)
                            {
                                resultBox.Text += "Port " + x.ToString() + " is Closed\n" + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                resultBox.Text += "Port Closed\n" + Environment.NewLine;
            }

            Cursor = Cursors.Default;
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
