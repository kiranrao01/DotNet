using System; 
using System.Collections.Generic;
namespace DbConnection
{
    public class Program
    {
        public static void ReadDB() 
        {
            List<Dictionary<string, object>> ans = new List<Dictionary<string,object>>();
             ans = DbConnector.ExecuteQuery("select * from Users");
             foreach(var names in ans)
             {
                 foreach(KeyValuePair<string,object> disp in names)
                 {
                     System.Console.WriteLine(disp.Key + "-"+disp.Value);
                 }
             }


        }
        public static void create()
        {
            System.Console.WriteLine("Enter your name");
            string InputLine1 = System.Console.ReadLine();
            string InputLine2 = System.Console.ReadLine();
            DbConnector.ExecuteQuery($"INSERT into users (firstname, lastname) values ('{InputLine1}','{InputLine2}')");
        }

        public static void update()
        {
            System.Console.WriteLine("Enter your ID");
             int InputLineId = int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter your firstname or lastname which you want to update");
            string InputLine1 = System.Console.ReadLine();
            System.Console.WriteLine("Enter your new datails");
            string InputLine2 = System.Console.ReadLine();

            DbConnector.ExecuteQuery($"update users SET {InputLine1} = '{InputLine2}' where id = {InputLineId}");
            
        }
        public static void delete()
        {
            System.Console.WriteLine("You are deleting your details");
             int InputLineId = int.Parse(Console.ReadLine());

            DbConnector.ExecuteQuery("delete from users where id =" +InputLineId);
        }
        public static void names()
        {
           
        }
        public static void Main()
        {
            ReadDB();
            // create();
            //delete();
            update();
        }
    }
}
