using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventAndMultiThread
{
    public class TestEnviroment
    {
        private Publisher publisher;
        private Subscriber subscriber;
        private Publisher3 publisher3;
        private Subscriber3 subscriber3;

        public TestEnviroment()
        {
            publisher = new Publisher();
            subscriber = new Subscriber();
            publisher3 = new Publisher3();
            subscriber3 = new Subscriber3();

            publisher.OnEvent += subscriber.ShowMessage;
            publisher.OnEvent2 += subscriber.ShowMessage2;
            publisher3.OnEvent3 += subscriber3.ShowMessage3;

            Thread myThd1 = new Thread(new ThreadStart(Test1));
            myThd1.IsBackground = true;           

            Thread myThd2 = new Thread(new ThreadStart(Test2));
            myThd2.IsBackground = true;          

            Thread myThd3 = new Thread(new ThreadStart(Test3));
            myThd3.IsBackground = true;

            Thread myThd4 = new Thread(new ThreadStart(Test4));
            myThd4.IsBackground = true;

            myThd1.Start();
            Thread.Sleep(5);
            myThd2.Start();
            Thread.Sleep(10);
            myThd3.Start();
            Thread.Sleep(5);
            myThd4.Start();

        }

        private void Test4()
        {
            string msg = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{msg} [Test4] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");

            //publisher.Message = msg;
            publisher.Foo(msg);
        }

        private void Test3()
        {
            string msg = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{msg} [Test3] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");

            publisher3.Message3 = msg;
        }

        private void Test2()
        {
            string msg = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{msg} [Test2] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");

            publisher.Message2 = msg;
        }

        private void Test1()
        {
            string msg = DateTime.Now.ToString("MM/dd hh:mm:ss:fff");
            Console.WriteLine($"{msg} [Test1] : ThdId = {Thread.CurrentThread.ManagedThreadId} : Input = {msg}");

            publisher.Message = msg;
        }
    }
}
