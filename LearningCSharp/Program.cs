using System;

public class Program
{
    public static void Main(string[] args)
    {   
        // PART 1: PRINTING TO THE CONSOLE

        // print 'Hello World!'
        Console.WriteLine("Hello World!\n");

        // initialize string variable 'message'
        string message;

        // assign the 'message' variable 
        message = "Hello World!\n";

        // print the 'message' variable 
        Console.WriteLine(message);

        // PART 2: NUMERIC TYPES

        // declare and print some numeric variables of different types to the console
        int bigNumber = 211111111;
        Console.WriteLine("bigNumber is {0}\n", bigNumber);

        double pi = 3.1415;
        Console.WriteLine("pi is {0}\n", pi);

        byte index = 1;
        Console.WriteLine("index is {0}\n", index);

        // PART 3: NUMERIC OPERATIONS + - * / %

        int operation;
        operation = 2 + 5 * 4; // initializing operation with an arithmetic calculation
        Console.WriteLine("operation is 2 + 5 * 4");
        Console.WriteLine("operation result is {0}\n", operation);

        operation = (2 + 5) * 4; // c sharp honors PEMDAS automatically
        Console.WriteLine("operation is (2 + 5) * 4");
        Console.WriteLine("operation result is {0}\n", operation);

        operation = 25 / 2;
        Console.WriteLine("operation is 25 / 2");
        Console.WriteLine("operation result is {0}\n", operation);

        int modulo = 25 % 2;
        Console.WriteLine("operation is 25 % 2");
        Console.WriteLine("operation result is {0}\n", modulo);

        double dividingFloats;
        dividingFloats = 25.00 / 2.00;
        Console.WriteLine("operation is 25.00 / 2.00 (using type double)");
        Console.WriteLine("operation result is {0}\n", dividingFloats);

        // PART 4: CHAR AND CHARACTERS
        char myFirstInitial = 'R'; // characters are wrapped in single quotes
        char myLastInitial = 'M';

        char backSpace = '\b';
        char tab = '\t';

        char hexLetter = '\u004A';

        Console.WriteLine("My first initial = " + myFirstInitial + tab + "My last initial = " + myLastInitial);

        Console.WriteLine("Here is a 004A in hexadecimal value " + hexLetter);

        // PART 4: USER INPUT

        string firstName = "";
        string lastName = "";

        Console.Write("\nEnter your first name: "); // prompt the user
        firstName = Console.ReadLine(); // use Console.ReadLine() to collect input 

        Console.Write("\nEnter your last name: "); 
        lastName = Console.ReadLine(); // this method collects data as a string by default

        // print the results
        Console.Write("Your first name is {0} and your last name is {1}", firstName, lastName);

        // PART 5 : BOOLEAN DATA TYPES

        bool isRaining = false;
        bool isSunny = true;

        Console.WriteLine("Is it raining? " + isRaining);
        Console.WriteLine("Is it sunny? " + isSunny);

        // == < > <= >= != ! are the comparison operators 

        bool isBigger = 10 > 3;
        Console.WriteLine("Is 10 bigger than 3? " + isBigger);

        isBigger = 3 > 10;
        Console.WriteLine("Is 3 bigger than 10? " + isBigger);

        Console.Write("What is your name??? "); // prompt the user
        string name = Console.ReadLine(); // collect the input

        if(name.Length > 5) // use .Length to return the length of a string and check the if condition
        {
            Console.Write("Your name is long!");
        }
        else 
        {
            Console.Write("Your name is short!\n");
        }

        // PART 6: LOOPING

        int x = 0; // use x as a way to control the while loop 
        while(x < 5)
        {
            Console.WriteLine("\nCOUNT: {0}", x);
            x++;
        }

        // PART 7: METHODS
        myFirstMethod();

        Console.Write("Who should I greet? ");
        string friendName = Console.ReadLine();
        helloFriend(friendName);

        Console.Write("What is juniors first name? ");
        string junior = Console.ReadLine();

        Console.WriteLine("Ohhhh its " + addSuffix(junior));

    }

    public static void myFirstMethod()
    {
        string sentence = "C# is awesome!";
        Console.WriteLine(sentence);
    }
    public static void helloFriend(string name)
    {
        Console.WriteLine("Hello " + name);
    }
    public static string addSuffix(string name)
    {
        return name + " Jr";
    }
}
