using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionProject
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> Emp = new();
            Emp.Add("Da");
            Emp.Add("Jane");
            Emp.Add("Best");
            Emp.Add("Friend");
            Emp.Add("Home");
            Emp.Add("Test");
            Emp.Add("Data");
            Emp.Add("Samrp");
            Emp.Add("Garuj");
            Emp.Add("paujn");

            //Find one item
            string ab = Emp.Find(f => f.Equals("Jane"));

            //Find multiple Item
            List<string> a = Emp.FindAll(f => f.Equals("Jane"));

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
