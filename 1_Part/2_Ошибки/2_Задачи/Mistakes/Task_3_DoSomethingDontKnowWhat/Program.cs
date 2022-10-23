namespace Task_3_DoSomethingDontKnowWhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Decode("12...33.44");
        }

        static int Decode(string str) =>
            (int.Parse(str.Replace(".", "")) % 1024);
    }
}
