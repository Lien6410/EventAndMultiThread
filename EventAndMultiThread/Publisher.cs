using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndMultiThread
{
    public class Publisher
    {
        public event EventHandler<string> OnEvent;

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                if (OnEvent!=null)
                {
                    OnEvent.Invoke(this, value);
                }
            }
        }

        public void Foo(string msg)
        {
            if (OnEvent != null)
            {
                OnEvent.Invoke(this, msg);
            }
        }

        public event EventHandler<string> OnEvent2;
        private string message2;
        public string Message2
        {
            get { return message2; }
            set
            {
                message2 = value;
                if (OnEvent2 != null)
                {
                    OnEvent2.Invoke(this, value);
                }
            }
        }
    }

    public class Publisher3
    {
        public event EventHandler<string> OnEvent3;

        private string message3;
        public string Message3
        {
            get { return message3; }
            set
            {
                message3 = value;
                if (OnEvent3 != null)
                {
                    OnEvent3.Invoke(this, value);
                }
            }
        }
    }
}
