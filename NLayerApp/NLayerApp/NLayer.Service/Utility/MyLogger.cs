using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Utility
{
    public class MyLogger : ILogger
    {

        private static MyLogger instance;
        private static Logger logger;

        public MyLogger()
        {

        }

        public static MyLogger GetInstance()
        {
            if (instance == null)
                instance = new MyLogger();
            return instance;
        }

        private Logger GetLogger(string theLogger)
        {
            if (MyLogger.logger == null)
                MyLogger.logger = LogManager.GetLogger(theLogger);
            return MyLogger.logger;
        }

        public void Debug(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("NLayer.*").Debug(message);
            else
                GetLogger("NLayer.*").Debug(message,arg);
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("NLayer.*").Error(message);
            else
                GetLogger("NLayer.*").Error(message, arg);
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("NLayer.*").Info(message);
            else
                GetLogger("NLayer.*").Info(message, arg);
        }

        public void Warning(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("NLayer.*").Warn(message);
            else
                GetLogger("NLayer.*").Warn(message, arg);
        }
    }
}
