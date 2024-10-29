using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, double speed) : base(date, duration)
    {
        _name = "Cycling";
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        double distance = _speed * _duration / 60;
        return distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}