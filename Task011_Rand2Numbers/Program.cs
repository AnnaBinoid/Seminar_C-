/*
11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randNumber = new Random().Next(100, 1001);
Console.WriteLine ($"New random integer is {randNumber}!");

int deleteSecondDigit = DeleteSecondDigit(randNumber);
Console.WriteLine ($"New number is {deleteSecondDigit}!");

int DeleteSecondDigit(int num)
{
    int hun = randNumber / 100;
    int ten = randNumber / 10;
    int one = randNumber % 10;

    int newNumber = hun*10 + one;
    return newNumber;
}



/*Console.WriteLine ($"In {randNumber} hundreds :{hun}; tens : {ten}; digits : {one}!");
Console.WriteLine ($"New number is {newNumber}!"); */