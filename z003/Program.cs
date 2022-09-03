//Задача 3
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int len=Convert.ToInt32(Console.ReadLine());
double[] num = FillArray(len);
double [] FillArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}

double[] PrintArray(double []number)
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

double max = num[0];
double min = num[0];

 for (int i = 1; i < num.Length; i++)
  {
 if (max < num[i])
    {
 max = num[i];
    }
 if (min > num[i])
    {
 min = num[i];
    }
  }

PrintArray(num);
 double diff = max - min;

 Console.WriteLine($"Разница между между максимальным {max} и минимальным {min} элементами массива: {diff}");
