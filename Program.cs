// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введи пятизначное число и я определю, палиндром ли оно: "); // палиндром - зеркальное число 45854 // т.е. надо сравнить первое и пятое, второе и четвертое
int numb = Convert.ToInt32(Console.ReadLine());
string strNumb = Convert.ToString(numb); // переводим в массив числа введенные с клавиатуры
if (strNumb.Length == 5) // если длина массива равна 5 по индексу пропускаем дальше
{
    if (strNumb[0] == strNumb[4] & strNumb[1] == strNumb[3] ) // нужно сравнить 0 и 4, 1 и 3 элемент массива
    {
    Console.WriteLine("да"); 
    }
    else
    {
    Console.WriteLine("нет");    
    }
}
else
{
    Console.WriteLine("Введи ПЯТЬ цифр");
}

// Задача 21h. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите Х1-координату"); 
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y1-координату");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z1-координату");
// int zA = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите Х2-координату"); 
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y2-координату");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z2-координату");
// int zB = Convert.ToInt32(Console.ReadLine());
// double dist = Math.Sqrt(Math.Pow(xB - xA , 2) + Math.Pow(yB - yA , 2) + Math.Pow(zB - zA , 2)); // тип double для запятых // по формуле (формула, 2 - степень)
// Console.WriteLine("Расстояние в 3d: " + Math.Round(dist, 2)); // (dist - уже в формате с плавающей запятой, 2 - знаки после запятой) // т.к. выводили корень

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Случайно получил калькулятор степеней))))

// Console.Write("Введите число, в которое надо возвести 2: ");
// int count = Convert.ToInt32(Console.ReadLine()); // по факту счетчик
// Console.WriteLine("Полученное число");
// for (int i = 1; i <= count; i++)
// {
// Console.Write(" " + Math.Pow(2, i)); // Console.WriteLine("Полученное число " + Math.Pow(2, a));
// }

// Console.Write("Введите число, до которого надо возводить в куб: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++) // счетчик нужен только для того, чтобы вовремя остановиться
// {                                        // переменная num меняется вместе со счетчиком и позволяет возводить себя в куб
// Console.Write(" " + Math.Pow(i, 3)); // т.к. после запятой это степени, а нам надо возвести к куб, то сразу пишем Math.Pow(переменная, 3)
// }