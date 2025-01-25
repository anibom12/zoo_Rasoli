using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public interface IAnimalManager
{
    void AddAnimals(Animal animal);
    void ViewAllAnimals();
    Animal GetAnimalByID(int id);
    void RemoveAnimal(int id);
    void EditAnimal(int id);
}
