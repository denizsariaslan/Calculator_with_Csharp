using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deniz_Review
{
    class Program
    {
        public static int firstValue { get; set; }
        public static int secondValue { get; set; }

        static void Main(string[] args)
        {


            Calculator cal = new Calculator();

            Console.WriteLine("Well come to do Calculator, what would like to do? Your options are sum/sub/div/multi ");

            while (true)
            {
                firstValue = 0;
                secondValue = 0;
                // save key function
                string key = Console.ReadLine();
                string process = null;

                if (key == "sum" || key == "sub" || key == "div" || key == "multi")
                {

                    switch (key)
                    {
                        case "sum":
                            process = "sum";
                            break;
                        case "sub":
                            process = "sub";
                            break;
                        case "div":
                            process = "div";
                            break;
                        case "multi":
                            process = "multi";
                            break;
                        
                    }
                
 

                    Console.WriteLine("Isleminiz :" + process);


                    while (firstValue == 0 || secondValue ==0)
                    {
                        setValues();
                    }



                int result = 0;

                    switch (process)
                    {
                        case "sum":
                            result = cal.sum(firstValue, secondValue);
                            break;
                        case "sub":
                            result = cal.sub(firstValue, secondValue);
                            break;
                        case "div":
                            result = cal.divide(firstValue, secondValue);
                            break;
                        case "multi":
                            result = cal.multiply(firstValue, secondValue);
                            break;
                        default:
                            Console.WriteLine("Your process should be sum/sub/div/multi values");
                            break;
                    }

                    Console.WriteLine("Your " + process + " result is " + result);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please Enter either sum/sub/div/multi function ");


                }
            }
        }

        public static void setValues()
        {
            Console.WriteLine("Enter your first value ");

            //first entered number from command line
            string first = Console.ReadLine();

            Console.WriteLine("Enter your second value ");

            //second entered number from command line
            string second = Console.ReadLine();

            try
            {         
                firstValue = int.Parse(first);
                secondValue = int.Parse(second);
            }
            catch { Console.WriteLine("Please enter a valid integer number"); }
        }
    }
}
