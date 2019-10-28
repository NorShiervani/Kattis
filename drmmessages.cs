using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class drmmessages
    {
        static void Main(string[] args)
        {
            string[] dividedMessages = new string[2];
            string message = Console.ReadLine();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string decrypedMesssage = "";

            //1. Divide
            dividedMessages[0] = message.Substring(0, message.Length / 2);
            dividedMessages[1] = message.Substring(message.Length / 2);


            for (int i = 0; i <= dividedMessages.Length - 1; i++)
            {
                int rotationValue = 0;
                string rotatedString = "";

                foreach (char letter in dividedMessages[i])
                {
                    rotationValue += alphabet.IndexOf(letter);
                }

                //2. Rotate
                for (int c = 0; c < dividedMessages[i].Length; c++)
                {
                    rotatedString += alphabet[((rotationValue % alphabet.Length) + alphabet.IndexOf(dividedMessages[i][c])) % alphabet.Length];
                }

                dividedMessages[i] = rotatedString.ToUpper();
            }

            //3. Merge
            for (int c = 0; c < dividedMessages[0].Length; c++)
            {
                decrypedMesssage += alphabet[((alphabet.IndexOf(dividedMessages[0][c]) + alphabet.IndexOf(dividedMessages[1][c])) % alphabet.Length)];
            }

            Console.WriteLine(decrypedMesssage);
            Console.ReadLine();
        }
    }
}
