
namespace Logger.Appenders
{
    using System;
    using global::Logger.Interfaces;

    public abstract class Appender : IAppender
    {
        private ILayout layout;


        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout
        {
            get
            {
                return this.layout;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The layout cannnot be null");
                }

                this.layout = value;
            }
        }

        public abstract void Append(string msg, ReportLevel treshold, DateTime date);
    }
}
