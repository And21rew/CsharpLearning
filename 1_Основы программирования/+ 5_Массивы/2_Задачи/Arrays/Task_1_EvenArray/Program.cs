namespace Task_1_EvenArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetFirstEvenNumbers(3); // -> [2, 4, 6]
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            var array = new int[count];
            for (int i = 0; i < array.Length; i++)
                array[i] = (i + 1) * 2;
            return array;
        }
    }
}
