using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventAndMultiThread
{
    public class Subscriber
    {
        public void ShowMessage(object sender, string msg)
        {
            Thread.Sleep(30000);
            var temp = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{temp} [Sub1] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");
        }

        public void ShowMessage2(object sender, string msg)
        {
            Thread.Sleep(30000);
            var temp = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{temp} [Sub2] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");
        }
    }

    public class Subscriber3
    {
        public void ShowMessage3(object sender, string msg)
        {
            Thread.Sleep(30000);
            var temp = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{temp} [Sub3] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");
        }

    }
}
