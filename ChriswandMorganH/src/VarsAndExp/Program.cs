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
            double dd = Dms2Dd(50, 40, 22.11, "S");
            Console.WriteLine("Expected value: -50.67281\nActual value: " + Convert.ToString(dd));
            scopeTest();
            Console.ReadLine();
        }
        static void scopeTest()
        {
            FlowControl.Program.g_publicVar = "Public";
            // The following lines do not work, they must be set to public to work properly
            //When set to internal or private they are only accessible within the project or 
            //class respecitvely, that they are defined in 
            //FlowControl.Program._internalVar = "Internal"; 
            //FlowControl.Program._privateVar = "Private";
        }
    
    ///  convert degree minutes seconds to decimal degrees
        public static double Dms2Dd(int deg, int min, double sec, string bearing)
        {
            if (deg < 0 || min < 0 || sec < 0)
            {
                return 9999;
            }
            if (min >= 60 || sec >= 60)
            {
                return 9999;
            }

            switch (bearing)
            {
                case "E":
                    {
                        if (deg > 180)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "e":
                    {
                        if (deg > 180)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "W":
                    {
                        if (deg > 180)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "w":
                    {
                        if (deg > 180)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "N":
                    {
                        if (deg > 90)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "n":
                    {
                        if (deg > 90)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "S":
                    {
                        if (deg > 90)
                        {
                            return 9999;
                        }
                    }
                    break;
                case "s":
                    {
                        if (deg > 90)
                        {
                            return 9999;
                        }
                    }
                    break;

            }

            double minutes = Convert.ToDouble(min) / 60;
            double seconds = sec / 3600;
            double dd = Math.Round((deg + minutes + seconds), 5);

            if (bearing == "S" || bearing == "s" || bearing == "W" || bearing == "w")
            {
                dd = dd * -1;
            }
            return dd;
        }
    }
    
}
