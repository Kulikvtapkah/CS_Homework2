//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным. Не использовать строки
// 6 -> да
// 7 -> да
// 1 -> нет

int Chat(string request)
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.Write($" {request} >> ");
        response = Convert.ToInt32(Console.ReadLine());

        if ((response > 0) && (response < 8))
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Хмм, неделя не так устроена... Всего 7 дней! Попробуйте еще раз!"); }
    }
    return (response);
}

int Num = Chat("Введите день недели цифрой, пожалуйста ");
if (Num > 5) { System.Console.Write("Да! Выходной, ура!"); }
else { System.Console.Write("Нет, пора на работу!"); }
