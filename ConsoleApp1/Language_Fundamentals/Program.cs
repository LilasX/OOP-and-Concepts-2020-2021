using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Fundamentals
{

    //enum Direction { North, South, East, West};

    class Program
    {
        static char myChar; //stores a single character, like 'c'
        static string myString; //stores a string of characters, like "hello, my name is John."

        static int myInt; //stores an integer like 12
        static short myShort; //stores an integer, but with less memory usage than the int type
        static long myLong; //stores an integer, but with more memory usage than the int type

        static double myDouble; //stores a real number, like 126.223
        static float myFloat; //stores a real number, but with less decimal precision (and memory usage) than the double type
        static decimal myDecimal; //stores a real number, but with more decimal precision (and memory usage) than the double type

        static bool myBool; //stores a boolean value: either true or false

        //const int numOfDaysInWeek = 7;
        //static Direction currentDirection;
        //static string[] words; 

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine(myString);
            //Console.WriteLine(myInt);
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myBool);

            myString = "Hello World";
            Console.WriteLine(myString);
            myChar = '!';
            myString = myString + myChar;
            Console.WriteLine(myString);

            myString = Console.ReadLine();
            Console.WriteLine("you entered the following string: " + myString);

            Console.WriteLine("Min and Max values for the int type: " + int.MinValue + ", " + int.MaxValue);
            Console.WriteLine("Min and Max values for the short type: " + short.MinValue + ", " + short.MaxValue);
            Console.WriteLine("Min and Max values for the long type: " + long.MinValue + ", " + long.MaxValue);


            myFloat = 1f / 7f;  //values 1 and 7 are treated as float numbers
            myDouble = 1d / 7d; //values 1 and 7 are treated as double numbers
            myDecimal = 1m / 7m;    //values 1 and 7 are treated as decimal numbers
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);

            //int int1 = 100;
            //float float1 = int1;
            //int1 = float1;
            //Console.WriteLine(int1);
            //float1 += 2.3f;
            //Console.WriteLine(float1);
            //int1 = (int)float1;
            //Console.WriteLine(int1);
            //int1 = (int)"hello";


            //myInt = int.MaxValue;
            //Console.WriteLine(myInt);
            //myLong = myInt;
            //myLong += 1;
            //Console.WriteLine(myLong);
            //myInt = (int)myLong;
            //Console.WriteLine(myInt);

            //myFloat = 1 / 7;
            //Console.WriteLine(myFloat); // what value will this line write to the console?

            //numOfDaysInWeek = 8;

            //int int1 = 2;
            //int int2 = 4;

            //int1 = int2;
            //int2 = int1;

            //int temp = int1;
            //int1 = int2;
            //int2 = temp;

            //Console.WriteLine("int1: " + int1 + ", int2: " + int2);

            //myBool = true;
            //if(myBool == true)
            //{
            //    Console.WriteLine("myBool is true!");
            //}

            //if(!myBool)
            //{
            //    Console.WriteLine("myBool is false!");
            //}

            //if(myBool)
            //{
            //    Console.WriteLine("myBool is true!");
            //}
            //else
            //{
            //    Console.WriteLine("myBool is false!");
            //}

            //string message = myBool ? "myBool is true!" : "myBool is false!";
            //Console.WriteLine(message);

            //bool anotherBool = true;
            //if(myBool && anotherBool)
            //{
            //    Console.WriteLine("both myBool and anotherBool are true!");
            //}
            //else if(myBool || anotherBool)
            //{
            //    Console.WriteLine("either myBool or anotherBool is true!");
            //}
            //else
            //{
            //    Console.WriteLine("neither myBool nor anotherBool are true");
            //}

            //Console.WriteLine(currentDirection);

            //currentDirection = Direction.West;
            //Console.WriteLine(currentDirection);

            //currentDirection = (Direction)1;
            //Console.WriteLine(currentDirection);
            //Console.WriteLine((int)currentDirection);

            //if (currentDirection == Direction.North)
            //    Console.WriteLine("polar bears");
            //else if (currentDirection == Direction.South)
            //    Console.WriteLine("penguins");
            //else if (currentDirection == Direction.East)
            //    Console.WriteLine("sunrise");
            //else
            //    Console.WriteLine("sunset");

            //switch (currentDirection)
            //{
            //    case Direction.North:
            //        Console.WriteLine("polar bears");
            //        break;
            //    case Direction.South:
            //        Console.WriteLine("penguins");
            //        break;
            //    case Direction.East:
            //        Console.WriteLine("sunrise");
            //        break;
            //    case Direction.West:
            //        Console.WriteLine("sunset");
            //        break;
            //    default:
            //        Console.WriteLine("uh oh, this code should not be reachable!");
            //        break;
            //}

            //Console.WriteLine("Please enter y for 'yes', n for 'no', or any other character for 'maybe'");
            //myChar = char.Parse(Console.ReadLine());
            //switch (myChar)
            //{
            //    case 'y':
            //        Console.WriteLine("You selected Yes!");
            //        break;
            //    case 'n':
            //        Console.WriteLine("You selected No!");
            //        break;
            //    default:
            //        Console.WriteLine("You selected Maybe!");
            //        break;
            //}

            //words = new string[] { "shoe", "elephant", "doubt" };

            //Console.WriteLine(words[0]);
            //Console.WriteLine(words[1]);
            //Console.WriteLine(words[2]);

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //Console.WriteLine("What size of array would you like to make?");
            //int arraySize = int.Parse(Console.ReadLine());
            //words = new string[arraySize];

            //for(int i = 0; i < words.Length; i++ )
            //{
            //    Console.WriteLine("Please enter a word");
            //    words[i] = Console.ReadLine();
            //}

            //Console.WriteLine("You entered the following words:");

            //foreach(string str in words)
            //{
            //    Console.Write(str + ", ");
            //}

            //int[] arrayOfInts;
            //int sizeOfArray = 0;
            //bool validInput = false;
            //Console.WriteLine("What size of array would you like to make?");
            //while (!validInput)
            //{
            //    Console.WriteLine("Please enter an array size");
            //    validInput = int.TryParse(Console.ReadLine(), out sizeOfArray);
            //}
            //arrayOfInts = new int[sizeOfArray];

            //for (int i = 0; i < arrayOfInts.Length; i++)
            //{
            //    int intToAdd = 0;
            //    bool successfulParse = false;
            //    while (!successfulParse)
            //    {
            //        Console.WriteLine("Please enter an integer");
            //        successfulParse = int.TryParse(Console.ReadLine(), out intToAdd);
            //    }
            //    arrayOfInts[i] = intToAdd;
            //}

            //int sumOfArrayIntegers = 0;
            //for (int i = 0; i < arrayOfInts.Length; i++)
            //{
            //    sumOfArrayIntegers += arrayOfInts[i];
            //}

            //Console.WriteLine("The sum of the integers in the array you filled is: " + sumOfArrayIntegers);

            //float averageOfArrayIntegers = sumOfArrayIntegers / arrayOfInts.Length;

            //float averageOfArrayIntegers = (float)sumOfArrayIntegers / (float)arrayOfInts.Length;

            //Console.WriteLine("The average of the integers in the array you filled is: " + averageOfArrayIntegers);

            Console.ReadKey();
        }
    }
}
