namespace test;

public class Computer
{
    private Client _client;
    private int _minutesRamaining;

    public bool IsTaken
    {
        get { return _minutesRamaining > 0; }
    }

    public int PricePerMinute { get; private set; }

    public Computer(int pricePerMinutes)
    {
        PricePerMinute = pricePerMinutes;
    }

    public void BecomeTaken(Client client)
    {
        _client = client;
        _minutesRamaining = client.DesiredMinutes;
    }

    public void BecomeEmpty()
    {
        _client = null;
    }

    public void SpendOneMinute()
    {
        _minutesRamaining--;
    }

    public void ShowState()
    {
        if (IsTaken)
            Console.WriteLine($"Computer is busy, {_minutesRamaining} minutes left.");
        else
            Console.WriteLine($"Computer is free, price per minute: {PricePerMinute}");
    }
}