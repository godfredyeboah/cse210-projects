using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public int GetLengthMinutes() => _lengthMinutes;
    public DateTime GetDate() => _date;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthMinutes} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
