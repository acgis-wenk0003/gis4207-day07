using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program

    {
        static void Main(string[] args)
        {
            int count_number = 12;
            //CountDownWithFor(count_number);
            //CountDownWithWhile(count_number);
            CountDownWithDo(count_number);
            Console.ReadLine();
        }
    
    /// count to 0 to value skipping 1
     
        public static void CountDownWithFor(int fromValue)
        {
            for (int i = fromValue; i>=0; i--)
            {
      
                if (i == 1)
                {
                    continue;
                 
                }
               
                Console.WriteLine(i);
                    
                    
            }
        }
        public static void CountDownWithWhile(int fromValue)
        {
            int i = fromValue;
            while (i > -1)
            {
                if (i == 1)
                {
                    i -= 1;
                    continue;
                }
                Console.WriteLine(i);
                i -= 1;
            }
        }
        public static void CountDownWithDo(int fromValue)
        {
            int i = fromValue;
            do
            {                
                if (i == 1)
                {
                    i -= 1;
                }
                Console.WriteLine(i);
                i -= 1;
            } while (i > -1);
        }
    }
}
