using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0;i<=10;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //for(int i=0;i<=2;i++)
            //{
            //    for(int j=0;j<=2;j++)
            //    {
            //        Console.WriteLine($"The value of i is: {i}....... and value of j is {j}");
            //    }
            //}
            //Console.ReadLine();

            //Use a for loop to print numbers from 1, 3 till 11
            //for (int i = 1; i < 12; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //Console.ReadLine();


            //print*
            //      **
            //      ***
            //      ****
            //Console.WriteLine("Enter number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //int i= 0;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}
            //while (i <= 10);
            //Console.ReadLine();

            //sum of first 5 natural numbers
            //int i = 1; int sum = 0;
            //while(i<6)
            //{
            //    sum=sum+i;
            //    i++;
            //}
            //Console.WriteLine("Sum of first 5 natural numbers is "+sum);
            //Console.ReadLine();




            //    1
            //   2 3
            //  4 5 6
            //7 8 9 10

            //Console.WriteLine("Enter no of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine(" "
            //    }
            //}
            //Console.ReadLine();

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //10,30,50,70.90...190 using continue also use break and exit after 190
            //for (int i = 10; i <= 200; i += 20)
            //{
            //    if (i % 20 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();


            //for (int i = 10; i <= 200; i += 20)
            //{
            //    if (i % 2 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            //Console.WriteLine("Enter number of days");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Its a Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Its a Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Its a Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Its a Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Its a Thursday");
            //        break;
            //    default:
            //        Console.WriteLine("Entered value is not in range");
            //        break;
            //}
            //Console.ReadLine();
            //using switch find odd or even


            //Console.WriteLine("Enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //switch(n%2)
            //{
            //case 0:
            //        Console.WriteLine("The number is even");
            //        break;
            //case 1:
            //        Console.WriteLine("The number is odd");
            //        break;
            //default:
            //        Console.WriteLine("Error");
            //        break;
            //}
            //Console.ReadLine();


            //int[] num = { 1, 2, 3, 4, 5 };
            ////string[] days = { "Monday", "Tuesday", "wednesday", "Thursday", "Friday", 89 };

            //for (int i = 0; i <= num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadLine();


            Console.WriteLine("Enter rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            int space = rows + 4;
            int x = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(x++ + " ");

                }
                Console.Write("\n");
                space = space - 1;
            }
            Console.ReadLine();

        }
    }
}
