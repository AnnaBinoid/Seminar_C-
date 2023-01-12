// Создать массив из 10 чисел
// Сложить все двузначные числа
// Вывести сумму на экран


int[] CreateArray()
{
    return new int[10];
}

void FillArray(int[] elements)
{
    int length = elements.Length;
    int index  = 0;

    for (int i = 0; i <= length; i++)
    {
        elements[index] = Random.Shared.Next(30);
    }
}

int GetSum(int[] array)
{
    int size = array.Length;
    int sum = 0;

    int position = 0;

    while (position < size) //пока position < длины массива
    {
        int current = array[position];     // current = значению эл-та массива под номером position

        if (0 <= current && current <= 99)
        {
            sum = sum + current;
        }
    }
    return sum;
}

string Print(int[] collection)
{
    string output = String.Empty;

    int size2 = collection.Length;
    int index = 0;
    while (index < size2)
    {
        int current = collection[index];
        output = output + $"{current}";
    }
    return output;
}

int[] arr = CreateArray();
FillArray(arr);
int sum = GetSum(arr);

Console.WriteLine(Print(arr));
Console.WriteLine($"sum = {sum}");