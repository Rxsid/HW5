// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,1000);
    }
    return arr;
}

System.Console.WriteLine("Vvedite razmer massiva: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);

int KolvoChet (int[] array)
{
    int kolvo = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            kolvo ++;
        }   
    }
    return kolvo;
}

int Kolvo = KolvoChet (array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"Kolichestvo chetnyh = {Kolvo}");