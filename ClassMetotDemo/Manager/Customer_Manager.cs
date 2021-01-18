using System;
using System.Collections.Generic;
using System.Text;
using ClassMetotDemo.DataSource;

namespace ClassMetotDemo.Manager
{
    class Customer_Manager
    {

        public void Add(Customer_Info customerInfo1)
        {
            
            Console.WriteLine("Name:");
            customerInfo1.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            customerInfo1.Surname = Console.ReadLine();
            customerInfo1.Id = 10005;
            Console.WriteLine("The system has produced a new card number for " + customerInfo1.Name + " " + customerInfo1.Surname);
            Console.WriteLine("Created ID: " + customerInfo1.Id);
            Console.WriteLine("Card Number: 4562731146629128");
            customerInfo1.CardNum = 4562731146629128;
            Console.WriteLine("Completed.");
        }

        public void Delete(Customer_Info customerInfo2) 
        {
            customerInfo2.Name = null;
            customerInfo2.Surname = null;
            customerInfo2.CardNum =0;
            Console.WriteLine(customerInfo2.Id + " is DELETED");
            
        }

        public  void Show(Customer_Info customer_Info3)
        {
            Console.WriteLine("Name:"+customer_Info3.Name);
            Console.WriteLine("Surname:"+customer_Info3.Surname);
            Console.WriteLine("Customer ID:" + customer_Info3.Id);
            Console.WriteLine("Card Number:" + customer_Info3.CardNum);

        }

    }
        
    }

