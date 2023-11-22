int Input(string text)
{
  Console.Write(text);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");

Console.Write($"Результат: {AkkermanFunction(m, n)}");