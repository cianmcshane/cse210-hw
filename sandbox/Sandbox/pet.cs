public class Pet
{
    public string _name;
    public string _species;
    public int _age;
    public string _owner;

    public Pet(string name, string species, int age, string owner)
    {
        _name = name;
        _species = species;
        _age=age;
        _owner=owner;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}, Species{_species}, Age{_age}, Owner: {_owner}");
    }

    
}