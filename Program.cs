namespace sem5_hw;
using vgnamespace;
class Program
{
    static void Main(string[] args)
    {
        //Задача 34: Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
        //числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        //[345, 897, 568, 234] -> 2
        vg.CC();
        void Task34()
        {
            int[] Arr = new int[20];
            vg.GenRndArrVal(Arr, 100, 1000);
            int Count = 0;
            for (int i = 0; i < Arr.Length; i++)
                if (Arr[i] % 2 == 0)
                    Count++;
            vg.PrintArr(Arr, "\nСгенерирован массив: ");
            Console.WriteLine($"Количество четных: {Count} ");
        }
        Task34();

        //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
        //элементов с нечётными индексами.
        //[3, 7, 23, 12] -> 19
        //[-4, -6, 89, 6] -> 0
        void Task36()
        {
            int[] Arr = new int[20];
            vg.GenRndArrVal(Arr, -9, 10);
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
                if (i % 2 != 0)
                    Sum += Arr[i];
            vg.PrintArr(Arr, "\nСгенерирован массив: ");
            Console.WriteLine($"Сумма чисел элементов массива с нечетными индексами: {Sum} ");
        }
        Task36();

        //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
        //и минимальным элементами массива.
        //[3,21 7,04 22,93 -2,71 78,24] -> 80,95
        void Task38()
        {
            double[] Arr = new double[20];
            vg.GenRndArrVal(Arr, 10, 100);
            double Min = Arr[0], Max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < Min)
                    Min = Arr[i];
                if (Arr[i] > Max)
                    Max = Arr[i];
            }

            vg.PrintArr(Arr, "\nСгенерирован массив: ");
            Console.WriteLine($"Разница между макс.({Math.Round(Max, 2)}) и мин.({Math.Round(Min, 2)}) значениями: {Math.Round(Max-Min, 2)} ");
        }
        Task38();

    }
}
