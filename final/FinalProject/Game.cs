class Game
{
    private City _cmCity;
    private bool _cmIsRunning;

    public void StartGame()
    {
        _cmIsRunning = true;

        _cmCity = new City(5000, 1000, 50, 10);

        while (_cmIsRunning == true)
        {
            DisplayMenu();
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
        Console.WriteLine("3. End Turn");
        Console.WriteLine("4. Save Game");
        Console.WriteLine("5. Load Game");
        Console.WriteLine("6. Quit");
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
            _cmCity.EndTurn();

            Console.WriteLine("A new turn has begun!");
            Console.ReadLine();
        }
        else if (cmChoice == "4")
        {
            SaveManager save = new SaveManager();

            Console.Write("Enter a file name: ");
            string cmSaveFile = Console.ReadLine();

            save.SaveGame(cmSaveFile, _cmCity);

            Console.WriteLine("Game saved!");
            Console.ReadLine();
        }
        else if (cmChoice == "5")
        {
            SaveManager load = new SaveManager();

            Console.Write("Enter a file name: ");
            string cmLoadFile = Console.ReadLine();

            _cmCity = load.LoadGame(cmLoadFile);

            Console.WriteLine("Game loaded!");
            Console.ReadLine();
        }
        else if (cmChoice == "6")
        {
            _cmIsRunning = false;
        }
        else
        {
            Console.WriteLine("Invalid option.");
            Console.ReadLine();
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
            building = new Housing("Housing", 500, 0, 100);
        }
        else if (choice == "2")
        {
            building = new Park("Park", 300, 25, 10);
        }
        else if (choice == "3")
        {
            building = new School("School", 1000, 100, 5);
        }
        else if (choice == "4")
        {
            building = new Factory("Factory", 2000, 200);
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
        Console.Clear();

        _cmCity.ViewCity();

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}