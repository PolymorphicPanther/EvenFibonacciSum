namespace FibonacciSumChallenge;

public class FibonacciSumCalculator
{
    /// <summary>
    /// Adds all even Fibonacci numbers strictly less than the <paramref name="bound"/> and returns the result
    /// </summary>
    /// <param name="bound">positive integer</param>
    /// <returns>Sum of all even Fibonacci numbers below <paramref name="bound"/></returns>
    public int SumOfEvens(int bound)
    {
        if (bound <= 2) 
            return 0;
        if (bound <= 8)
            return 2;
        
        var n0 = 2; // Smaller even Fibonacci 
        var n1 = 8; // Larger even Fibonacci
        var sum = 10;
        
        while (true)
        {
            NextEvenFibonacciTerm(ref n0, ref n1);
            if (n1 < bound)
                sum += n1;
            else
                return sum;
        }
    }
    
    private void NextEvenFibonacciTerm(ref int n0, ref int n1)
    {
        n0 += n1 * 4;
        (n1, n0) = (n0, n1);
    }

}