namespace _03.UnicodeCharacters
{
    using System;

    class UnicodeCharacters
    {
        static void Main()
        {
            string Sentence = Console.ReadLine();
            string escape = "";

            foreach (char letter in Sentence)
            {
                byte value = Convert.ToByte(letter);

                escape += "\\u" + string.Format("{0:X}", value).PadLeft(4, '0').ToLower();
            }
            

            Console.WriteLine(escape);
        }
    }
}
