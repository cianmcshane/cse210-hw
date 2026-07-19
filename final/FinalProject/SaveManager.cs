using System.IO;

class SaveManager
{
    public void SaveGame(string fileName, City city)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(city.GetBudget());
            outputFile.WriteLine(city.GetPopulation());
            outputFile.WriteLine(city.GetHappiness());
            outputFile.WriteLine(city.GetEducation());

            Console.WriteLine("Game saved successfully.");
        }
    }


    public City LoadGame(string fileName)
    {
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            int budget = int.Parse(inputFile.ReadLine());
            int population = int.Parse(inputFile.ReadLine());
            int happiness = int.Parse(inputFile.ReadLine());
            int education = int.Parse(inputFile.ReadLine());

            City city = new City(budget, population, happiness, education);

            Console.WriteLine("Game loaded successfully.");

            return city;
        }
    }
}