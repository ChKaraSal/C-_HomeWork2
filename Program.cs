//Задача №1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Обязательна проверка на ввод чисел больше/меньше 3-х знаков
Console.WriteLine("Задача №1");
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3);
if(numberS.Length != 3) 
{
    Console.WriteLine("Ошибка! Введите трёхзначное число");
} 
else 
{
    Console.WriteLine($"{number} -> {numberS[1]}");
}



//Задача №2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Берем числа до 100000
Console.WriteLine("Задача №2");
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num1S = Math.Abs(num1).ToString();
Console.WriteLine(num1S.Length > 2 || num1S.Length < 100000);
if(num1S.Length > 2 && num1S.Length < 100000) 
{
    Console.WriteLine($"{num1} -> {num1S[2]}");
} 
else 
{
    Console.WriteLine($"{num1} -> Ошибка! третьей цифры нет");
}


//Задача №3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//Обязательна проверка на ввод числа  от 1 и до 7.
Console.Write("Задача №3");
Console.WriteLine("Введите цифру: ");
int dayOfWeek = int.Parse(Console.ReadLine());
if(dayOfWeek > 0 && dayOfWeek < 8) 
{
    if(dayOfWeek == 6 || dayOfWeek == 7) 
    {
        Console.WriteLine($"{dayOfWeek} -> да");
    } 
    else 
    {
        Console.WriteLine($"{dayOfWeek} -> нет");
    }
} 
else 
{
    Console.WriteLine($"{dayOfWeek} -> не день недели");
}