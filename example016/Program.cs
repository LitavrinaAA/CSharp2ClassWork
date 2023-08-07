// проверить является ли одно квадратом другого
int InputNum(string message)
{
    System.Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void IsSquare(int n1, int n2){
    if (n1*n1 == n2)
    System.Console.WriteLine($"{n2} квадрат {n1}");
    else
    System.Console.WriteLine($"{n2} не квадрат {n1}");

}
int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");
IsSquare(num1, num2);
