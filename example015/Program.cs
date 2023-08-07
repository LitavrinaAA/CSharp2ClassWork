// принимает на вход число и прверяет кратно ли оно одновременно 7 и 23
int InputNum(string message)
{
    System.Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
bool Check723(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
int num = InputNum("Введите число: ");
System.Console.WriteLine(Check723(num));



