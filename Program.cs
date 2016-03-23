using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, r;
            int b,d1;
            double d,o;
            string h = "";
            int[] arr=new int[10];
            Console.WriteLine("1=binary to decimal 2=decimal to binary 3=decimal to hexadecimal 4=decimal to octal");
            Console.WriteLine("enter your choice...");
            n=Int16.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:Console.WriteLine("enter binary number...");
                       b=Convert.ToInt16(Console.ReadLine());
                       Console.Write(b+" binary number = ");
                       d = 0;
                       while(b>0)
                       {
                            r = b % 10;
                            b = b / 10;
                            d = d +( r * Math.Pow(2, i));
                            i++;
                       }
                       Console.Write(d + " decimal number ");
                       break;
                case 2:Console.WriteLine("enter decimal number...");
                       d1 = Int16.Parse(Console.ReadLine());
                       Console.Write(d1 +" decimal number = ");
                       int count = 0;
                       while(d1>0)
                       {
                            arr[i] = d1 % 2;
                            d1 = d1 / 2;
                            i++;
                            count++;   
                       }
                       Console.Write(d1);
                       for (i = count + 1; i >= 0; i--)
                            Console.Write(arr[i]);
                       Console.Write(" binary number ");                       
                       break;
                        /* OR
                        Console.WriteLine("enter decimal number...");
                        d1=Convert.ToInt16(Console.ReadLine());
                        Console.Write(d1+" decimal number = ");
                        b = 0;
                        while(>0)
                        {
                             r = d1 % 10;
                             d1 = d1 / 10;
                             b = b +( r * Math.Pow(2, i));
                             i++;
                        }
                        Console.Write(b + " binary number ");
                        break;
                        */
                        
                        /* OR
                        Console.WriteLine("enter decimal number...");
                       b=Convert.ToInt16(Console.ReadLine());
                       Console.Write(b+" decimal number = ");
                       d = 0;
                       while(b>0)
                       {
                            r = b % 2;
                            b = b / 2;
                            d = d +( r * Math.Pow(10, i));
                            i++;
                       }
                       Console.Write(d + " binary number ");
                       break;
                       */
                       
                case 3:Console.WriteLine("enter decimal number...");
                       d1 = Int16.Parse(Console.ReadLine());
                       Console.Write(d1 + " decimal number = ");
                       string temp="";
                        while (d1 > 0)
                        {
                            r = d1 % 16;
                            if (r < 10)
                                h = r + h;
                            else
                            {
                                switch (r)
                                {
                                    case 10:
                                        temp = "A";
                                        break;
                                    case 11:
                                        temp = "B";
                                        break;
                                    case 12:
                                        temp = "C";
                                        break;
                                    case 13:
                                        temp = "D";
                                        break;
                                    case 14:
                                        temp = "E";
                                        break;
                                    case 15:
                                        temp = "F";
                                        break;
                                    default: break;
                                }
                                h = temp + h; //it will store temp before h....temp appent before h....so no need to reverse it
                             }
                            d1 = d1 / 16;
                        }
                        Console.Write(h + " hexadecimal number ");
                        break;
                case 4:Console.WriteLine("enter decimal number...");
                    d1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write(d1 + " decimal number = ");
                    o = 0;
                    while (d1 > 0)
                    {
                        r = d1 % 8;
                        d1 = d1 / 8;
                        o = o + (r * Math.Pow(10, i));
                        i++;
                    }
                    Console.Write(o + " octal number ");
                    break;
                default: Console.WriteLine("Oops!Invalid input...!!!");
                                 break;
            }
            Console.Read();
        }
    }
}

