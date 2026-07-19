class Park : Building
{
    private int _cmHappinessBoost;

    public Park(string type, int cost, int maintenance, int happinessBoost) : base(type, cost, maintenance)
    {
        _cmHappinessBoost = happinessBoost;
    }
    
    public override void Impact(City city)
    {
        city.UpdateHappiness(_cmHappinessBoost);
        city.UpdateTotalMaintenance(+_cmMaintenance);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Park - Happiness+ {_cmHappinessBoost}, Maintenance: {_cmMaintenance}");
    }
}