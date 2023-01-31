/*
67. Число на вход и возвращать сумму его цифр

453 - 12;
45 - 9;
*/

Console.Write ("Enter the natural number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(SumOfNumbers(m));

int SumOfNumbers (int num)
{
    if (num == 0) return num;
    else return num%10 + SumOfNumbers(num/10);

}
