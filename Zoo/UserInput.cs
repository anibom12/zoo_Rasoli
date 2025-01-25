public static class UserInput
{
    public static string GetValidChoice()
    {
        string choice;
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. View All Animals");
            Console.WriteLine("3. View Animal Details");
            Console.WriteLine("4. Remove Animal");
            Console.WriteLine("5. Edit Animal");
            Console.WriteLine("6. Exit");

            choice = Console.ReadLine();

            if (new[] { "1", "2", "3", "4", "5", "6" }.Contains(choice))
            {
                break;
            }

            Console.WriteLine("Invalid choice. Please select one of the options below.");
        }

        return choice;
    }

    public static bool GetYesNoInput(string prompt)
    {
        string input;
        while (true)
        {
            Console.WriteLine(prompt + " (yes/no):");
            input = Console.ReadLine().Trim().ToLower();

            if (input == "yes")
            {
                return true;
            }
            else if (input == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
    }
}
