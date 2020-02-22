using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----/BMI Calculator/-----");

            int KGorLB = 1;
            double userWeight;
            double userHeight;
            double mult = 704.7;
            double BMI = 0;

            Console.Write("Select your measurement(1, 2): \n1. LB\n2. KG\n: ");
            KGorLB = Convert.ToInt32(Console.ReadLine());

            if(KGorLB == 1)
            {
                Console.Write("What is your weight in lbs: ");
                userWeight = Convert.ToDouble(Console.ReadLine());
                Console.Write("What is your height in inches: ");
                userHeight = Convert.ToDouble(Console.ReadLine());

                BMI = (userWeight * mult) / Math.Pow(userHeight, 2);
                Console.WriteLine("\nYour BMI is: " + String.Format("{0:0.00}", BMI));
            }
            else if(KGorLB == 2)
            {
                Console.Write("What is your weight in kg: ");
                userWeight = Convert.ToDouble(Console.ReadLine());
                Console.Write("What is your height in cm: ");
                userHeight = Convert.ToDouble(Console.ReadLine());

                BMI = userWeight / Math.Pow(userHeight / 100, 2);
                Console.WriteLine("\nYour BMI is: " + String.Format("{0:0.00}", BMI));
                
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid choice.");
            }


            if (BMI < 18.5)
            {
                Console.WriteLine("\nYou are considered Underweight(< 18.5)");
            }
            else if(BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("\nYou are considered Normal Weight(18.5 <-> 24.9)");
            }
            else if(BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("\nYou are considered Overweight(25 <-> 29.9)");
            }
            else
            {
                Console.WriteLine("\nYou are considered Obese(> 30)");
            }
        }
    }
}
