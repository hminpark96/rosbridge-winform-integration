using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoblieRobotSystem.Utilities.RosCommunication
{
    public class RosbridgeManager
    {
        //Field
        private static RosbridgeManager instance;
        private RosConnector rosConnector;
        private TwistSubscriber twistSubscriber;
        private Float32MultiArraySubscriber float32MultiArraySubscriber1;
        private Float32MultiArraySubscriber float32MultiArraySubscriber2;
        private Float32MultiArraySubscriber float32MultiArraySubscriber3;


        //Constructor
        private RosbridgeManager()
        {
            //ROS Connect
            rosConnector = new RosConnector();
            //Twist Subscribe
            twistSubscriber = new TwistSubscriber(rosConnector);
            twistSubscriber.Topic = "/cmd_vel";
            twistSubscriber.TimeStep = 0.01f;
            //Float32 Multi Array Subscribe 1
            float32MultiArraySubscriber1 = new Float32MultiArraySubscriber(rosConnector);
            float32MultiArraySubscriber1.Topic = "/robot1_left_vibration";
            float32MultiArraySubscriber1.TimeStep = 0.01f;
            //Float32 Multi Array Subscribe 2
            float32MultiArraySubscriber2 = new Float32MultiArraySubscriber(rosConnector);
            float32MultiArraySubscriber2.Topic = "/robot1_middle_vibration";
            float32MultiArraySubscriber2.TimeStep = 0.01f;
            //Float32 Multi Array Subscribe 3
            float32MultiArraySubscriber3 = new Float32MultiArraySubscriber(rosConnector);
            float32MultiArraySubscriber3.Topic = "/robot1_right_vibration";
            float32MultiArraySubscriber3.TimeStep = 0.01f;
        }

        public static RosbridgeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RosbridgeManager();
                }
                return instance;
            }
        }

        public RosConnector RosConnector
        {
            get { return rosConnector; }
        }
        public TwistSubscriber TwistSubscriber
        {
            get { return twistSubscriber; }
        }
        public Float32MultiArraySubscriber Float32MultiArraySubscriber1
        {
            get { return float32MultiArraySubscriber1; }
        }
        public Float32MultiArraySubscriber Float32MultiArraySubscriber2
        {
            get { return float32MultiArraySubscriber2; }
        }
        public Float32MultiArraySubscriber Float32MultiArraySubscriber3
        {
            get { return float32MultiArraySubscriber3; }
        }

        //Methods
        public void RosConnect() { rosConnector.Connect(); }
        public void RosDisconnect() { rosConnector.Disconnect(); }
        public void TwistSubscriberStart() { twistSubscriber.SubscriberStart(); }
        public void TwistSubscriberStop() { twistSubscriber.SubscriberStop(); }
        public void Float32MultiArraySubscriber1Start() { float32MultiArraySubscriber1.SubscriberStart(); }
        public void Float32MultiArraySubscriber1Stop() { float32MultiArraySubscriber1.SubscriberStop(); }
        public void Float32MultiArraySubscriber2Start() { float32MultiArraySubscriber2.SubscriberStart(); }
        public void Float32MultiArraySubscriber2Stop() { float32MultiArraySubscriber2.SubscriberStop(); }
        public void Float32MultiArraySubscriber3Start() { float32MultiArraySubscriber3.SubscriberStart(); }
        public void Float32MultiArraySubscriber3Stop() { float32MultiArraySubscriber3.SubscriberStop(); }
    }
}
