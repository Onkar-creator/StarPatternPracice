namespace StarPatternPracice
{
    internal class StarPatterns
    {
        private int GetLimit()
        {
            int limit;
            Console.WriteLine("Please Enter your Limit");
            limit = Convert.ToInt32(Console.ReadLine());
            return limit;
        }

        public void Pattern1()
        {
            int limit = GetLimit();
            for (int i = 1; i <= limit; i++)
            {


                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void Pattern2()
        {
            int limit = GetLimit();
            for (int i = limit; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void Pattern3()
        {
            int limit = GetLimit();
            for (int i = limit; i >= 1; i--)
            {
                for (int k = 1; k <= limit - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public void Pattern4()
        {
            int limit = GetLimit();
            for (int i = 1; i <= limit; i++)
            {
                for (int k = limit - 1; k >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }


        public void Pattern5()
        {
            int limit = GetLimit();
            for (int i = 3; i <= limit; i++)
            {
                for (int k = limit - 1; k >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                for (int l=limit-1; l>=i; l--)
                {
                    Console.Write("  ");
                }

                for (int m=1; m<=i; m++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i=1; i<=limit-1; i++)
            {
                for (int n=1; n<=i; n++)
                {
                    Console.Write("  ");
                }
                for (int a=limit; a>i; a--)
                {
                    Console.Write("* ");
                }
                for (int b=limit; b>i; b--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }












    }
}
