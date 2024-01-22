using System.Diagnostics;
using RosSharp.RosBridgeClient;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace MoblieRobotSystem.Utilities.RosCommunication
{
    public class TwistSubscriber : WinformSubscriber<Twist>
    {
        //Field
        public Vector3 linearVelocity = new Vector3(0, 0, 0);
        public Vector3 angularVelocity = new Vector3(0, 0, 0);

        //Constructor
        public TwistSubscriber(RosConnector rosConnector) : base(rosConnector) { }

        //Methods
        public override void SubscriberStart()
        {
            base.SubscriberStart();
        }
        public override void SubscriberStop()
        {
            base.SubscriberStop();
        }

        protected override void ReceiveMessage(Twist message)
        {
            linearVelocity = message.linear;
            angularVelocity = message.angular;
            Debug.WriteLine("Topic: " + this.Topic + "Linear.x: " + linearVelocity.x + "  Angular.z: " + angularVelocity.z);
        }
    }
}
