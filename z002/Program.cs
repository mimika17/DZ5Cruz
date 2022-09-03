//задача 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int len=Convert.ToInt32(Console.ReadLine());

int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}

int[] PrintArray(int []number)
{
int a=number.Length;
for(int i=0; i<a; i++)
{
    if (i!=a-1 && i!=0) Console.Write($"{number[i]}, ");
    else if ( i==0)  Console.Write($" [ {number[i]}, ");
    else Console.WriteLine($"{number[i]} ]");
}
return number;
}

int NotEvenPos(int[] arr)
{
 int sum = 0;
 for (int i = 1; i<arr.Length; i=i+2 )
 {
     sum+=arr[i];
  }
 return sum;
}

int[] num = FillArray(len);
 PrintArray(num);
 Console.WriteLine();
int sumnot = NotEvenPos(num);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumnot}");
