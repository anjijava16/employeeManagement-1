using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    public class Everyone : Employee
    {
        public String aa, ab, ac, ad;
        public String a, b, c, d, e, f, g;

        public override void Register(int n)
        {
            int i = n;
            Console.WriteLine("Enter your unique ID code");
            a = Console.ReadLine();
            id.setItem(i, a);


            Console.WriteLine("Enter your Namee");
            b = Console.ReadLine();

            name.setItem(i, b);


            Console.WriteLine("Enter your Street1");
            c = Console.ReadLine();

            Street1.setItem(i, c);


            Console.WriteLine("Enter your Street2");
            d = Console.ReadLine();

            Street2.setItem(i, d);


            Console.WriteLine("Enter your area");
            e = Console.ReadLine();

            area.setItem(i, e);


            Console.WriteLine("Enter your city");
            f = Console.ReadLine();

            city.setItem(i, f);


            Console.WriteLine("Enter your pincode");
            g = Console.ReadLine();
            pincode.setItem(i, g);
            i++;
        }


        public void HRdetails(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter your Email:");
                aa = Console.ReadLine();

                extra1.setItem(i, aa);

                Console.WriteLine("Enter your Contact number:");
                ab = Console.ReadLine();

                extra2.setItem(i, ab);

                Console.WriteLine("Enter your LinkedlnUrl:");
                ac = Console.ReadLine();

                extra3.setItem(i, ac);
                Console.WriteLine("Person is sucessfully registrated");

                extra4.setItem(i, "");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Developerdetails(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter your Skype:");
                aa = Console.ReadLine();

                extra1.setItem(i, aa);

                Console.WriteLine("Enter your Slack:");
                ab = Console.ReadLine();

                extra2.setItem(i, ab);

                Console.WriteLine("Enter your Facebook:");
                ac = Console.ReadLine();

                extra3.setItem(i, ac);

                Console.WriteLine("Enter your Twitter:");
                ad = Console.ReadLine();

                extra4.setItem(i, ad);

                Console.WriteLine("Person is sucessfully registrated");

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public override void Updates(int o, int p)
        {
            if (o == 1)
            {
                Console.WriteLine("Enter your updated id");
                a = Console.ReadLine();
                id.setItem(p, a);
            }
            if (o == 2)
            {
                Console.WriteLine("Enter your updated name");
                b = Console.ReadLine();
                name.setItem(p, b);
            }
            if (o == 3)
            {
                Console.WriteLine("Enter your updated Street1");
                c = Console.ReadLine();
                Street1.setItem(p, c);
            }
            if (o == 4)
            {
                Console.WriteLine("Enter your updated Street2");
                d = Console.ReadLine();
                Street2.setItem(p, d);
            }
            if (o == 5)
            {
                Console.WriteLine("Enter your updated area");
                e = Console.ReadLine();
                area.setItem(p, e);
            }
            if (o == 6)
            {
                Console.WriteLine("Enter your updated city");
                f = Console.ReadLine();
                city.setItem(p, f);
            }
            if (o == 7)
            {
                Console.WriteLine("Enter your updated pincode");
                g = Console.ReadLine();
                pincode.setItem(p, g);
            }
            if (o == 8)
            {
                Console.WriteLine("Enter your updated Email");
                aa = Console.ReadLine();
                extra1.setItem(p, aa);
            }
            if (o == 9)
            {
                Console.WriteLine("Enter your updated Contact number");
                ab = Console.ReadLine();
                extra2.setItem(p, ab);
            }
            if (o == 10)
            {
                Console.WriteLine("Enter your updated LinkedlnUrl");
                ac = Console.ReadLine();
                extra3.setItem(p, ac);
            }
            if (o == 11)
            {
                Console.WriteLine("Enter your updated LinkedlnUrl");
                ad = Console.ReadLine();
                extra3.setItem(p, ad);
            }
        }

        public int Search(string a)
        {
            int m = -1;
            string b;
            for (int i = 0; i < 100; i++)
            {
                b = id.getItem(i);
                if (b == a)
                {
                    m = i;
                }
            }
            return m;
        }


        public void Display(int i)
        {
            Console.WriteLine("Your id number:" + id.getItem(i));
            Console.WriteLine("Your Name:" + name.getItem(i));
            Console.WriteLine("House address Street1:" + Street1.getItem(i));
            Console.WriteLine("House address Street2:" + Street2.getItem(i));
            Console.WriteLine("Area" + area.getItem(i));
            Console.WriteLine("City:" + city.getItem(i));
            Console.WriteLine("Pincode:" + pincode.getItem(i));

        }

        public void DisplayHr(int i)
        {
            Console.WriteLine("Your Email:" + extra1.getItem(i));
            Console.WriteLine("Your Contact number:" + extra2.getItem(i));
            Console.WriteLine("Your LinkedlnUrl:" + extra3.getItem(i));
        }
        public void DisplayDeveloper(int i)
        {
            Console.WriteLine("Your Skype:" + extra1.getItem(i));
            Console.WriteLine("Your Slack:" + extra2.getItem(i));
            Console.WriteLine("Your Facebook:" + extra3.getItem(i));
            Console.WriteLine("Your Twitter:" + extra4.getItem(i));
        }

    }
}
