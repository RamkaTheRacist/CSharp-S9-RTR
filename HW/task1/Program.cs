//Показать натуральные числа от M до N, N и M заданы
void Array (int any, int tmp)
{

    if(tmp <= any)
    {
        
        Console.Write($"{tmp} ");
        Array(any, tmp + 1);
    }
}
Console.WriteLine("Which first number?");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Which second number?");
int second = int.Parse(Console.ReadLine());
if(first > second) Console.WriteLine("Error input data");
else Array(second, first);