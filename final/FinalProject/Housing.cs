class Housing : Building
{
    private string _cmSubType;
    private int _cmResidents;

    public Housing(string type, int cost, int maintenance, string subType, int residents) : base(type, cost, maintenance)
    {
        _cmSubType = subType;
        _cmResidents = residents;   
    }

    public override void Impact()
    {
        
    }

        public override void DisplayInfo()
    {
        
    }
}