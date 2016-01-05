using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            int m = 0, g;
            string q;
            int n, u;
            Everyone obj = new Everyone();
            Console.WriteLine("Registration form:");
            Console.WriteLine("Enter the number of employee want to register");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Who is an employee of the company?");
                Console.WriteLine("Press 1 : HR");
                Console.WriteLine("Press 2 : Developer");
                n = Convert.ToInt32(Console.ReadLine());
                u = n;
                obj.Register(i);
            
            if (n == 1)
                {
                    obj.HRdetails(1);
                    Console.WriteLine();
                }
                if (n == 2)
                {
                    obj.Developerdetails(1);
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("This is the details of employee\b"+(i+1)+":");
                obj.Display(i);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Do you want to do any update");
            String e = Console.ReadLine();
            if (e == "y")
            {
                Console.WriteLine("Enter your employee id");
                string b = Console.ReadLine();
                m = obj.Search(b);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("This is your previous detail:");
                obj.Display(m);
                if (m==1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Which item you want to update");
                    Console.WriteLine("To update employee id press 1");
                    Console.WriteLine("To update employee name press 2");
                    Console.WriteLine("To update employee street1 press 3");
                    Console.WriteLine("To update employee street2 press 4");
                    Console.WriteLine("To update employee area press 5");
                    Console.WriteLine("To update employee city press 6");
                    Console.WriteLine("To update employee pincode press 7");
                    Console.WriteLine("To update employee Email press 8");
                    Console.WriteLine("To update employee Contact number press 9");
                    Console.WriteLine("To update employee LineklnUrl press 10");
                    g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();;
                    obj.Updates(g, m);
                    Console.WriteLine("This is your updated Registration");
                    Console.WriteLine();
                    obj.Display(m);
                    obj.DisplayHr(m);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Which item you want to update");
                    Console.WriteLine("To update employee id press 1");
                    Console.WriteLine("To update employee name press 2");
                    Console.WriteLine("To update employee street1 press 3");
                    Console.WriteLine("To update employee street2 press 4");
                    Console.WriteLine("To update employee area press 5");
                    Console.WriteLine("To update employee city press 6");
                    Console.WriteLine("To update employee pincode press 7");
                    Console.WriteLine("To update employee Skpye press 8");
                    Console.WriteLine("To update employee Slack number press 9");
                    Console.WriteLine("To update employee Facebook press 10");
                    Console.WriteLine("To update employee Twitter press 11");
                    g = Convert.ToInt32(Console.ReadLine());
                    obj.Updates(g, m);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("This is your updated Registration");
                    Console.WriteLine();
                    obj.Display(m);
                    obj.DisplayDeveloper(m);
                }

                Console.ReadKey();
            }
        }
    }
}

