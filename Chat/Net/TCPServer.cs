using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Net
{
    public abstract class TCPServer: MessageConnection,ICloneable
    {
        #region Field region

        private enum Mode { treatClient,treatConnections}
        Mode mode = Mode.treatConnections;
        public TcpClient comm;
        TcpListener waitSock;//ServerSocket in java
        int port;

        #endregion

        #region Property

        public int Port
        {
            get
            {
                return port;
            }
        }

        #endregion

        #region methods

        public void StartServer(int port)
        {
            try
            {
                this.port = port;

                waitSock = new TcpListener(new IPAddress(new byte[] { 127, 0, 0, 1 }), this.port);
                waitSock.Start();

                Console.WriteLine("ServerConnection...");

                new Thread(Run).Start();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        public void StopServer()
        {
            try
            {
                waitSock.Stop();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        public void Run()
        {
            if(mode == Mode.treatClient)
            {
                new Thread(GereClient).Start();
            }
            else if(mode == Mode.treatConnections)
            {
                while(true)
                {
                    comm = waitSock.AcceptTcpClient();

                    Console.WriteLine("conncection established...");
                    try
                    {
                        TCPServer myClone = (TCPServer)this.Clone();
                        myClone.mode = Mode.treatClient;
                        new Thread(new ThreadStart( myClone.Run)).Start();
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    catch (NotSupportedException e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
        }

        #endregion

        #region abstact methods

        abstract public void GereClient();

        #endregion

        #region MessageConnection methods

        public Message GetMessage()
        {
            try
            {
                NetworkStream input = comm.GetStream();

                IFormatter formatter = new BinaryFormatter();
                return (Message)formatter.Deserialize(input);
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public void SendMessage(Message m)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(comm.GetStream(), m);
            }
            catch(SerializationException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch(IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion

        #region Cloneable methods

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion 
    }
}
