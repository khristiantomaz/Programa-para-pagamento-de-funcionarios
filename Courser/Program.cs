using System;
using System.Collections.Generic;
using Course.Entities;
using System.Globalization;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee> ();
            Console.Write("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (Y/N)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuerPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge:");
                    double additonalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuerPerHour, additonalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuerPerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS:");
                foreach(Employee emp in list) 
                {
                    Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }

            }
        }
        
    }
}