using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThird
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
}
