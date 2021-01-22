using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> members = new MyDictionary<int, string, string>();
            members.Add(123456, "Sevim", "Doctor");
            members.Add(654321, "Selahattin", "Engineer");
            members.Add(789456, "Aysel", "Teacher");
            members.Add(345345, "Okan", "Engineer");

            Console.WriteLine("total number of elements: " + members.Length);

            Console.WriteLine("---Members ID cards---");
            foreach (var Id in members.Id)
            {
                Console.WriteLine(Id);
            }
            Console.WriteLine("-----Members Name----");
            foreach (var name in members.Name)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----Members Job-----");
            foreach (var jobs in members.Job)
            {
                Console.WriteLine(jobs);
            }
        }
    }
}
