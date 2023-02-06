public class Player
{
    private string _playerName;
    private int _playerNumber;

    public Player(string name, int jersey)
    {
        _playerName = name;
        _playerNumber = jersey;
    }

    public void Display()
    {
        Console.WriteLine($"{_playerName} {_playerNumber}");
    }
}