// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа. Не использовать строки для расчета
// 456 -> 46
// 782 -> 72
// 918 -> 98

int Num = new Random().Next(100, 1000);
System.Console.Write($"Если у числа {Num} удалить вторую цифру,");
Num = (Num / 100) * 10 + Num % 10;
System.Console.Write($"останется только {Num}. Как-то так)");



//если рандомить со знаком, можно было бы так: 

// int Num = new Random().Next(-899, 900);
// int AbsNum=Math.Abs(Num);
// int sign = Num/AbsNum;
// Num=(AbsNum+100)*sign;
//  AbsNum=Math.Abs(Num);
// System.Console.Write($"Если у числа {Num} удалить вторую цифру,");
// Num = ((AbsNum / 100) * 10 + AbsNum % 10)*sign;
// System.Console.Write($"останется только {Num}. Как-то так)");

//Правда, жаль -100 не выпадет(