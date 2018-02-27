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
            double dd = Dms2Dd(50, 40, 22.11, "N");
            Console.ReadLine();
        }
    
    
    ///  convert degree minutes seconds to decimal degrees
        public static double Dms2Dd(int deg, int min, double sec, string bearing)
        {
            int minutes = min / 60;
            double seconds = sec / 3600; 
            return deg + minutes + seconds;
        }
    }
    
}
