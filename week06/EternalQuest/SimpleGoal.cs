public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public SimpleGoal(string name, string description, int points, bool completed)
        : base(name, description, points)
    {
        _isCompleted = completed;
    }

    public override int RecordEvent()
    {
        if (_isCompleted) return 0;
        _isCompleted = true;
        return Points;
    }

    public override string GetStatus()
    {
        return $"[{"X",1}] {Name} ({Description})";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isCompleted}";
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
}
