abstract class Building
{
    private string _cmType;
    private int _cmCost;
    protected int _cmMaintenance;

    public Building(string type, int cost, int maintenance)
    {
        _cmType = type;
        _cmCost = cost;
        _cmMaintenance = maintenance;
    }

    public int GetMaintenance()
    {
        return _cmMaintenance;
    }

    public int GetCost()
    {
        return _cmCost;
    }

    public abstract void Impact(City city);

    public abstract void DisplayInfo();
}