//Показать натуральные числа от N до 1, N задано
Console.WriteLine("Which number?");
int number = int.Parse(Console.ReadLine());
void Array (int any)
{
    if(any > 0) 
    {
        Console.Write($"{any} ");
        Array(any - 1);
    }
}
Array(number);