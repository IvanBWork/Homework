int[] Input(string text)
{
    Console.Write(text);
    int elementsCount = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[elementsCount];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 99);
    } 
    return array;
}

void ReverseArray(int[] array, int n, int i = 0)
{
    if (i < array.Length)
    {
        Console.Write(array[n] + " ");
        ReverseArray(array, n - 1, i + 1);
    }
}

void PrintArray(int[] array)
{
    string result = string.Join(" ", array);
    Console.WriteLine($"Ваш массив: {result}");
}

int[] array = Input("Введите кол-во элементов массива: ");
int n = array.Length - 1;
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.Write("Обратный массив: ");
ReverseArray(array, n);