// Создать массив из 10 чисел
// Сложить все двузначные числа
// Вывести сумму на экран


int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] elements)
{
    int length = elements.Length;
    int index  = 0;

    while (index < length)
    {
        int current = Random.Shared.Next(30);
        elements[index] = current;
        index = index + 1;
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

        if (10 <= current && current <= 99)
        {
            sum = sum + current;
            
        }
        position = position + 1;
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
        output = output + $"{current} ";
        index = index + 1;
    }
    return output;
}

int[] arr = CreateArray(5);
Fill(arr);
int sum = GetSum(arr);

Console.WriteLine(Print(arr));
Console.WriteLine($"sum = {sum}");