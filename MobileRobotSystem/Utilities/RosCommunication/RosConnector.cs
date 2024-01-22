using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using RosSharp.RosBridgeClient;
using RosSharp.RosBridgeClient.Protocols;



namespace MoblieRobotSystem.Utilities.RosCommunication
{
    public class RosConnector
    {

        //Field
        public int secondsTimeout = 3;
        public RosSocket rosSocket { get; private set; }
        public Protocol protocol;
        public string RosBridgeServerUrl = "ws://192.168.0.50:9090"; //default

        public ManualResetEvent isConneted { get; private set; }


        //Methods
        protected void ConnectAndWait()
        {
            rosSocket = ConnetToRos(protocol, RosBridgeServerUrl, OnConnected, OnClosed);

            if (!isConneted.WaitOne(secondsTimeout * 1000))
            {
                Debug.WriteLine("Failed to connect to RosBridge at: " + RosBridgeServerUrl);
            }
        }
        public static RosSocket ConnetToRos(Protocol protocolType, string serverUrl, EventHandler onConnected = null, EventHandler onClosed = null)
        {
            IProtocol protocol = ProtocolInitializer.GetProtocol(protocolType, serverUrl);
            protocol.OnConnected += onConnected;
            protocol.OnClosed += onClosed;

            return new RosSocket(protocol);
        }

        public void Connect()
        {
            isConneted = new ManualResetEvent(false);
            new Thread(ConnectAndWait).Start();
        }

        public void Disconnect()
        {
            if (isConneted != null)
            {
                isConneted.Reset();
                Debug.WriteLine("Disconnected from RosBridge: " + RosBridgeServerUrl);
                rosSocket.Close();
            }
        }

        private void OnConnected(object sender, EventArgs e)
        {
            isConneted.Set();
            Debug.WriteLine("Connected to RosBridge: " + RosBridgeServerUrl);

        }

        private void OnClosed(object sender, EventArgs e)
        {
            isConneted.Reset();
            Debug.WriteLine($"Disconnected from RosBridge {RosBridgeServerUrl}");
        }

    }
}
