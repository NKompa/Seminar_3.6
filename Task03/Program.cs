// Напишите программу, которая будет преобразовывать десятичное число в двоичное: 45 -> 101101; 3  -> 11; 2  -> 10.

void ConvertNum(int number)
{
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;

    }
    Console.WriteLine(result);

}
int input = Convert.ToInt32(Console.ReadLine());
ConvertNum(input);
