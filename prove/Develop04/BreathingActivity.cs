class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
    public void Middle()
    {

        DateTime _cmEndTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("");

        while (_cmEndTime > DateTime.Now) {
            Console.WriteLine("Breath in...");
            for (int i = 3; i >= 1; i--)
            {
                Console.Clear();
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("Breath out...");
            for (int i = 3; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
        }
    }
}