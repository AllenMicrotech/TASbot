using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TasBot_Software
{
    public static class HardwareIO
    {
        public static Queue<string> incomming;
        public static Queue<string> outgoing;
        public static Thread hardwareThread;

        public static void Init()
        {

        }

        public static void Start()
        {
            hardwareThread = new Thread(HardwareThread);
            hardwareThread.IsBackground = true;
            hardwareThread.Start();
        }

        public static void Stop()
        {
            hardwareThread.Abort();
        }

        public static void Restart()
        {
            if (hardwareThread.IsAlive)
            {
                hardwareThread.Abort();
            }
            Start();
        }

        public static void SendMessage(string message)
        {
            outgoing.Enqueue(message);
        }

        public static bool HasIncomming()
        {
            if (incomming.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static void HardwareThread()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(1);
                }
            }
            catch (Exception exc)
            {

            }
        }
    }
}
