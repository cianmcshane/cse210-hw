class Housing : Building
{
    private int _cmResidents;

    public Housing(string type, int cost, int maintenance, int residents) : base(type, cost, maintenance)
    {
        _cmResidents = residents;
    }

    public override void Impact(City city)
    {
        city.UpdatePopulation(_cmResidents);
    }

        public override void DisplayInfo()
    {
        Console.WriteLine($"House - Residents: {_cmResidents}");
    }
}