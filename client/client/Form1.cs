using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class frmClient : Form
    {
        public const int nb = 1024;

        public frmClient()
        {
            InitializeComponent();
        }

        public static void StartClient(ListBox lb)
        {
            byte[] bytes = new byte[nb];
            int num = 0;
            Random rnd = new Random();

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    lb.Items.Add("Connesso con " + sender.RemoteEndPoint.ToString());

                    num = rnd.Next(0, 10);
                    byte[] msg = Encoding.ASCII.GetBytes(num.ToString() + "<EOF>");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);

                    lb.Items.Add("Numero estratto: " + Encoding.ASCII.GetString(bytes, 0, (bytesRec - 5)));

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            StartClient(listBox1);
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            StartClient(listBox1);
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
