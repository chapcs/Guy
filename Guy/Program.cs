internal class Program
{
    private static void Main(string[] args)
    {
        // object initializers
        Guy joe = new Guy() { cash = 50, name = "Joe" };
        Guy bob = new Guy() { cash = 100, name = "Bob" };

        while (true)
        {
            // calling writemyinfo methods
            joe.WriteMyInfo();
            bob.WriteMyInfo();
            Console.Write("Enter an amount: ");

        }
            Console.WriteLine("Hello, World!");
    }
}

class Guy
{
    public string name;
    public int cash;
    // writes name and cash amounts
    public void WriteMyInfo()
    {
        Console.WriteLine(name + " has " + cash + " bucks");
    }
    // removing amount of cash from wallet
    public int GiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(name + " says: " + amount + " isn't a valid amount");
            return 0;
        }
        if (amount > cash)
        {
            Console.WriteLine(name + " says: I don't have enough cash to give you " + amount);
            return 0;
        }
        cash -= amount;
        return amount;
    }
    // adding amount of cash to wallet
    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(name + " says: " + amount + " isn't an amount I'll take");
        }
        else
        {
            cash += amount;
        }
    }
}