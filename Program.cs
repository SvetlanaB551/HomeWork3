// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Ex19()
{
    Console.WriteLine("Введите пятизначное число: ");
    
    int NumberOne(int num, int NumberOfFirstNumbers = 2)
    {
        while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
        {
            num /= 10;
        }
        return num;
    }

    int number = int.Parse(Console.ReadLine());
    if (number < 0) number *= -1;
    if (number > 99)
    {

        int x = number % 100;
        int y = NumberOne(number);
        if (x / 10 == y % 10 && x % 10 == y / 10)
        {
            Console.WriteLine("Введенное число является полиндромом");
        }

        Console.WriteLine("Введенное число не является полиндромом");
    }
}
//Ex19();


void Ex21()
{

}

void Ex23()
{
    Console.WriteLine("Введите число: ");

    int N = int.Parse(Console.ReadLine());
    
    for (int x=1; x<=N; x++)
  

    Console.WriteLine(x+"- " + Math.Pow(x, 3));
}
Ex23();