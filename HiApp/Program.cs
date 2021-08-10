using System;

namespace HiAppThisGarbage
{
    class Program
    {
        public static string y { get; private set; }
        public static int x { get; private set; }

        public class Mypoints
        {
           
                public  Mypoints(int newx, string newy)
                {
                    int x = newx;
                    string y = newy;
                                   
                }
            

            
        }
        static void Main(string[] args)
            
        {

            Mypoints _position = new Mypoints(x , y );

            Console.WriteLine($"{_position}"); //вывод в консоль "_position"



            String name = Console.ReadLine();

            int Year = 0;
            Year.ToString();
            string Name;
            Name = "He/She";

            Console.WriteLine("What is youre name");
            
            Console.WriteLine( $" {name}");
            {
               
                Console.WriteLine("Привет");

                Console.WriteLine("Добро пожаловать в C#");
                {                    
                    {
                        Name = "SH_ss";
                        Console.WriteLine($" {Name} + {name}");
                        Console.Read();
                    }
                }
            }
        }
    }
}
