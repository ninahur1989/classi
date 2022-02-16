using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasi
{
     static internal class Starter
    {
        public static void Run()
        {
            Random random = new Random();
            

            for(int i = 0; i < 15; i++)
            {

                int r = random.Next(0,3);
                Result result= new Result();
                if (r == 0) 
                    result = Actions.ErrorAction();
                   

                if (r == 1)
                    result =  Actions.InfoAction();
                if (r == 2)
                    result =  Actions.WarningAction();
                Loger.Instance.AddLog(result);
                
            }

        }
    }
  
    
    
}
