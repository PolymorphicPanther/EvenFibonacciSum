# FibonacciSumChallenge

A program that calculates the sum of the even Fibonacci numbers strictly below 4 million.   

## Building & running

1. Download and install .NET 8.0 (lower versions would also likely work although untested)
2. Clone repo from GitHub
3. Navigate to project folder (..\FibonacciSumChallenge\FibonacciSumChallenge)
4. Open preferred command prompt
5. Run command ```dotnet run ```

## Algorithm walk through

Following the problem statement, an initial solution which calculates all the Fibonacci numbers below 4 000 000 and only adds the even numbers is relatively trivial. A shortcoming of this algorithm would be the wasted work that is involved in calculating the odd numbers which are essentially discarded and not used in calculating the final result.

Looking at the Fibonacci sequence itself $1, 2, 3, 5, 8, 13, 21, 34, 55 ...$ it can be seen the parity of the numbers follow a pattern, that is the numbers seem to be  _odd, **even**, odd, odd, **even**, odd, odd, **even**, odd, ..._. Every third number starting from the first even number is also even, intuitively this is true since the sum of two odd numbers is an even number. 

Therefore, if only every third term could be calculated, the amount of wasted intemediary work is significantly reduced.

In mathematical notation this can be expressed as any term $\mathbf{F}\_{n+6}$ should be able to be computed as a function of $\mathbf{F}\_{n+3}$ and $\mathbf{F}\_{n}$ that is $\mathbf{F}\_{n+6} = f(\mathbf{F}\_{n},\mathbf{F}\_{n+3})$. 

Using some algebra, this can be shown to indeed be the case:

$\mathbf{F}\_{n+6} = \mathbf{F}\_{n+5} +\mathbf{F}\_{n+4}$

$\mathbf{F}\_{n+6} = \mathbf{F}\_{n+3} + \mathbf{F}\_{n+4} + \mathbf{F}\_{n+4}$

$\mathbf{F}\_{n+6} = \mathbf{F}\_{n+3} + \mathbf{F}\_{n+4} + \mathbf{F}\_{n+3} + \mathbf{F}\_{n+2}$

$\mathbf{F}\_{n+6} = 2 * \mathbf{F}\_{n+3} + \mathbf{F}\_{n+4} + \mathbf{F}\_{n+2} $

$\mathbf{F}\_{n+6} = 2 * \mathbf{F}\_{n+3} + \mathbf{F}\_{n+3} + \mathbf{F}\_{n+2} + \mathbf{F}\_{n+2} $

$\mathbf{F}\_{n+6} = 3 * \mathbf{F}\_{n+3} + \mathbf{F}\_{n+2} + \mathbf{F}\_{n+2} $

$\mathbf{F}\_{n+6} = 3 * \mathbf{F}\_{n+3} + \mathbf{F}\_{n+2} + \mathbf{F}\_{n+1} + \mathbf{F}\_{n} $

$\mathbf{F}\_{n+6} = 3 * \mathbf{F}\_{n+3} + \mathbf{F}\_{n+3} + \mathbf{F}\_{n} $

$\mathbf{F}\_{n+6} = 4 * \mathbf{F}\_{n+3} + \mathbf{F}\_{n} $

Given that the first two even terms of the Fibonacci sequence are 2 and 8 and using the formula derived above all the even Fibonacci numbers can be calculated without having to calculate and or store the odd Fibonacci numbers. 
