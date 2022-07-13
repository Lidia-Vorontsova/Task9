int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное число = {number}");

int secondDigit = number % 10;
int firstDigit = number / 10;

Console.WriteLine($"первая цифра = {firstDigit}, вторая цифра = {secondDigit}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"первая цифра числа {number} больше. Это {firstDigit}");
}
else
{
     Console.WriteLine($"вторая цифра числа {number} больше. Это {secondDigit}");
}