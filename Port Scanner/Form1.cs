using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Port_Scanner
{
    public partial class portScanner : Form
    {
        public portScanner()
        {
            InitializeComponent();
        }

        private void newScan_Click(object sender, EventArgs e)
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
            TcpClient client = new TcpClient();
            IPAddress host = new IPAddress(ip);

            client.BeginConnect(host, 80, new AsyncCallback(ConnectCallback), client);


            Cursor = Cursors.Default;
        }

        static void ConnectCallback(IAsyncResult result)
        {
            if(result.IsCompleted)
            {
                Console.WriteLine("Test Worked"); 
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
    }
}
