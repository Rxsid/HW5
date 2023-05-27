// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArrayWithRandomNumber(int size)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() + rnd.Next(1,10), 3);
    }
    return arr;
}

System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);

double Selection (double[] array)
{
    double Max = array[0];
    double Min = array[0];
    double razn = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if(array[i] > Max) Max = array[i];
     if(array[i] < Min) Min = array[i];
    }
    razn = Max - Min;
    return razn;
}
double Razn = Selection(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"Разность между максимальным и минимальным элементами массива = {Razn}");