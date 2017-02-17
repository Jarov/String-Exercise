namespace _05.MagicExchangableWorlds
{
    using System;
    using System.Collections.Generic;

    class MagicExchangableWorlds
    {
        static void Main()
        {
            string[] inPut = Console.ReadLine().Split(' ');

            bool exchangable = true;

            HashSet<char> firstWord = new HashSet<char>();
            HashSet<char> secondWord = new HashSet<char>();

            foreach (char letter in inPut[0])
                firstWord.Add(letter);
            foreach (char letter in inPut[1])
                secondWord.Add(letter);

            if (firstWord.Count != secondWord.Count)
                exchangable = false;
            else
            {
                int smaller = Math.Min(inPut[0].Length, inPut[1].Length);

                for (int i = 0; i < smaller - 1; i++)
                {
                    CharPair pair = new CharPair(inPut[0][i], inPut[1][i]);
                    bool breakCicle = false;
                    
                    for (int o = i + 1; o < smaller; o++)
                    {
                        CharPair secondPair = new CharPair(inPut[0][o], inPut[1][o]);

                        if (pair.Key == secondPair.Key)
                        {
                            if (pair.Value != secondPair.Value)
                            {
                                exchangable = false;
                                breakCicle = true;
                                break;
                            }
                        }
                        else
                        {
                            if (pair.Value == secondPair.Value)
                            {
                                exchangable = false;
                                breakCicle = true;
                                break;
                            }
                        }

                        if (breakCicle) break;
                    }
                }
            }

            Console.WriteLine(exchangable.ToString().ToLower());
        }
    }
}
