using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasi
{
    internal static class Actions
    {
        public static Result InfoAction()
        {
            return new Result(LogLevel.Info, "this is info", DateTime.Now);

        }
        public static Result WarningAction()
        {
            return new Result(LogLevel.Warning , "this is info", DateTime.Now);


        }
        public static Result ErrorAction()
        {
            return new Result(LogLevel.Error , "this is info", DateTime.Now);
        } 
    }
}
