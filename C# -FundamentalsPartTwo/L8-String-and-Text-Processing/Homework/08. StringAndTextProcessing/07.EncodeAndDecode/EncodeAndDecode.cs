/*
* 7. Write a program that encodes and decodes a string using given encryption
* key (cipher). The key consists of a sequence of characters. The encoding/decoding
* is done by performing XOR (exclusive or) operation over the first letter of 
* the string with the first of the key, the second – with the second, etc. 
* When the last key character is reached, the next is the first.
*/

using System;
using System.Linq;
using System.Text;

class EncodAndDecode
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine(); // Example: Processing

        Console.Write("Enter a KEY (characters on one line - without spaces): ");
        string cypher = Console.ReadLine(); // Example: ab

        Console.WriteLine("\nEncryption: {0}", Encode(input, cypher));

        Console.WriteLine("\nEncryption + decryption: {0}\n", Decode(Encode(input, cypher), cypher));
    }

    static string Encode(string input, string cypher)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
            result.Append((char)(input[i] ^ cypher[i % cypher.Length]));

        return result.ToString();
    }

    static string Decode(string word, string key)
    {
        return Encode(word, key);
    }
}