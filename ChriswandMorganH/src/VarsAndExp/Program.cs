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
    
    
        static double Dms2Dd(int deg, int min, double sec, string bearing)
        {
            int minutes = min / 60;
            double seconds = sec / 3600; 
            return deg + minutes + seconds;
        }
    }
}
