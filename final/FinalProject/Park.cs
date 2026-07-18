class Park : Building
{
    private int _happinessBoost;

    public Park(string type, int cost, int maintenance, int happinessBoost) : base(type, cost, maintenance)
    {
        _happinessBoost = happinessBoost;
    }
    
    public override void Impact()
    {
        
    }

    public override void DisplayInfo()
    {
        
    }
}