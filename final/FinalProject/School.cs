class School : Building
{
    private int _cmEducationBoost;

    public School(string type, int cost, int maintenance, int educationBoost) : base(type, cost, maintenance)
    {
        _cmEducationBoost = educationBoost;
    }

    public override void Impact()
    {
        
    }

        public override void DisplayInfo()
    {
        
    }
}