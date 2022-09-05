// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool GetNumber(int num1,int num2, int num3)
{
    if(num1 > num2 + num3)
    return false;
    else if(num2 > num1 + num3 )
    return false;
    else if(num3 > num1 + num2 )
    return false;
    else return true;
}

bool Triangle = GetNumber(10,4,5);
if(Triangle == true)
{
    Console.WriteLine("Треугольник может существовать.");
}
else
{
    Console.WriteLine("Треугольник не может существовать.");
}

// Console.WriteLine("Введите стороны треугольника(a,b,c): ");
// double number1 = Convert.ToDouble(Console.ReadLine());
// double number2 = Convert.ToDouble(Console.ReadLine());
// double number3 = Convert.ToDouble(Console.ReadLine());


// void CheckTriangle(double a,double b,double c)
// {
//     if( a < b + c && b < c + a && c < a + b)
//     {
//         Console.WriteLine("треугольник со сторонами такой длины может существовать.");
//     }
//     else
//     {
//         Console.WriteLine("такой треугольник не существует");
//     }
// }
// CheckTriangle(number1,number2,number3);
