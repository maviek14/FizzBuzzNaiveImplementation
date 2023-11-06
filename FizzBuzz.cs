namespace NaiveFizzBuzz;

public class FizzBuzz
{
    public static string ProcessNumber(int number)
    {
        string result = string.Empty;

        if (number % 3 == 0)
            result += "Fizz";
        if (number % 5 == 0)
            result += "Buzz";
        if (result.Length == 0)
            result = number.ToString();

        return result;
    }
}
