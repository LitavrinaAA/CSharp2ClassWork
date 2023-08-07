// Принимает два числа и проверяет является ли второе кратным первому
// 16 % 4 -> 0
//System.Console.WriteLine("Введите первое число:");
//int firstNum = int.Parse(Console.RedLine()!);
int InputNum(string message)
{
    System.Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
bool CheckAliquot(int firstN, int secN)
{
    // if (firstN % secN == 0)
    //     return true;
    // else
    //     return false;
    return firstN%secN == 0;

}
int firstNum = InputNum("Введите первое число");
int SecondNum = InputNum("Введите второе число");
bool checkAliquot = CheckAliquot(firstNum, SecondNum);
System.Console.WriteLine(checkAliquot);
