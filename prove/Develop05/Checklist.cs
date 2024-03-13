class Checklist : Goal
{
    int Points;
    List<string> Goals = new List<string>();
    public Checklist (int Points, List<string> Goals) : base(Points, Goals)
    {
        
    }
}