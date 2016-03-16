

namespace Logger
{
    using System;
    using global::Logger.Interfaces;

    public class Logger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public Logger(IAppender appender1, IAppender appender2)
        {
            this.Appender = appender1;
            this.SecondAppender = appender2;
        }

        public IAppender Appender { get; set; }

        public IAppender SecondAppender { get; set; }

        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }


        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel treshold)
        {
            var dateTime = DateTime.Now;
            this.Appender.Append(msg, treshold, dateTime);
        }
    }
}
