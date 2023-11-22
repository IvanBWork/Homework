int Input(string text)
{
  Console.Write(text);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void PrintNumbers(int m, int n)
{
  if (n > m) PrintNumbers(m, n - 1);
  Console.Write($"{n} ");
}

int m = Input("Введите первое число: ");
int n = Input("Введите второе число: ");

Console.WriteLine("Результат: ");
PrintNumbers(m, n);