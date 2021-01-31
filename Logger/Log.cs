using System;
using System.IO;
using System.Text;

namespace Logger
{

        public sealed class Log:ILog
        {
            // To facilitate lazy loading
            // By default lazy keyword is thread safe 
            private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
            // 2. Defined a public property to access the single instance
            public static Log GetInstance
            {
                get
                {
                    return instance.Value;
                }
            }

            //1. Declared private to restrict direct instantiation
            private Log()
            {

            }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log","Exception",DateTime.Now.ToShortDateString());
            string logPath = string.Format(@"{0}\{1}",AppDomain.CurrentDomain.BaseDirectory,fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter sw = new StreamWriter(logPath,true))
            {
                sw.Write(sb.ToString());
                sw.Flush();
            }
        }
    }
}
