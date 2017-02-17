namespace _04.CharracterMultiplier
{
    using System;

    class CharracterMultiplier
    {
        static void Main()
        {
            string[] inPut = Console.ReadLine().Split(' ');
            

            if (inPut[0].Length > inPut[1].Length)
            {
                int sum = 0;
                
                for (int i = 0; i < inPut[0].Length; i++)
                {
                    if (i <= inPut[1].Length - 1)
                        sum += inPut[1][i] * inPut[0][i];
                    else
                        sum += inPut[0][i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                int sum = 0;
                
                for (int i = 0; i < inPut[1].Length; i++)
                {
                    if (i <= inPut[0].Length - 1)
                        sum += inPut[0][i] * inPut[1][i];
                    else
                        sum += inPut[1][i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
