namespace MethodHomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FirstTask(10,20));
            Console.WriteLine(SecondTask(2, 3, 4, 5, 6, 7));
            //Console.WriteLine(ThirdTask(5,20));
            //Console.WriteLine(FourthTask(15));
            //Console.WriteLine(FifthTask(16));


        }

        static int FirstTask(int a,int b)
        {
            return a / 2;
        }

        static int SecondTask(params int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result+= arr[i];
            }
            return result;
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

        static string FourthTask(int n)
        {
            bool sade = true;
            if (n == 2)
            {
                return "ne sade ne murekkeb";
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sade = false;
                        break;
                    }
                }
            }
            return sade ? "sadedir" : "murekkebdir";

        }

        static bool FifthTask(int n)
        {
            int quvvet = 1;
            while (n>quvvet)
            {
                quvvet *= 2;
            }
            return n == quvvet;
        }
    }
}