namespace MethodsDemoCSharp_62;

public class Helper
{
    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Nice meeting you {name}.");
    }

    public static void AskColor()
    {
        Console.WriteLine("What color do you wear most out here, I feel like it affects the game reaction?");
        string color = Console.ReadLine();
        Console.WriteLine($"{color} really? Thought it might've been red since you got the rifle to go with" +
                          $"your plaid lol!");
    }
    
    public static void AskFavoriteAnimal()
    {
        Console.WriteLine("What's your game of choice?");
        string animal = Console.ReadLine();
        Console.WriteLine($"I hunt {animal} too but mostly pheasants! The hounds around here somewhere.");
    }

    public static void AskFavMusic()
    {
        Console.WriteLine("I normally come out here and listen to country, helps me lock in" +
                          $" you know what I mean! What do you listen to?");
        string favMusic = Console.ReadLine();
        Console.WriteLine($"{favMusic} alright now!  ");
    }
}