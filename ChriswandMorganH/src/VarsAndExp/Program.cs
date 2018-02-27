using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsAndExp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    
    
    ///  convert degree minutes seconds to decimal degrees
        public static double Dms2Dd(int deg, int min, double sec, string bearing)
        {
            int minutes = min / 60;
            double seconds = sec / 3600; 
            return deg + minutes + seconds;
        }
    }
    class Test_Program
    {
        void test()
        {
           
           double p = Program.Dms2Dd(50, 40, 20.11, "N");
           
        }
    }    
}
