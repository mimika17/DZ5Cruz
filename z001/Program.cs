//задача1
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int len=Convert.ToInt32(Console.ReadLine());

int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100,1000);
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

int EvenNum(int[] arr)
{
 int count = 0;
 for (int i = 0; i<arr.Length; i++ ){
 if (arr[i] % 2 == 0)
    {
 count++;
    }
  }
 return count;
}


int[] num = FillArray(len);
PrintArray(num);
Console.WriteLine();
int even = EvenNum(num);
Console.WriteLine($"Количество чётных чисел в массиве: {even}");
