namespace MethodsDemoCSharp_62;

class Program
{
    //Create custom methods here
    
    static void Main(string[] args)
    {
        Helper.AskName();
        
        Helper.AskColor();
        
        Helper.AskFavoriteAnimal();
        
        Helper.AskFavMusic();
        
        
        GreetUserByName("Seth");
        GreetUserByName("Cynthia");

        double sum = DoubleAddition(2.5, 2.5);
        Console.WriteLine($"Sum = {sum}");
    }
    
    //Or create custom methods here
    
    //Method definition (creating a method)
    //access modifier - return type - method name (PascalCase) - parameter list - scope/body
    public static void GreetUserByName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static double DoubleAddition(double numOne, double numTwo)
    {
        //double sum = numOne + numTwo;

        return numOne + numTwo;
    }
}
