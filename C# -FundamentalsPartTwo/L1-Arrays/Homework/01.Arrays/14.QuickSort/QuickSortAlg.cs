/*
 * Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
 * this is the most useful explanation of QuickSort I found: 
 * https://d19vezwu8eufl6.cloudfront.net/algs4partI/recoded_videos%2Falgs4partI-35.mp4
 * 
 */
using System;
class QuickSortAlg
{
    static void Main(string[] args)
    {

        string[] strArray = //{ "This", "is", "Telerik", "academy", "C#", "2", "QuickSort", "exccercise" };
                            // { "g", "f", "e", "d", "c", "b", "a" };
                            // { "a", "b", "c", "d", "e", "f", "g" };
                            { "g", "gg", "a", "bb","c","ab","BB"};
       


        Console.WriteLine("Before sorting: ");
        Console.WriteLine(string.Join(" ", strArray));

        QuickSort(strArray, 0, strArray.Length - 1);


        Console.WriteLine("After sorting: ");
        Console.WriteLine(string.Join(" ", strArray));

    }

    private static int PartitioningElements(string[] testStrArray, int lo, int hi)
    {
        int iKey = lo + 1;
        int jKey = hi;

        while (true)
        {
            // String.Compare(StrA,StrB, true) <0 when strA is less than strB
            while (String.Compare(testStrArray[iKey], testStrArray[lo], true) < 0)
            {
                if (iKey == hi)
                {
                    break;
                }
                iKey++;
            }
            // String.Compare(StrA,StrB, true) >0 when strA is greater than strB
            while (String.Compare(testStrArray[jKey], testStrArray[lo], true) > 0)
            {
                if (jKey == lo)
                {
                    break;
                }
                jKey--;
            }
            if (iKey >= jKey) { break; } //check if pointers cross

            //swap elements
            var temp = testStrArray[iKey];
            testStrArray[iKey] = testStrArray[jKey];
            testStrArray[jKey] = temp;
        }
        //swap with jKey 
        var j = testStrArray[jKey];
        testStrArray[jKey] = testStrArray[lo];
        testStrArray[lo] = j;
        return jKey;
    }
    private static void QuickSort(string[] testStrArray, int lo, int hi)
    {
        if (hi <= lo)
        {
            return;
        }
        int j = PartitioningElements(testStrArray, lo, hi);
        QuickSort(testStrArray, lo, j - 1);
        QuickSort(testStrArray, j + 1, hi);
    }
}

/*
 * 
 * This is verry clean and stright  implementation but it is not working for some edge cases
 * try it out with: { "a", "b", "c", "d","r","r","a","b","c","d","r","r"}; 
                    { "g", "G", "a", "A", "a", "b", "B" };
 * This video https://d19vezwu8eufl6.cloudfront.net/algs4partI/recoded_videos%2Falgs4partI-38.mp4
 * explains the problem but I am running out of time will try to post it in the forum as corected version
 * 
 */
                             
