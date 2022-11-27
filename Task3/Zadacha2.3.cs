// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. . Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Chat(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    //отрицательные числа тоже бывают трехзначными)
    return (response);
}

int Num = Chat("Введите число, пожалуйста ");
int i = 100;
if (i <= Num)
{
    while (i - 1 < Num)
    {
        i = i * 10;
    }

    i = i / 1000;
    System.Console.Write($"Третья цифра введенного числа: {(Num / i) % 10} !");
}
else { System.Console.Write("Увы, третьей цифры нет."); }