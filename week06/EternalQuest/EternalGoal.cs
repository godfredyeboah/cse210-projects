public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) {}

    public override int RecordEvent() => Points;

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[∞] {Name}";

    public override string GetSaveString() => $"Eternal|{Name}|{Description}|{Points}";
}
