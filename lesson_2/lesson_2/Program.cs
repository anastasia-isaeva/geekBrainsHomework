using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Enter the maximum temperature for the current day");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minimum temperature for the day");
            int min = Convert.ToInt32(Console.ReadLine());
            int average = (min + max) / 2;
            Console.WriteLine($"Average daily temperature is { average }");
          
            //2.
            Console.WriteLine("Enter the serial number of the current month");
            int num = Convert.ToInt32(Console.ReadLine());
            string months = "";
            switch (num)
            {
                case 0:
                    months = "Invalid value";
                    break;
                case 1:
                    months = "January";
                    break;
                case 2:
                    months = "February";
                    break;
                case 3:
                    months = "March";
                    break;
                case 4:
                    months = "April";
                    break;
                case 5:
                    months = "May";
                    break;
                case 6:
                    months = "June";
                    break;
                case 7:
                    months = "July";
                    break;
                case 8:
                    months = "August";
                    break;
                case 9:
                    months = "September";
                    break;
                case 10:
                    months = "October";
                    break;
                case 11:
                    months = "November";
                    break;
                case 12:
                    months = "December";
                    break;
            }
            Console.WriteLine(months);

      

            //3
            if (num % 2 == 0) {
                Console.WriteLine($"{num} is even number");
                    }
            else {
                Console.WriteLine($"{num} is odd number");
                    }
            //4
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******");
            Console.WriteLine($"Entered month is {months}");
            Console.WriteLine($"Average temperature for today is {average}");

            //5
            int season = num;
            switch (season)
            {
                case 1:
                case 2:
                case 12:
                    if (average > 0)
                    {
                        Console.WriteLine("It is warm winter");
                    }
                    else
                    {
                        Console.WriteLine("It is cold winter");
                    }
                    
                    break;
                case 3:
                case 4:
                case 5:
                    if (average <= 0)
                    {
                        Console.WriteLine("It is cold spring");
                    }
                    else
                    {
                        Console.WriteLine("It is spring");
                    }
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It is sumer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It is fall");
                    break;

            }
            
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
