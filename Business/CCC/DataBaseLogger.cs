using System;

namespace Business.CCC
{
    public class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
