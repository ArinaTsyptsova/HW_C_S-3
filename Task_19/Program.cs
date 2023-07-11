// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

string? GetInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string? number = GetInput("Введите пятизначное число: ");
if (number!.Length == 5)
{
    CheckNumber(number);
}
else Console.WriteLine($"Ваше число НЕ пятизначное");