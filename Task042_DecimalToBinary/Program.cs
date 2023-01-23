/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int number = 13;
string result = NumberToBinary (number);
Console.WriteLine(result);

string NumberToBinary (int num)
{
    string binar = string.Empty;
    
    while (num > 0)
    {
        binar = num % 2 + binar;
        num = num/2;
    }
    return binar;
    
}

/*void ReverseNumber (string res)
{

}*/

/*Console.Write("Введите число для преобразования в двоичную систему счисления: ");int number = Convert.ToInt32(Console.ReadLine());int convertDecimalToBinary = ConvertDecimalToBinary(number);Console.WriteLine(convertDecimalToBinary);int ConvertDecimalToBinary(int num){    int result = 0;    int multiplyer = 1;    while (num != 0)    {        result = result + num % 2 * multiplyer;        num = num / 2;        multiplyer *= 10;    }    return result;}

*/