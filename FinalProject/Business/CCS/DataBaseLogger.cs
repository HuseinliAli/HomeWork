using System;

namespace Business.CCS
{
    public class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("lOGGED ADD TO DATABASE");
        }
    }
}
