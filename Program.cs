using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkStudent
{

    class Program
    {
        static void Main(string[] args)
        {
            mark();
        }

        public static void mark()
        {
            try
            {
                Console.WriteLine("Entet number students");
                int numS = Convert.ToInt32(Console.ReadLine());
                if (numS > 100)
                {
                    Console.WriteLine("please Enter less 100 studens");
                    mark();
                }
                else
                {
                    List<String> name = new List<string>(numS);

                    List<double> mark = new List<double>(numS);
                    for (int i = 0; i < numS; i++)
                    {
                        Console.WriteLine("Entet name student : ");
                        name.Add(Console.ReadLine());
                        Console.WriteLine("Entet mark student : ");
                        mark.Add(Convert.ToDouble(Console.ReadLine()));

                    }
                    for (int i = 0; i < numS; i++)
                    {
                        if (mark[i] > 60)
                        {
                            Console.WriteLine(name[i] + ": " + mark[i] + " pass");
                        }
                        else
                        {
                            Console.WriteLine(name[i] + ": " + mark[i] + " fail");
                        }

                    }

                }
            
            }catch(FormatException Fx)
            {
                Console.WriteLine("please Enter same order ", Fx.Message);
                mark();
            }catch(Exception ex)
            {
                Console.WriteLine("please agin");
                mark();
            }
        }


    }
}
