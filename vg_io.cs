namespace vgnamespace
{
    public static class vg
    {
        public static int Input(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void GenRndArrVal(int[] Arr, int MinValue = 0, int MaxValue = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
                Arr[i] = rnd.Next(MinValue, MaxValue);
        }
        public static void GenDoubleRndArrVal(double[] Arr, int MinValue = 0, int MaxValue = 1)
        {
            Random rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
                Arr[i] = MinValue+((MaxValue-MinValue)*rnd.NextDouble());
        }
        public static void GenRnd2DArrVal(int[,] Arr, int MinValue = 0, int MaxValue = 100)
        {
            Random rnd = new Random();
            for (int y = 0; y < Arr.GetLength(1); y++)
                for (int x = 0; x < Arr.GetLength(0); x++)
                    Arr[x, y] = rnd.Next(MinValue, MaxValue);
        }
        public static void PrintArr(int[] Arr, string Msg = "")
        {
            Console.WriteLine($"{Msg}{string.Join(" ", Arr)}");
        }
        public static void PrintArr(double[] Arr, string Msg = "")
        {
            Console.WriteLine($"{Msg}{string.Join(" ", Arr)}");
        }
        public static void CC()
        {
            Console.Clear();
        }

    }
}