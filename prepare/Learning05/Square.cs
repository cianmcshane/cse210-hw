class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}


// Organism o1 = new Organism()
// Organism o1 = new Mammal();
// Organism o3 = new Whale();
// Mammal o4 = new Mammal();
// Mammal o5 = new Whale();
// Whale 06 = new Whale();