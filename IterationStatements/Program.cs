using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
            Console.WriteLine(IsEqual(7, 10));
            int c = 7;
            bool isEven = IsEven(c);

            if (isEven)
            {
                Console.WriteLine($"{c} is even");
            }
            else
            {
                Console.WriteLine($"{c} is odd");
            }
            Console.WriteLine(IsPositive(8));
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (VotingAge(age))
            {
                Console.WriteLine("You're old enough to vote!");
            }
            else
            {
                Console.WriteLine("You're not old enough to vote yet.");
            }
            Console.WriteLine("Please enter a number");
            int userNumber =int.Parse(Console.ReadLine());
            if (InRange(userNumber, -10, 10))
            {
                Console.WriteLine($"The number {userNumber} is in the range -10 to 10");
                    }
            else
            {
                Console.WriteLine($"The number {userNumber} is not in the range -10 to 10");
                    }
            int m = 6;
            MultiplicationTable(m);

        }
            

        public static void PrintThousand()
        {
            for(int i = 1000;i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Threes()
        {
            for (int t = 3; t <= 999; t += 3)
            {
                Console.WriteLine(t);
            }
        }
        public static bool IsEqual(int a, int b)
        {
            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEven(int c)
        {

            return c % 2 == 0;  

        }
        
        public static bool IsPositive(int d)
        {
            if(d >= 0)
                    {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VotingAge(int age)
       {
            return age >= 18;

        }

        public static bool InRange(int number, int minValue, int maxValue)
        {
            return number >= minValue && number <= maxValue;
        }

        public static void MultiplicationTable(int m)
        {
            Console.WriteLine($"Multiplication table for {m}:");

            for (int f = 1; f <= 12; f++)
            {
                int result = m * f;
                Console.WriteLine($"{m} x {f} = {result}");
            }
        }



            
                   


        
       
        


    }
}
