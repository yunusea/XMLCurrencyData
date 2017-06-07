using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback callback = new TimerCallback(TimerCallback);

            Timer t = new Timer(callback, null, 0, 60000 * 5);

            for (;;)
            {
            }
        }

        private static void TimerCallback(Object o)
        {
            GetData.Run();
        }
    }
}
