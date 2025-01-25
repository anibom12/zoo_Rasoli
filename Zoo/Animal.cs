using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zoo;

public class Animal
{
    private static int uniqueIDCounter;
    private int uniqueID;
    public int ID { get { return uniqueID; } }
    private string? name;
    private string? species;
    private int age;
    private int quantity;
    private SpecialFeatures specialfeatures;



    public string Name { get { return name; } set { name = value; } }
    public string Species { get { return species; } set { species = value; } }
    public int Age { get { return age; } set { age = value; } }
    public int Quantity { get { return quantity; } set { quantity = value; } }

    public  SpecialFeatures Features{ get { return specialfeatures; } set { specialfeatures = value; } }

    public Animal(string Name,string Species,int Age,int Quantity, SpecialFeatures Features)
    {
        uniqueIDCounter++;
        uniqueID = uniqueIDCounter;

        name = Name;
        species = Species;
        age = Age;
        quantity = Quantity;
        specialfeatures = Features;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {ID}\n Name: {Name}\n Species: {Species}\n Quantity; {Quantity}\n SpecialFeatures: {Features}");
    }












}
