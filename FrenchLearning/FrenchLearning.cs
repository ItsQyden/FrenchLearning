using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FrenchLearning
{
    class FrenchLearning
    {
        static Random rnd = new Random();

        static List<Word> words = new List<Word>();

        public static void Main(String[] args)
        {
            GetText();
            RunRecallTest();
        }

        private static void GetText()
        {
            String line;

            System.IO.StreamReader file = new System.IO.StreamReader("FrenchTranslation.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] split = line.Split('\t');
                words.Add(new Word(split[0], split[1]));
            }

            file.Close();
        }

        private static void RunRecallTest()
        {

            int remaining = words.Count;

            while (remaining > 0)
            {
                Console.WriteLine(words.Count + " to go!");

                Word word = GetNewWord();

                Console.WriteLine(word.getFrancais() + ": ");
                String answer = Console.ReadLine();
                if (answer.ToLower().Equals(word.getEnglish()))
                {
                    words.Remove(word);
                    Console.WriteLine("Correct!");
                }

                else
                {
                    Console.WriteLine("Answer is " + word.getEnglish());
                }

                Console.WriteLine();
            }
        }

        private static Word GetNewWord()
        {
            int rand = rnd.Next(words.Count) + 1;
            Word word = words[rand];
            return word;
        }
    }
}
