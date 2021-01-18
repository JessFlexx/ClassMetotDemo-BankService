using System;
using System.Collections.Generic;
using System.Text;
using ClassMetotDemo.DataSource;
using ClassMetotDemo.Manager;



namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_Info c10001 = new Customer_Info();
            c10001.Id = 10001;
            c10001.Name = "Jacob";
            c10001.Surname = "Oliver";
            c10001.CardNum = 5228914614151121;

            Customer_Info c10002 = new Customer_Info();
            c10002.Id = 10002;
            c10002.Name = "Emma Ava";
            c10002.Surname = "Clay";
            c10002.CardNum = 4581499893446099;

            Customer_Info c10003 = new Customer_Info();
            c10003.Id = 10003;
            c10003.Name = "Sophie";
            c10003.Surname = "Charles";
            c10003.CardNum = 5132425755652186;

            Customer_Info c10004 = new Customer_Info();
            c10004.Id = 10004;
            c10004.Name = "Paulo Lucas";
            c10004.Surname = "Pedro";
            c10004.CardNum = 5156014346389986;

            Customer_Info c10005 = new Customer_Info();



            Customer_Info[] customers = new Customer_Info[] { c10001, c10002, c10003, c10004, c10005 };

            Customer_Manager customer_Manager = new Customer_Manager();

            Console.WriteLine("------Commands-----");
            Console.WriteLine("1-Add Customer Info");
            Console.WriteLine("2-Delete Customer Info");
            Console.WriteLine("3-Show Customer Info");
            Console.WriteLine("4-List Of Customer");
            Console.WriteLine("-------------------");
            int cs = Convert.ToInt16(Console.ReadLine());

            

            switch (cs)
            {
                case 1:
                    customer_Manager.Add(c10005);
                    Console.WriteLine("\nThe Show Customer ID command ran automatically.");
                    Console.WriteLine("-------------------");
                    customer_Manager.Show(c10005);
                    Console.WriteLine("-------------------");
                    break;
                case 2:
                    Console.WriteLine("Enter Id to DELETE:");
                    int temp2 = Convert.ToInt16(Console.ReadLine());
                    temp2 -= 10001;
                    if (temp2 < 0) Console.WriteLine("WRONG ID");
                    else
                    customer_Manager.Delete(customers[temp2]);
                    break;
                case 3:
                    Console.WriteLine("Enter Id to SHOW:");
                    int temp3 = Convert.ToInt16(Console.ReadLine());
                    temp3 -= 10001;
                    if (temp3 < 0) Console.WriteLine("WRONG ID");
                    else
                    customer_Manager.Show(customers[temp3]);
                    
                    break;
                case 4:
                    Console.WriteLine("-------------------------------");
                    foreach (var list in customers)
                    {
                        
                        Console.WriteLine("Name:" + list.Name);
                        Console.WriteLine("Surname:" + list.Surname);
                        Console.WriteLine("ID:" + list.Id);
                        Console.WriteLine("Card Number:" + list.CardNum);
                        Console.WriteLine("-------------------------------");
                    }
                    break;
                
                default:
                    break;
            }

            Console.ReadLine();

        }
    }
}
