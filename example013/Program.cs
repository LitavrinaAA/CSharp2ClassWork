// Выводит случайное трехзначное число и удаляет вторую цифру этого числа
int num = new Random().Next(100,1000);
//123 % 10 -> 3
//12 / 100 -> 1
// 1*10 + 3 = 13

int DelSecondNum(int num){
    int firstNum = num / 100;
    int therdNum = num % 10;
    return firstNum*10 + therdNum;
}

System.Console.WriteLine($"Число {num} -> " + DelSecondNum(num));

