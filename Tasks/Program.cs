namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            BananaRipenessRange<int> bananaRange = new BananaRipenessRange<int>(5, 8);
            Console.WriteLine(bananaRange.IsPerfectBanana(7));  // Output: True 
            Console.WriteLine(bananaRange.IsPerfectBanana(3));  // Output: False

            #endregion
        }
    }
}
