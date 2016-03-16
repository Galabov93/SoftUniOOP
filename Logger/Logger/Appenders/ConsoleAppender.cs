
namespace Logger.Appenders
{
    using System;

    using global::Logger.Interfaces;

    public class ConsoleAppender : Appender, IAppender
    {
        private const int ReportLevelTreshold = 3;

        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string msg, ReportLevel level, DateTime date)
        {
            var output = this.Layout.LayoutFormat(msg, level, date);
            if (level >= (ReportLevel)2)
            {
                Console.WriteLine(output);
            }
        }
    }
}
