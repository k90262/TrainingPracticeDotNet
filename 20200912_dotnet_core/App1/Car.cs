class Car
{
    private int _Speed;
    public int Speed
    {
        get
        {
            return _Speed;
        }
        set
        {
            if (value <= 100)
                _Speed = value;
        }
    }

    public int Torgue { get; set; } // short-cut: tyep 'prop', then click 'tab'
    public int Horsepower { get; set; }
}