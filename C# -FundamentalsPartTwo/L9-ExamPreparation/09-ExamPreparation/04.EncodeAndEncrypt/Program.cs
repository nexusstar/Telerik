/*
 * TELERIKACADEMY   ---> BKOXHI\EQOGX[YSOFTWARE8
 * SOFTWARE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EncodeAndEncrypt
{
    class EncodeAndEncrypt
    {
        static void Main(string[] args)
        {

            // string message = Console.ReadLine();
            // string cypher = Console.ReadLine();
            // int lengthOfCypher = cypher.Length;

            // string result = Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher;

            //Console.WriteLine(result);

            //decrypt and decypher
            string input = Console.ReadLine();
            int lengthOfCypher = GetLengthOfCypher(input);
            string encodedMessage = input.Substring(0, input.Length - lengthOfCypher.ToString().Length);
            string decodedMessage = Decode(encodedMessage);
            string encryptedMessage = decodedMessage.Substring(0, decodedMessage.Length - lengthOfCypher);
            string cypher = decodedMessage.Substring(decodedMessage.Length - lengthOfCypher);
            string message = Encrypt(cypher, encryptedMessage);
            Console.WriteLine(message);

        }

        private static int GetLengthOfCypher(string input)
        {
            var digits = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    break;
                }
            }
            digits.Reverse();
            int lengthOfCypher = 0;
            foreach (var digit in digits)
            {
                lengthOfCypher *= 10;
                lengthOfCypher += digit;
            }
            return lengthOfCypher;
        }

        private static string Decode(string encryptedAndEncoded)
        {
            var result = new StringBuilder();
            int count = 0;
            foreach (char ch in encryptedAndEncoded)
            {
                if (char.IsDigit(ch))
                {
                    count *= 10;
                    count += int.Parse(ch.ToString());
                }
                else
                {
                    if (count == 0)
                    {
                        result.Append(ch);
                    }
                    else
                    {
                        result.Append(new string(ch, count));
                    }

                    count = 0;
                }
            }
            return result.ToString();

        }

        private static int GetCypherLength(string encryptedAndEncoded)
        {
            StringBuilder result = new StringBuilder();
            int index = 1;
            while (true)
            {
                char currentChar = encryptedAndEncoded[encryptedAndEncoded.Length - index];
                if (char.IsDigit(currentChar))
                {
                    result.Append(currentChar);
                    index++;
                }
                else
                {
                    break;
                }
            }
            return int.Parse(result.ToString());
        }

        private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
        {
            int messageSymbolCode = messageSymbol - 'A';
            int cypherSymbolCode = cypherSymbol - 'A';
            int xorValue = messageSymbolCode ^ cypherSymbolCode;

            char encrypted = (char)(xorValue + 'A');
            return encrypted;
        }

        private static string Encode(string text)
        {
            StringBuilder result = new StringBuilder();

            char previousSymbol = text[0];
            int counter = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == previousSymbol)
                {
                    counter++;
                }
                else
                {
                    if (counter == 1)
                    {
                        result.Append(previousSymbol);

                    }
                    else if (counter == 2)
                    {
                        result.Append(new string(previousSymbol, 2));

                    }
                    else
                    {
                        result.Append(counter + previousSymbol.ToString());

                    }
                    counter = 1;
                }

                previousSymbol = text[i];
            }
            if (counter == 2)
            {
                result.Append(new string(previousSymbol, 2));
            }
            else if (counter > 2)
            {
                result.Append(counter + previousSymbol.ToString());
            }
            else
            {
                result.Append(previousSymbol);
            }
            return result.ToString();
        }

        static string Encrypt(string message, string cypher)
        {
            string result = string.Empty;
            if (message.Length >= cypher.Length)
            {
                result = EncryptWhenMessageIsLonger(message, cypher);
            }
            else if (message.Length < cypher.Length)
            {
                result = EncryptWhenCypherIsLonger(message, cypher);
            }

            return result;
        }

        private static string EncryptWhenCypherIsLonger(string message, string cypher)
        {
            StringBuilder result = new StringBuilder(message);
            int messageIndex = 0;
            for (int i = 0; i < cypher.Length; i++)
            {
                char messageSymbol = result[messageIndex];
                char cypherSymbol = cypher[i];
                char encrypted = EncryptSymbol(messageSymbol, cypherSymbol);

                result[messageIndex] = encrypted;

                messageIndex++;

                if (messageIndex == message.Length)
                {
                    messageIndex = 0;
                }
            }

            return result.ToString();
        }

        private static string EncryptWhenMessageIsLonger(string message, string cypher)
        {
            StringBuilder result = new StringBuilder();
            int cypherIndex = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char encrypted = EncryptSymbol(message[i], cypher[cypherIndex]);
                cypherIndex++;
                if (cypherIndex == cypher.Length)
                {
                    cypherIndex = 0;
                }
                result.Append(encrypted);
            }

            return result.ToString();
        }
    }
}
