class Checklist : Goal
{
    int Points;
    Dictionary<string,string> Goals = new Dictionary<string,string>();
    public Checklist (int Points, Dictionary<string,string> Goals) : base(Points, Goals)
    {
        
    }
}