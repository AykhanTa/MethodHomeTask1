namespace MethodHomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FirstTask(10,20));
            Console.WriteLine(ThirdTask(5,20));

        }

        static int FirstTask(int a,int b)
        {
            return a / 2;
        }

        static int ThirdTask(int n, int m)
        {
            int count = 0;
            if (n < m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}