// // Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Fi
int firstNum = 0;
int secondNum = 1;
Console.Write(firstNum + " ");
Console.Write(secondNum + " ");

for (int i = 3; i <=num; i++)
{
    int newNum = firstNum + secondNum;
    Console.Write(newNum + " ");
    firstNum = secondNum;
    secondNum = newNum;
}