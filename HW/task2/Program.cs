int Array (int any, int tmp, int result)
{
    if(tmp <= any)
    {
        result = result + tmp;
        return Array(any, tmp + 1, result);
    }
    else return result;
}
//Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Which first number?");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Which second number?");
int second = int.Parse(Console.ReadLine());
int result = 0;
if(first > second) Console.WriteLine("Error input data");
else Console.Write($"Result = {Array(second, first, result)}");