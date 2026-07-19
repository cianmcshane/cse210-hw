class Factory : Building
{
        public Factory(string type, int cost, int maintenance) : base(type, cost, maintenance)
    {
    
    }

        public override void Impact(City city)
    {
        city.UpdateFactoryCount(1);
    }

        public override void DisplayInfo()
    {
        Console.WriteLine("Factory - 1: generates economic growth and pollution.");
    }
}