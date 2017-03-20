using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
          int len = 255;
          for(int i=1; i<= len; i++ )
          {
             Console.WriteLine(i);
          }
          for(int i=1; i<= len; i++ )
          {
             if(i%5==0)
             {
                 Console.WriteLine("Buzz" + i);
             }
             else if(i%3==0)
             {
                 Console.WriteLine("Fizz" + i);
             }
          }
                    
        }
    }
}
