public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    private int _lastMilestone = 0; // Add at the top if not already declared

public void SetLastMilestone(int milestone)
{
    _lastMilestone = milestone;
}

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target) {
            _timesCompleted++;
            return Points + (_timesCompleted == _target ? _bonus : 0);
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus() =>
        $"[{(_timesCompleted >= _target ? "X" : " ")}] {Name} ({_timesCompleted}/{_target})";

    public override string GetSaveString() =>
        $"Checklist|{Name}|{Description}|{Points}|{_timesCompleted}|{_target}|{_bonus}";
}

