using System;
    
namespace Exceptions_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)// We created are variables, random variables, floats, and ints
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try // Try and catch, 65.4f gets divided by the others, reslut is printed
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero."); //asks user to put in a number other than zero, and assigns it
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = Divide(myFloat, myOtherFloat); //Result is then divided and printed
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally
            {
                Console.WriteLine("Caluculations completed with a result of " + result);
            }

            try // Try/catch that prints to the console if the age the user typed in is under 17
            {
                CheckAge(myInt);
            }catch(Exception e)
            {
                Console.WriteLine($"You are {myInt}, you are not old enough child!!");
            }
        }

        static float Divide(float x, float y) //Divide method 
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        static void CheckAge(int age) //Check age method, prints, saying that you are old enough to play if you are
        { 
            if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }

    }
}