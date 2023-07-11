// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int Cube = i * i * i;
        Console.WriteLine(Cube);
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
Cube(number);