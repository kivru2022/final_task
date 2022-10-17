

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int start, int end)
{
    if(start==end) return start.ToString();
    return(start + "," + PrintNumbers(start+1, end) );
}
Console.WriteLine($"Числа от {M} до {N}: {PrintNumbers(M, N)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int start, int end)
{
    if (start > end) return Console.WriteLine("Введите другие числа");
    if (start == end) return start;
   return(start + SumNumbers(start+1, end));
}
Console.WriteLine($"Числа  {M} и {N}, их сумма: {SumNumbers(M, N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// A(m, n) n+1 -> m=0;
        // A(m-1, 1) -> m > 0, n=0;
        //  A(m-1,  A (m, n-1)) -> m > 0, n > 0

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int AkkermFunc(int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0) return AkkermFunc(m-1, 1);
    return(AkkermFunc(m-1, AkkermFunc(m, n-1)));
    

}
Console.WriteLine($"Ваш результат вычисления функции {AkkermFunc(M, N)}");