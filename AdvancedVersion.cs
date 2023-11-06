namespace NaiveFizzBuzz;
public class AdvancedVersion
{
    private static bool IsDivisibleBy(int number,  int divisor)
    {
        if (number % divisor == 0)
            return true;
        else
            return false;
    }
}
