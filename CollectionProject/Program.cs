using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Emp = new() { "Dao", "Jane", "Best", "Friend", "Home", "Test", "Data", "Samrp", "Garuj" };

            //Get first match elements
            string ab = Emp.Find(f => f.Equals("Jane"));

            //Get All matches elements
            List<string> a = Emp.FindAll(f => f.Equals("Jane"));

            //Get Count
            int count = Emp.Count;


            //Check element is exist or not
            bool isexists = Emp.Contains("Jane");

            //ForEach
            Emp.ForEach( e => {
                Console.WriteLine(e);
            });

            bool checkMultiple = Emp.Exists(e => e.Contains("Jane"));

            //Remove one element
            Emp.Remove("Jane");

            // Remove All elements
             Emp.Clear();

            Console.ReadLine();
        }
    }
}
