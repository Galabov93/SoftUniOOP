
namespace Logger.Layouts
{
    using System;

    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string LayoutFormat(string msg, ReportLevel treshold, DateTime date)
        {
            var output = string.Format("{0} - {1} - {2}", date, msg, treshold);

            return output;
        }
    }
}
