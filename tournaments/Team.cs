public class Team
{
    private string _teamName;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _teamName = name;
    }

    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_teamName);
        Console.WriteLine($"Wins: {_wins}  Losses: {_losses}");
        Console.WriteLine("-------------------");
        foreach (Player p in _roster)
        {
            p.Display();
        }
    }

    public void AddWin()
    {
        _wins += 1;
    }

    public void AddLoss()
    {
        _losses += 1;
    }
    public string GetTeamName()
    {
        return name;
    }
}