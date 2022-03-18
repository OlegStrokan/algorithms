namespace data_structures
{
    public static class Factorial
    {
        public static int FactorialFunk(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= 1;
            }

            return result;
        }

        public static int IFaktorial(int n)
        {
            if (n == 1) return 1;

            return n * IFaktorial(n - 1);
        }

        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        

    }
}