namespace Task_2_MaximumIndex
{
    internal class Program
    {
        public static int MaxIndex(double[] array)
        {
            if (array.Length == 0)
                return -1;

            var maxIndex = 0;
            var maxNumber = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
