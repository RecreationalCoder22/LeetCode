
namespace powerOf2
{
    class Program
    {
        /// ACCEPTED AND GOOD TIME COMPLEXITY, BEST SPACE COMPLEXITY
        public static bool IsPowerOfTwo(int n)
        {
            if (n == 1)
                return true;
            else if (n == 0)
                return false;
            else if (n == 2)
                return true;
            else if (n % 2 == 0)
                return IsPowerOfTwo(n / 2);
            else
                return false;
        }
        static void Main(string[] args)
        {
            IsPowerOfTwo(218);
        }
    }
}
