using RosSharp.RosBridgeClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MoblieRobotSystem.Utilities.RosCommunication
{
    public abstract class WinformSubscriber<T> where T : RosSharp.RosBridgeClient.Message
    {
        //Field
        public string Topic;
        public float TimeStep;

        private RosConnector rosConnector;
        private readonly int SencondsTimeout = 1;
        public bool isSubscribe = false;
        public string subscriptionId;

        //Constructor
        public WinformSubscriber(RosConnector rosConnector)
        {
            this.rosConnector = rosConnector;
        }


        //Methods
        public virtual void SubscriberStart()
        {
            new Thread(Subscribe).Start();

        }

        public virtual void SubscriberStop()
        {
            Unsubscribe();

        }

        private void Subscribe()
        {
            if (!isSubscribe)
            {
                if (rosConnector.isConneted != null)
                {
                    if (!rosConnector.isConneted.WaitOne(SencondsTimeout * 1000))
                        Debug.WriteLine("Failed to subscribe: RosConnector not connected");
                    else
                    {
                        subscriptionId = rosConnector.rosSocket.Subscribe<T>(Topic, ReceiveMessage, (int)(TimeStep * 1000));
                        isSubscribe = true;
                        Debug.WriteLine("Topic: "+ this.Topic + "~~~~~~~~~~~~~~~~Subscribed~~~~~~~~~~~~~~~~");
                    }
                }
            }
        }

        private void Unsubscribe()
        {
            if (isSubscribe)
            {
                if (rosConnector.isConneted != null)
                {
                    if (!rosConnector.isConneted.WaitOne(SencondsTimeout * 1000))
                        Debug.WriteLine("Failed to unsubscribe: RosConnector not connected");
                    else
                    {
                        rosConnector.rosSocket.Unsubscribe(subscriptionId);
                        isSubscribe = false;
                        Debug.WriteLine("Topic: " + this.Topic + "~~~~~~~~~~~~~~~~Unsubscribed~~~~~~~~~~~~~~~~");
                    }
                }
            }
        }

        protected abstract void ReceiveMessage(T message);

    }
}
