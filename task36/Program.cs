// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}

System.Console.WriteLine("Vvedite razmer massiva: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);

int SumChetPos (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i +2)
    {
        sum = array[i] + sum;
    }
    return sum;
}
int Sum = SumChetPos (array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"Summa elementov s chetnym indexom = {Sum}");