﻿using System;
using System.Text;

/// <summary>
/// Task: "10. Provide a short list with information about the most popular programming languages. How do they differ from C#"
/// </summary>
public class MostPopularProgrammingLanguages
{
    public static void Main()
    {
        string topicCSharp = "Език за програмиране от .NET платформата на Microsoft. Той е изцяло обектно-ориентиран език. Събира в себе си най-доброто от C, "
                            + "C++, Java, Python и други. Позволява лесно и бързо изграждане на сложни приложения.\r\n";
        string topicVisualBasic = "Език от .NET платформата на Microsoft. Той е изцяло ООП език. Разработен на базата на езика Microsoft BASIC "
                            + "използван през '80 години масово за обучаване на начинаещи програмисти и предимно в училищата. Microsoft се опитват с всяка следваща "
                            + "версия да го доближат до C# (например конструкцията <променлива>++, която е характерна за езиците от рода на \"С\",\"С++\" и \"С#\".\r\n";
        string topicJava = "Език разработен от фирмата SUN. Той е изцяло обектно-ориентиран език и един от първите езици (дали не и първият) създаден с идеята "
                            + "за платформено независим код). Изключително популярен днес, като намира все повече приложение и при мобилните платформи (Android).\r\n";
        string topicCPP = "Език за програмиране, явяващ се пряк наследник на процедурният език \"С\". За разлика от \"С\", цялата концепция, на която се базира "
                            + "\"С++\" е обектно-ориентираното програмиране. Използва се масово, но предимно за изучаване на програмирането (но не само), "
                            + "както например и в платформи не подържащи (не native) .NET Framework (използва се масово за програмиране под Linux среда).\r\n";
        string topicPHP = "Широко използван език за сървърни приложения и разработването на динамични web приложения. Базаран е на езика \"C\" и езика \"Perl\".\r\n";
        Console.SetWindowSize(80, 35);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ЕЗИЦИ ЗА ПРОГРАМИРАНЕ");
        Console.WriteLine("---------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("C# (C Sharp): ");
        PrintLines(topicCSharp);
        Console.WriteLine();
        Console.WriteLine("Visual Basic (.NET): ");
        PrintLines(topicVisualBasic);
        Console.WriteLine("Java: ");
        PrintLines(topicJava);
        Console.WriteLine("C++: ");
        PrintLines(topicCPP);
        Console.WriteLine("PHP: ");
        PrintLines(topicPHP);
        Console.ReadKey();
    }

    private static void PrintLines(string content)
    {
        Console.ForegroundColor = ConsoleColor.White;
        int maxCharsPerLine = 60;
        StringBuilder lineWithWords = new StringBuilder();
        string[] topic = content.Split(' ');
        for (int index = 0; index < topic.Length; index++)
        {
            lineWithWords.Append(topic[index]);
            lineWithWords.Append(" ");
            if ((lineWithWords.Length > maxCharsPerLine) || (index == topic.Length - 1))
            {
                Console.WriteLine(lineWithWords);
                lineWithWords.Clear();
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
    }
}