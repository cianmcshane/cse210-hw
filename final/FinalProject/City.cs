class City
{
    private int _cmBudget;
    private int _cmPopulation;
    private int _cmHappiness;
    private int _cmEducation;
    private List<Building> _cmBuildings;

    public City(int budget, int population, int happiness, int education)
    {
        _cmBudget = budget;
        _cmPopulation = population;
        _cmHappiness = happiness;
        _cmEducation = education;
        _cmBuildings = new List<Building>();
    }

    public bool AddBuilding(Building building)
    {
        if (_cmBudget >= building.GetCost())
        {
            _cmBudget -= building.GetCost();
            _cmBuildings.Add(building);
            return true;
        }

        return false;
    }

    public void UpdateCityStats()
    {
        int cmFactoryCount = 0;
        int cmTotalMaintenance = 0;

        foreach (Building building in _cmBuildings)
        {
            cmTotalMaintenance += building.GetMaintenance();

            if (building is Factory)
            {
                cmFactoryCount++;
            }
        }

        double income = (_cmPopulation * 100)
                    + (cmFactoryCount * 500)
                    + (_cmHappiness * 5);

        double educationMultiplier = Math.Pow(1.01, _cmEducation / 10.0);

        income *= educationMultiplier;

        _cmBudget += (int)income - cmTotalMaintenance;
    }

    public void UpdateBudget(int increase)
    {
        
    }

    public void UpdatePopulation(int increase)
    {
        _cmPopulation = _cmPopulation + increase;
    }
    
    public void UpdateEducation(int increase)
    {
        _cmEducation = _cmEducation + increase;
    }

    public void UpdateHappiness(int increase)
    {
        _cmHappiness = _cmHappiness + increase;
    }

    public void ViewCity()
    {
        Console.WriteLine("====================");
        Console.WriteLine("     City Stats     ");
        Console.WriteLine("=====================");
        Console.WriteLine("");
        Console.WriteLine($"Budget: ${_cmBudget}");
        Console.WriteLine($"Population: {_cmPopulation}");
        Console.WriteLine($"Happiness: {_cmHappiness}");
        Console.WriteLine($"Education: {_cmEducation}");
        Console.WriteLine("");
        Console.WriteLine("Buildings");
        Console.WriteLine("");


        if (_cmBuildings.Count == 0)
        {
            Console.WriteLine("No buildings have been constructed.");
        }
        else
        {
            foreach (Building building in _cmBuildings)
            {
                building.DisplayInfo();
            }
        }    

    }
}