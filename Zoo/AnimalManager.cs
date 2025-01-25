using Zoo;

public class AnimalManager : IAnimalManager
{
    private List<Animal> animals;
    private AnimalStorage storage;

    public AnimalManager()
    {
        storage = new AnimalStorage();
        animals = storage.LoadAnimals();
    }

    public void AddAnimals(Animal animal)
    {
        if (animals.Exists(a => a.ID == animal.ID))
        {
            Console.WriteLine("Animal with this ID already exists!");
        }
        else
        {
            animals.Add(animal);
            storage.SaveAnimals(animals);
            Console.WriteLine("Animal added successfully!");
        }
    }

    public void ViewAllAnimals()
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("No animals have been registered.");
        }
        else
        {
            animals.ForEach(a =>
            {
                a.DisplayDetails();
                Console.WriteLine();
            });
        }
    }

    public Animal GetAnimalByID(int id)
    {
        return animals.Find(a => a.ID == id);
    }

    public void RemoveAnimal(int id)
    {
        Animal animal = GetAnimalByID(id);
        if (animal != null)
        {
            animals.Remove(animal);
            storage.SaveAnimals(animals);
            Console.WriteLine("Animal removed successfully!");
        }
        else
        {
            Console.WriteLine("Animal not found!");
        }
    }

    public void EditAnimal(int id)
    {
        Animal animal = GetAnimalByID(id);
        if (animal != null)
        {
            Console.WriteLine("Enter new name:");
            animal.Name = Console.ReadLine();
            Console.WriteLine("Enter new species:");
            animal.Species = Console.ReadLine();
            Console.WriteLine("Enter new age:");
            animal.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new quantity:");
            animal.Quantity = int.Parse(Console.ReadLine());

            animal.Features.canFly = UserInput.GetYesNoInput("Can it fly?");
            animal.Features.isVenomous = UserInput.GetYesNoInput("Is it venomous?");
            animal.Features.canSwim = UserInput.GetYesNoInput("Can it swim?");
            animal.Features.canClimbTrees = UserInput.GetYesNoInput("Can it climb trees?");
            animal.Features.canRunFast = UserInput.GetYesNoInput("Can it run fast?");
            animal.Features.producesSpecialSounds = UserInput.GetYesNoInput("Does it produce special sounds?");

            storage.SaveAnimals(animals);
            Console.WriteLine("Animal edited successfully!");
        }
        else
        {
            Console.WriteLine("Animal not found!");
        }
    }
}
