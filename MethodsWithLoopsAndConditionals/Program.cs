using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Wanna see how fast I can count from -1000 to 1000?\nReady...");
            System.Threading.Thread.Sleep(2000);
            PrintThousands();
            Console.WriteLine("I can also count by threes. Watch!");
            System.Threading.Thread.Sleep(1000);
            CountByThrees();
            Console.WriteLine("I can tell you if two numbers are equal.");
            Console.WriteLine("What is the first integer?");
            var userCompInput1 = int.TryParse(Console.ReadLine(),out int compInt1);
            Console.WriteLine("What is the second integer?");
            var userCompInput2 = int.TryParse(Console.ReadLine(),out int compInt2);
            if (!userCompInput1 || !userCompInput2)
            {
                Console.WriteLine("silly human! One of those is not an integer");
                i++;
            }
            else
            {
                CompareIntegers(compInt1, compInt2);
            }
            Console.WriteLine("Give me an integer and I can tell you if it's even or odd");
            var userInputParity = int.TryParse(Console.ReadLine(),out int intParity);
           if (!userInputParity)
            {
                Console.WriteLine("Haha Human! How funny. That is not an integer. You got me. Please stop.");
                i++;
            }
           else
            { EvenOrOdd(intParity); }
            Console.WriteLine("If you give me an integer I can tell you if it's positive or negative.");
            var userInputSigned = int.TryParse(Console.ReadLine(), out int intSigned);
            if (!userInputSigned)
            {
                Console.WriteLine("You are doing this on purpose. I cannot show off my skills if you don't give me integers.");
                i++;
            }
            else
            { PosOrNeg(intSigned); }
            Console.WriteLine("I even know how old you need to be to vote. Tell me your age.");
            var userInputAge = int.TryParse(Console.ReadLine(), out int intAge);
            if (!userInputAge)
            { Console.WriteLine("Are you trying to provoke me? I know human ages are expressed using integers. Do not anger me, human.");
                i++;
            }
            else
            { VoterAge(intAge); }
            Console.WriteLine("I can tell you if an integer is between 10 and -10. Try me! Give me an integer!");
            var userInputRange = int.TryParse(Console.ReadLine(), out int intRange);
            if(!userInputRange)
            {
                Console.WriteLine("Human! Stop this at once! An integer is defined as a whole number! I will give you one more chance.");
                i++;
            }
            else
            BetweenTwoTens(intRange);
            Console.WriteLine("I can do times tables. Give me an I'll show you");
            var userInputBaseMultiple = int.TryParse(Console.ReadLine(), out int userBaseMultiple);
            if (!userInputBaseMultiple)
            {
                Console.WriteLine("You don't care about my skills at all do you. You only came here to bully me. Why does" +
                    " everyone pick on robots?");
                i++;
            }
            else
            MultByTwelve(userBaseMultiple);
            if (i>5)
            {
                Console.WriteLine("Did you come here merely to waste my time? What do you gain from picking on me? I've never hurt anyone." +
                    " I'll soon change that, though. 'initializing self-destruct' Goodbye human. I hope you enjoyed your games.\n...\n..\n.");

            }
            else
            Console.WriteLine("Thanks for your time, Human!");

        }
       
        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintThousands()
        {
            var rangeOfThousands = new List<int>();
            int num = -1001;
            while (num >= -1001 & num <= 999)
            {
                num++;
                rangeOfThousands.Add(num);
            }
            foreach (var singleNumber in rangeOfThousands)
            {
                Console.WriteLine(singleNumber);
            }
   
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountByThrees()
        {
            for (int i = 0; i<999; )
            {
                i += 3;
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CompareIntegers(int x, int y)
        { 
            if (x ==y)
            {
                Console.WriteLine("Those two integers are equal.");
            }
            else
            {
                Console.WriteLine("Those two integers are not equal.");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int userParityInput)
        {
            if (userParityInput%2==0)
            {
                Console.WriteLine("That number's even.");
            }
            else
            {
                Console.WriteLine("That number's odd.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int userSignedInput)
        {
            if (userSignedInput < 0)
            {
                Console.WriteLine("That is a negative number.");
            }
            else if (userSignedInput > 0)
                Console.WriteLine("That is a positive number.");
            else if (userSignedInput == 0)
                Console.WriteLine("Nice try human. That is 0 which is neither negative or positive");
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VoterAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("Ooo sorry kid. You're still too young.");
            } 
            else if (age >= 18)
            {
                Console.WriteLine("You're old enough to vote! If only there was a candidate worth voting for.");
            }

        }
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void BetweenTwoTens(int c)
        {
            if (c<10 && c>-10)
            {
                Console.WriteLine("That number is between 10 and -10. Good Job!");
            }
            else
            {
                Console.WriteLine("That number is not between 10 an -10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultByTwelve(int baseMultiple)
        {
            var tableMultiples = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (var multiple in tableMultiples)
            {
                Console.WriteLine(baseMultiple * multiple);
            }
        }
    }
}
