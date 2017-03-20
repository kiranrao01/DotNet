using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {

        public static void randomarr()
        {
            Random rnd = new Random();
            int[] arr = new int[10];

            for(int i=0; i<10; i++ )
            {
                int randomnum = rnd.Next(5,25);
                arr[i] = randomnum;
                System.Console.WriteLine(arr[i]);
            }
            int max = arr[0];
            int min = arr[0];
            int sum=0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (max <arr[i] )
                 {
                    max = arr[i];
                 }
                if (arr[i] < min)
                 {
                    min = arr[i];
                 }
                sum = sum + arr[i];
            }
            System.Console.WriteLine("Max value in array is {0}, Min value in array is {1}, Sum is {2}", max, min, sum);
            }

        private static int GetV(int v)
        {
            return v;
        }

        public static void tosscoin()
        {
            int numPlays = 0, numWins = 0;
            int compChoice = 0;
            char userChoice;
            double percentWin;
            Random rnd = new Random();
            while (true)
            {
                Console.Write("\nWrite H/h to guess Heads, T/t to guess Tails, or Q/q to quit =>  ");
                userChoice = Console.ReadKey().KeyChar;
                compChoice = rnd.Next(0, 2);
                if (char.ToLowerInvariant(userChoice) != 'q')
                {
                    if (char.ToLowerInvariant(userChoice) == 'h' && compChoice == 0)
                    {
                            Console.WriteLine("\nYOU WON");
                            numWins++;
                    }
                    else if (char.ToLowerInvariant(userChoice) == 't' && compChoice == 1)
                    {
                            Console.WriteLine("\nYOU WON");
                            numWins++;
                    }
                    else
                    {
                            Console.WriteLine("\nYOU LOSE");
                    }
                    numPlays++;
                }
                else
                {
                    percentWin = (double) numWins/numPlays;
                    Console.WriteLine("\nYou won {0} out of {1} game(s) or {2:P} of the games played.", numWins, numPlays, percentWin);
                    break;
                }


        }
        }
        public static void tossMultipleCoins(int num)
        {
            int numPlays = 0;
            double numWins = 0;
            int compChoice = 0;
            Random rnd = new Random();
            for(int i=0; i< num ; i++){
                // userChoice = Console.ReadKey().KeyChar;
                compChoice = rnd.Next(0,2);
                if (char.ToLowerInvariant(Console.ReadKey().KeyChar) == 'h'&& compChoice == 0  ) 
                {
                    Console.WriteLine("you won");
                    numWins++;
                }
                else if(char.ToLowerInvariant(Console.ReadKey().KeyChar) =='t' && compChoice ==1 )
                {
                    Console.WriteLine("you won");
                
                }
                else
                {
                    Console.WriteLine("you loose");
                }
                numPlays++;
            }
            double result = numWins/num;
        Console.WriteLine("Ratio {0}, {1}, {2}", numWins, numPlays, result);
        }

        public static string[] names()
        {
            Random rnd = new Random();
            string [] names = new string[] {"Todd","Tiffany","Charlie","Geneve","sydney"};
             for (int i = 0; i < names.Length; i++)
            {
                int randomIndex = rnd.Next(i, names.Length);
                string temp = names[i];
                names[i] = names[randomIndex];
                names[randomIndex] = temp;
            }
            for(int k = 0; k<names.Length; k++)
            {
               Console.WriteLine(names[k]);
            }
             Console.WriteLine();
            List<string> mylist = new List<string>();
            for(int k =0; k<names.Length; k++)
            {
                if(names[k].Length > 5)
                {
                    mylist.Add(names[k]);
                }
                
            }
            string[] arr2= new string[mylist.Count];
            for(var idx = 0; idx<mylist.Count; idx++){
                arr2[idx]=mylist[idx];
            }
            for(int i = 0; i< arr2.Length; i++){
                 System.Console.WriteLine(arr2[i]);
            }
             return arr2;
            
        }

        public static void Main(string[] args)
        {
        // randomarr();
        // tosscoin();
        // tossMultipleCoins(3);
        names();

        }
    }
}
    

