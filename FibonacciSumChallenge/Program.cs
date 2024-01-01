using FibonacciSumChallenge;

var bound = 4_000_000;
var sum = new FibonacciSumCalculator().SumOfEvens(bound);

Console.WriteLine($"Sum of even fibonacci numbers below {bound} is {sum}.");