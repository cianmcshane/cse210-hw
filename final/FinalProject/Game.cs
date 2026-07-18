class Game
{
    private City _cmCity;
    private bool _cmIsRunning;

    public void StartGame()
    {
        _cmIsRunning = true;

        City _cmCity = new City(1000,10000,10,10);
        while (_cmIsRunning == true)
        {
            DisplayMenu();
            _cmCity.UpdateCityStats();
        }
    }

    public void DisplayMenu()
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       CITY MANAGER GAME         ");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Build a Building");
        Console.WriteLine("2. View City");
        Console.WriteLine("3. Save Game");
        Console.WriteLine("4. Load Game");
        Console.WriteLine("5. Quit");
        Console.WriteLine();

        Console.Write("Choose an option: ");
        string cmChoice = Console.ReadLine();

        if (cmChoice == "1")
        {
            BuildBuilding();
        }
        else if (cmChoice == "2")
        {
            ViewCity();
        }        
        else if (cmChoice == "3")
        {
            SaveManger save = new SaveManger();

            Console.WriteLine("Enter a file name: ");
            string cmSaveFile = Console.ReadLine();

            save.SaveGame();
        }
        else if (cmChoice == "4")
        {
            SaveManger load = new SaveManger();

            Console.WriteLine("Enter a file name: ");
            string cmLoadFile = Console.ReadLine();

            load.LoadGame();
        }
        else if (cmChoice == "5")
        {
            _cmIsRunning = false;
        }
    }

    public void BuildBuilding()
    {
        Console.Clear();

        Console.WriteLine("Choose a building to construct:");
        Console.WriteLine("1. House");
        Console.WriteLine("2. Park");
        Console.WriteLine("3. School");
        Console.WriteLine("4. Factory");
        Console.WriteLine();

        string choice = Console.ReadLine();

        Building building = null;

        if (choice == "1")
        {
            // building = new Housing();
        }
        else if (choice == "2")
        {
            // building = new Park();
        }
        else if (choice == "3")
        {
            // building = new School();
        }
        else if (choice == "4")
        {
            // building = new Factory();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            Console.ReadLine();
            return;
        }

        if (_cmCity.AddBuilding(building))
        {
            Console.WriteLine($"{building.GetType().Name} built successfully!");
        }
        else
        {
            Console.WriteLine("Not enough money to build that.");
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public void ViewCity()
    {
        
    }
}