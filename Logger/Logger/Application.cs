using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Appenders;
using Logger.Interfaces;

namespace Logger
{
    using global::Logger.Layouts;

    public class Application
    {
        public static void Main(string[] args)
        {
            ILayout layout = new SimpleLayout();
            IAppender appender = new ConsoleAppender(layout);

            Logger logger = new Logger(appender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");
        }
    }
}
