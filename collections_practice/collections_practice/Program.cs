using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Three Basic Arrays
        //     int[] arr = new int[] {0,1,2,3,4,5,6,7,8,9};
        //     foreach(int var in arr)
        //     {
        //         Console.WriteLine(var);
        //     }

        //     string[] names;
        //      names = new string[]{"Sai","Ram","Ghani"};
        //      foreach(string name in names)
        //     {
        //         Console.WriteLine(name);
        //     }
            
        //     bool[] trueOrfalse;
        //     trueOrfalse = new bool[10]{true,false,true,false,true,false,true,false,true,false};
        //     foreach(bool valu in trueOrfalse)
        //     {
        //         Console.WriteLine(valu);
        //     }
           
// Multiplication Table
            // int[,] multy = new int[10,10]; 
            //     for (int i = 0; i <= 10; i++)
            //     {
            //         for (int j = 0; j <= 10; j++)
            //         {
            //         multy[i,j] = (i + 1) * (j + 1);
            //         }               
            //         Console.WriteLine(multy);
            //     }

// Dictionary
            // Dictionary <string,string> profile = new Dictionary<string,string>();
            // profile.Add("Name", "Sai");
            // profile.Add("Fav Sport", "Cricket");
            // profile.Add("Num of Pets", "4");
            // profile.Add("Do you like Ice Cream", "True");
            // foreach (var data in profile)
            // {
            //     Console.WriteLine(data.Key + " - " + data.Value);
            // }

            // string[] names;
            //  names = new string[]{"Tim","Martin","Nikki","Sara"};
            //  foreach(string name in names)
            // {
            //     Console.WriteLine(name);
            // }

            Dictionary <string,string> Tim = new Dictionary<string,string>();
            Tim.Add("Name", "Tim");
            Tim.Add("Fav Sport", "Cricket");
            Tim.Add("Num of Pets", "4");
            Tim.Add("Do you like Ice Cream", "True");

            Dictionary <string,string> Martin = new Dictionary<string,string>();
            Martin.Add("Name", "Marti");
            Martin.Add("Fav Sport", "Cricket");
            Martin.Add("Num of Pets", "1");
            Martin.Add("Do you like Ice Cream", "False");

            Dictionary <string,string> Nikki = new Dictionary<string,string>();
            Nikki.Add("Name", "Nikki");
            Nikki.Add("Fav Sport", "Tennis");
            Nikki.Add("Num of Pets", "1");
            Nikki.Add("Do you like Ice Cream", "False");

            Dictionary <string,string> Sara = new Dictionary<string,string>();
            Sara.Add("Name", "Sara");
            Sara.Add("Fav Sport", "Swiming");
            Sara.Add("Num of Pets", "2");
            Sara.Add("Do you like Ice Cream", "False");

            List<Dictionary <string,string>> profile = new List<Dictionary <string,string>>();
            profile.Add(Tim);
            profile.Add(Martin);
            profile.Add(Nikki);
            profile.Add(Sara);

            foreach(Dictionary <string,string> details in profile)
            {
                foreach(var item in details)
                {
                    Console.WriteLine(item.Key+"-"+item.Value);
                }
            }

            
        }
    }
}
