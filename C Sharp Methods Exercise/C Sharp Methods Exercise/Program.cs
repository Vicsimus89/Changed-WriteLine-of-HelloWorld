internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello. What is your name?");
        string userName = Console.ReadLine();

        Console.WriteLine("What do you like to do for fun?");
        string userActivity = Console.ReadLine();

        Console.WriteLine("What is your favorite drink?");
        string userDrink = Console.ReadLine();

        Console.WriteLine("What's something you do when you're nervous?");
        string userNervousness = Console.ReadLine();

        Console.WriteLine($"Tommy and {userName}, were playing {userActivity} when all of a sudden flying overhead a bird pooped on my head.");
        Console.WriteLine($"I didn't have any water so I poured {userDrink} on my head to wash it out, but that just made it worse.");
        Console.WriteLine($"My hair stunk and I started to {userNervousness}, because the person I liked was walking towards me.");
        Console.WriteLine($"They did't care and still wanted to play with Tommy and I.");

        Console.WriteLine("Give me a number to add.");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Give me a number to add to the first number.");
        int num2 = int.Parse(Console.ReadLine());

        int sum = Sum(num1, num2);
        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine("Give me a number to multiply.");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Give me a number to multiply to the first number.");
        num2 = int.Parse(Console.ReadLine());

        int product = Multiply(num1, num2);
        Console.WriteLine($"The product is: {product}");
    }

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }
}
