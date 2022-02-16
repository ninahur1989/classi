using System;

namespace klasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loger.Instance.Loglevel = LogLevel.Info;
         
            Starter.Run();
            Loger.Instance.Show();

            //





        }
    }
    public struct Result
    {
        public LogLevel Status { get; set; }
    public string Message { get; set; }
    public DateTime dateTime { get; set; }
        public Result(LogLevel status , string message , DateTime dateTime)
        {
          this.Status = status;
          this.Message = message;
          this.dateTime = dateTime;
        }
    }
    public enum LogLevel
    {
        Info,
        Warning,
        Error,

    }
}
