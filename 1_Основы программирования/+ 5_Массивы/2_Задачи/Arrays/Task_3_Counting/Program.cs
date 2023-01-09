namespace Task_3_Counting
{
    internal class Program
    {
        public static int GetElementCount(int[] items, int itemToCount)
        {
            var countItem = 0;

            foreach (var item in items)
                if (item == itemToCount)
                    countItem++;

            return countItem;
        }
    }
}
