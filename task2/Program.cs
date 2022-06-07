void Array (int any, int tmp)
{

    if(tmp <= any)
    {
        
        Console.Write($"{tmp} ");
        Array(any, tmp + 1);
    }
}
//Показать натуральные числа от 1 до N, N задано
Console.WriteLine("Which number?");
int number = int.Parse(Console.ReadLine());
int tmp = 1;
Array(number, tmp);