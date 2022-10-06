using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace server
{
    class Program
    {

        public static string data = null;

        public static void StartListening()
        {
            byte[] bytes = new Byte[1024]; //bytes a disposizione per i dati
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            //creo un socket TCP/IP 
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                //il socket si attiva e aspetta una connessione da parte di un client
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("In attesa di connessione...");
                    //attende finché non avviene una connessione
                    Socket handler = listener.Accept(); //il socket, essendo sincrono e bloccante, finché non arriva un messaggio si mette in attesa
                    data = null;

                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes); //prende fino a 1024 byte del messaggio e li mette nell'array bytes
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec); //concatena in data un carattere dopo l'altro, convertito in ASCII, dell'array bytes
                        if (data.IndexOf("<EOF>") > -1) //se la stringa "<EOF>" è presente in data, esce dal ciclo
                        {
                            break;
                        }
                    }

                    StringBuilder sb = new StringBuilder(data, 50);
                    sb.Remove(1, 5); //rimuovo "<EOF>"
                    Console.WriteLine("Numero ricevuto: " + sb);

                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    handler.Send(msg); //il socket manda il messaggio al client
                    handler.Shutdown(SocketShutdown.Both); //chiude la connessione sia del server che del client
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPremi INVIO per continuare...");
            Console.Read();

        }

        static void Main(string[] args)
        {
            StartListening();
        }
    }
}
