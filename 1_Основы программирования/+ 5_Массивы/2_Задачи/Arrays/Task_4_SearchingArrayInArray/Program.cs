namespace Task_4_SearchingArrayInArray
{
    internal class Program
    {
        private static bool ContainsAtIndex(int[] array, int[] subArray, int index)
        {
            for (int i = 0; i < subArray.Length; i++)
            {
                if (array[i + index] == subArray[i])
                    continue;
                return false;
            }
            return true;
        }
    }
}
