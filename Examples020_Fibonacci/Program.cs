﻿double Fibonacci (int n)
{
  if (n == 1 || n == 2)
  {
    return 1;
  }
  else
  {
    return Fibonacci(n-1)+Fibonacci(n-2);
  }
}

for (int i = 1; i < 30; i++)
{
  Console.WriteLine($"F({i}) = {Fibonacci(i)}");
}