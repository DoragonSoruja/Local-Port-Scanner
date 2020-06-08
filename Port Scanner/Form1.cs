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

            long ip;
            Int64.TryParse(inputIP.Text, out ip);
            // Scan Ports
            IPAddress ipAddress = new IPAddress(ip);

            try
            {
                TcpListener tcpListener = new TcpListener(ipAddress, 80);
                tcpListener.Start(0);

                TcpClient client = tcpListener.AcceptTcpClient();
                client.Close();

                tcpListener.Stop();
            }
            catch (Exception e)
            {
                resultBox.Text += e.ToString();
            }

            Cursor = Cursors.Default;
        }
    }
}
