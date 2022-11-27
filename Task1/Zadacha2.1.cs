// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Chat(string request)
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.Write($" {request} >>");
        response = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
        //отрицательные числа тоже бывают трехзначными)
        
        if ((response > 99) && (response < 1000))
        {
            rightInput = true;
        }
        else { System.Console.Write($"Неверный ввод, попробуйте еще раз!"); }
    }
    return (response);
}

int Answer = Chat("Введите трехзначное число, пожалуйста");

System.Console.WriteLine($"Вторая цифра введенного числа: {(Answer / 10) % 10}! " );