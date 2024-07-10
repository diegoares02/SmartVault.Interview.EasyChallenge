using TwistedFizzBuzz;
public class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> tokenNumbers = new Dictionary<int, string>();
        tokenNumbers.Add(5, "Fizz");
        tokenNumbers.Add(9, "Buzz");
        tokenNumbers.Add(27, "Bar");
        Console.WriteLine(FizzBuzz.TFizzBuzz(tokenNumbers, "-20 - 127"));
        Console.ReadKey();
    }
}
