using RosSharp.RosBridgeClient.MessageTypes.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosSharp.RosBridgeClient.MessageTypes.Std;
using System.Diagnostics;

namespace MoblieRobotSystem.Utilities.RosCommunication
{
    public class Float32MultiArraySubscriber : WinformSubscriber<Float32MultiArray>
    {
        //Field
        public Float32MultiArray float32MultiArray;
        public float[] data = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
        
        //Constructor
        public Float32MultiArraySubscriber(RosConnector rosConnector) : base(rosConnector) { }

        //Methods
        public override void SubscriberStart()
        {
            base.SubscriberStart();
        }
        public override void SubscriberStop()
        {
            base.SubscriberStop();
        }

        protected override void ReceiveMessage(Float32MultiArray message)
        {
            data = message.data;
            Debug.WriteLine("Topic: " + this.Topic + "IMU.x: " + data[0] + "  IMU.y : " + data[1] + "  IMU.z : " + data[2]);
        }
    }
}
