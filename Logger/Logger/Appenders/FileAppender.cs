
namespace Logger.Appenders
{
    using System;
    using System.IO;
    using global::Logger.Interfaces;

    public class FileAppender : Appender, IAppender
    {
        public FileAppender(string path, ILayout layout) : base(layout)
        {
            this.Path = path;
        }

        public string Path { get; set; }

        public override void Append(string msg, ReportLevel treshold, DateTime date)
        {
            StreamWriter writer = new StreamWriter(this.Path, true);
            writer.WriteLine(this.Layout.LayoutFormat(msg, treshold, date));
            writer.Close();
        }
    }
}
