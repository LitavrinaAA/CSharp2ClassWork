// Напишите программуб которая выводит случайное число из отрезка [10,99] и 
// и показывает наибольшую цифру числа

//Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8
int MaxDigit(int num)
{
    //85/10 -> 8
    //85%10 ->5
    if (num / 10 > num % 10)
        return num / 10;
    else
        return num % 10;
}
int number = new Random().Next(10,100);
int res = MaxDigit(number);
System.Console.WriteLine($"Число {number} максимальная цифра {res}");