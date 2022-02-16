using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasi
{
      class Loger
    {
        private static Loger instance;

        

        public LogLevel Loglevel { get; set; }
        protected Loger()
        {
            results = new List<Result>();
        }
        private  List <Result> results { get;  set; }

        public  static Loger Instance
        {
            get
            { 
            if (instance == null)
                instance = new Loger();
            return instance;
            }
        }
        public void AddLog(Result result)
        {
           results.Add(result);




        }
       
         public void Show ()
        {
            foreach (Result result in results)
            {
                if (result.Status == this.Loglevel)
                {

                    string log =  $" время: {result.dateTime} тип {Loglevel.ToString()} сообщение ";
                    Console.WriteLine(log);
                }
            }
        }
        
    }
}
