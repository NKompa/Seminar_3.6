// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int value = 6;
//     string binary = Convert.ToString(value, 2);

// Console.WriteLine(binary);

void ConvertNum(int number)
{
    string resalt = "";
    while(number>0)
    {
        resalt = number%2+resalt;
        number/=2;

    }
    Console.WriteLine(resalt);

}
int intput= Convert.ToInt32(Console.ReadLine());
ConvertNum(intput);
