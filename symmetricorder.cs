using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> wordsList = new List<List<string>>();
            string consoleInput;
            while ((consoleInput = Console.ReadLine()) != "0") {
                List<string> inputWords = new List<string>();
                for (int i = 0; i < int.Parse(consoleInput); i++)
                {
                    string word = Console.ReadLine();
                    inputWords.Add(word);
                }
                wordsList.Add(inputWords.OrderBy(x => x.Length).ToList());
            }

            for (int i = 0; i < wordsList.Count(); i++)
            {
                string[] words = new string[wordsList[i].Count()];
                int a = 0;
                while(wordsList[i].Count > 0) {
                    words[a] = wordsList[i][0];
                    wordsList[i].RemoveAt(0);
                    if (wordsList[i].Count > 0) {
                        words[words.Length - (1 + a)] = wordsList[i][0];
                        wordsList[i].RemoveAt(0);
                    }
                    a++;
                }
                Console.WriteLine("SET " + (i + 1));
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}