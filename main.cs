using System;

class Program
{
    static void Main()
    {
        string userInput = "";
        string totalInput = "";
        int totalSum = 0;

        while (true)
        {
            Console.WriteLine("Enter something: ");
            userInput = Console.ReadLine();

            if (userInput == "exit")
            {
                break;
            }
            else if (int.TryParse(userInput, out int number))
            {
                totalSum += number;
                Console.WriteLine("Adding " + number + " to " + (totalSum - number) + " = " + totalSum);
            }
            else
            {
                totalInput += userInput;
                Console.WriteLine("Current Message is: " + totalInput);
            }
        }
        Console.WriteLine("Closing Program...");
    }
}
