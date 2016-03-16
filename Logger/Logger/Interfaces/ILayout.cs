
namespace Logger.Interfaces
{
    using System;

    public interface ILayout
    {
        string LayoutFormat(string msg, ReportLevel treshold, DateTime date);

    }
}