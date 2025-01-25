using Zoo;

public class AnimalStorage
{
    private const string filePath = "animals.txt";

    public void SaveAnimals(List<Animal> animals)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"{animal.ID},{animal.Name},{animal.Species},{animal.Age},{animal.Quantity},{animal.Features.canFly},{animal.Features.isVenomous},{animal.Features.canSwim},{animal.Features.canClimbTrees},{animal.Features.canRunFast},{animal.Features.producesSpecialSounds}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving animals: {ex.Message}");
        }
    }

    public List<Animal> LoadAnimals()
    {
        List<Animal> animals = new List<Animal>();
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(",");
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    string species = parts[2];
                    int age = int.Parse(parts[3]);
                    int quantity = int.Parse(parts[4]);
                    bool canFly = bool.Parse(parts[5]);
                    bool isVenomous = bool.Parse(parts[6]);
                    bool canSwim = bool.Parse(parts[7]);
                    bool canClimbTrees = bool.Parse(parts[8]);
                    bool canRunFast = bool.Parse(parts[9]);
                    bool producesSpecialSounds = bool.Parse(parts[10]);

                    SpecialFeatures features = new SpecialFeatures(canFly, isVenomous, canSwim, canClimbTrees, canRunFast, producesSpecialSounds);
                    Animal animal = new Animal(name, species, age, quantity, features);
                    animals.Add(animal);
                }
            }
        }
        return animals;
    }
}
