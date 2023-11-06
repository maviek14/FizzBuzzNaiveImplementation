namespace NaiveFizzBuzz;

public class FizzBuzz
{
    public static string ProcessNumber(int number)
    {
        string result = string.Empty;

        if(IsDivisibleBy(number, 3))
            result += "Fizz";
        if (IsDivisibleBy(number, 5))
            result += "Buzz";
        if (result.Length == 0)
            result = number.ToString();

        return result;
    }

    private static bool IsDivisibleBy(int number, int divider)
    {
        return number % divider == 0;
    }
}
