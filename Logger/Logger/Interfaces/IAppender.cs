using System;

namespace Logger.Interfaces
{
    public interface IAppender
    {
        void Append(string msg, ReportLevel treshold, DateTime date);
    }
}
