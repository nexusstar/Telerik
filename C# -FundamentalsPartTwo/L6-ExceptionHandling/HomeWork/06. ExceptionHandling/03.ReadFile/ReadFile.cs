/*
 * 03.
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;
using System.Linq;
using System.Security;

class ReadFile
{
    static void Main()
    {

        string path = @"c:\Windows\win.ini";
        try
        {
            // Open the file to read from. 
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.WriteLine("\n - > Success!");
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("Path is null \n{0} - > {1}", ane.GetType(), ane.Message);
        }
        catch (ArgumentException ae)
        {

            Console.WriteLine("Empthy path \n{0} - > {1}", ae.GetType(), ae.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine("Path is too long \n{0} - > {1}", ptle.GetType(), ptle.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine("Not found direcftory \n{0} - > {1}", dnfe.GetType(), dnfe.Message);
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("No such file at this location \n{0} - > {1}", fnf.GetType(), fnf.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine("Problem reading file \n{0} - > {1}", ioe.GetType(), ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine("Not enough permission for reading file \n{0} - > {1}", uae.GetType(), uae.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine("Not enough permission \n{0} - > {1}", se.GetType(), se.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine("n{0} - > {1}", nse.GetType(), nse.Message);
        }

    }
}