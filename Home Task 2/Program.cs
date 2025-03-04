using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class Program
    {
        static void integer(){
            int a=1;
            int b=2;
            Console.WriteLine(a,b);}
        static void swapsigns(int a, int b)
        {
            Console.WriteLine("Before Swapping a= " + a + " b= " + b);
            a =-a; b=-b;
            Console.WriteLine("After Swapping num1= " + a+ " num2= " + b);
        }
        static int reverse(ref int a)
        {
            int rev = 0;
            while(a>0)
            {
                int digit = a % 10;
                rev = rev * 10 + digit;
                a/=10;
            }
            a = rev;
            return a;
        }
        static string quadratic(double a, double b,double c,out double root1,out double root2 )
        {
            double discriminant = (b*b)- 4 * a * c;
            root1 = 0;
            root2 = 0;
            if (discriminant < 0)
            {
                return "No real roots";
            }
            else
            {
                root1 = (-b+Math.Sqrt(discriminant))/2*a;
                root2 = (+b + Math.Sqrt(discriminant)) / 2 * a;
            }
            return "Roots found";

        }
        static int greatest(params int[] a)
        {
            int great = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >great)
                    great = a[i];
            }
            return great;
        }
        static int calculatepower(int num)
        {
            return num * num;
        }
        static int calculatepower(int baseno, int exponent)
        {
            int result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                result *= baseno;
            }
            return result;
        }
        static double calculatepower(double baseno,int exponent)
        {
            double result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                result *= baseno;
            }
            return result;
        }
        static void Main(string[] args)
        {
            integer();
            bool exit=true;
            while (exit)
            {
                Console.WriteLine("Choose the option below ");
                Console.WriteLine("0. Exit: ");
                Console.WriteLine("1. Swap Signs: ");
                Console.WriteLine("2. Reverse Digits: ");
                Console.WriteLine("3. Roots: ");
                Console.WriteLine("4. Modifier: ");
                Console.WriteLine("5. Overloading: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an integer: ");
                        int num1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter an integer: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        swapsigns(num1, num2);
                        break;
                    case 2:
                        Console.WriteLine("Enter an integer: ");
                        num1 =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(reverse(ref num1));
                        break;
                    case 3:
                        Console.WriteLine("Enter the number: ");
                        double a=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double root1, root2;
                        string result=quadratic(a, b, c, out root1, out root2);
                        if (result =="No real roots")
                        {
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine($"Roots are: {root1},{root2}");
                        }
                        break;
                    case 4:
                        int[] integers = { 1, 2, 3, 4, 5 };
                        Console.WriteLine("The greatest number in the array is: "+greatest(integers));
                        int[] number = { 6, 8, 4, 9 };
                        Console.WriteLine("The greatest number in the second array is: " + greatest(number));
                        break;
                    case 5:
                        int num = calculatepower(10);
                        Console.WriteLine("Square of 10 is: "+num);
                        Console.WriteLine("2 raised to the power of 3: " + calculatepower(3, 2));
                        Console.WriteLine("3 raised to the power of 2.5: " + calculatepower(2.5, 3));
                        break;
                    case 0:
                        exit = false;
                        break;
                }
            }
        }
    }
}
