using Zoo;

class Program
{
    static void Main(string[] args)
    {
        IAnimalManager zoo = new AnimalManager();
        bool running = true;

        while (running)
        {
            string choice = UserInput.GetValidChoice();

            try
            {
                switch (choice)
                {
                    case "1":
                        AddAnimal(zoo);
                        break;
                    case "2":
                        zoo.ViewAllAnimals();
                        break;
                    case "3":
                        ViewAnimalDetails(zoo);
                        break;
                    case "4":
                        RemoveAnimal(zoo);
                        break;
                    case "5":
                        EditAnimal(zoo);
                        break;
                    case "6":
                        running = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    static void AddAnimal(IAnimalManager zoo)
    {
        Console.WriteLine("Enter species:");
        string species = Console.ReadLine();
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter quantity:");
        int quantity = int.Parse(Console.ReadLine());

        bool canFly = UserInput.GetYesNoInput("Can it fly?");
        bool isVenomous = UserInput.GetYesNoInput("Is it venomous?");
        bool canSwim = UserInput.GetYesNoInput("Can it swim?");
        bool canClimbTrees = UserInput.GetYesNoInput("Can it climb trees?");
        bool canRunFast = UserInput.GetYesNoInput("Can it run fast?");
        bool producesSpecialSounds = UserInput.GetYesNoInput("Does it produce special sounds?");

        SpecialFeatures features = new SpecialFeatures(canFly, isVenomous, canSwim, canClimbTrees, canRunFast, producesSpecialSounds);
        Animal animal = new Animal(name, species, age, quantity, features);
        zoo.AddAnimals(animal);
    }

    static void ViewAnimalDetails(IAnimalManager zoo)
    {
        Console.WriteLine("Enter animal ID:");
        int id = int.Parse(Console.ReadLine());
        Animal foundAnimal = zoo.GetAnimalByID(id);
        if (foundAnimal != null)
        {
            foundAnimal.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Animal not found!");
        }
    }

    static void RemoveAnimal(IAnimalManager zoo)
    {
        Console.WriteLine("Enter animal ID:");
        int removeId = int.Parse(Console.ReadLine());
        zoo.RemoveAnimal(removeId);
    }

    static void EditAnimal(IAnimalManager zoo)
    {
        Console.WriteLine("Enter animal ID:");
        int id = int.Parse(Console.ReadLine());
        zoo.EditAnimal(id);
    }
}
