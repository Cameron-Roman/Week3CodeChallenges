using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I am calling all of my functions
            FindManyPrimes(10001);
            EvenFibonacciSequencer(2000000);
            LongestCollatzSequence();
            //This will show my work in the console
            Console.ReadKey();
        }
        //Here i'm creating a function called FindManyPrimes and putting in a parameter of an integer called thisMany
        static void FindManyPrimes(int thisMany)
        {
            //Here I am creating an integer that starts the current number at 2 and goes through until it finds the prime numbers passed in the arguement.
            int CurrentNumber = 2;
            //Here i'm creating an integer that counts prime numbers/ stores prime numbers
            int NumPrimes = 0;
            //here I have a while loop that iterates through prime numbers until they are equal to or greater than thisMany
            while (NumPrimes < thisMany)
            {
                //this is saying that if the number that is prime equals the current number in the loop then increment the numPrimes variable and then the increment the currentNumber variable
                if (IsPrime(CurrentNumber))
                {
                    NumPrimes += 1;
                }
                
                CurrentNumber += 1;

            }
            CurrentNumber -= 1;
            Console.WriteLine(CurrentNumber);


        }
        //this is a boolean function that returns a true or false 
        static bool IsPrime(int num)
        {
            //This is my counter that starts at 0 and moves up 
            var counter = 0;
            //This is a for loop that starts at 2 because 1 and 0 are not prime or composite and goes up until i is greater than num incrementing by one
            for (int i = 2; i < num; i++)
            {
                //This is my if statement that is stating if num is divisible by i with no remainder then increment my counter
                if (num % i == 0)
                {
                    counter += 1;
                }

            }
            //This is saying that if the counter is equal to zero after it divides then return true as a prime number otherwise return false
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void EvenFibonacciSequencer(int maxValue)
        {
            //this is my variable for storage of my previous numbers starting with one
            var prev = 1;
            //this is my variable for storage of my current numbers starting with two
            var cur = 2;
            //this is my variable for storage of my even numbers starting with two as well
            var even = 2;
            //This is my while loop saying that while the current number is less than the max value do the things below
            while (cur < maxValue)
            {
                //this is my variable which stores the new number we are looking for by adding the current and previous
                var newNum = cur + prev;
                //This is my if statement saying that if the new number is divisible by two with a remainder of zero then its even
                if (newNum % 2 == 0)
                {
                    even += newNum;
                }
                //This is just saying that after my if statement the previous number will equal the current and the new number will equal the current number
                prev = cur;
                cur = newNum;
            }

           //this prints the even numbers to the console
            Console.WriteLine(even);

        }
        //This is my function for my collatz sequence that takes in no parameters
        static void LongestCollatzSequence()
        {


            //this is my variable for the max number which is set to one million
            var max = 1000000;
            //This is my variable that stores the total terms starting at zero
            var LongestChain = 0;
            //This is my variable that stores the longest chain starting at zero as well
            var totalTerms = 0;
            //this is my variable that starts i at one and iterates through until i is greater than the max number, incrementing by one each time
            for (var i = 1; i <= max; i++)
            {
                //this is my double variable for n which sets it equal to i but instead of an integer I use a double so I have more storage
                double n = i;
                //this my variable for storing the numTerms and starts at one 
                var numTerms = 1;
                //This is my while saying that while n greater than 1 iterate through
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = ((n * 3) + 1);
                    }
                    numTerms++;
                    

                    
                }
                if (numTerms > LongestChain)
                {
                    Console.WriteLine("New longest chain: " + i);
                    LongestChain = numTerms;

                    totalTerms = i;
                }
                
            }
            Console.WriteLine("The total amount of terms is " + LongestChain);
            Console.WriteLine(totalTerms);
                 

        }

    }
}
