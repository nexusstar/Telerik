/*
* 12. Write a program that parses an URL address given in the format:
* [protocol]://[server]/[resource]
* and extracts from it the [protocol], [server] and [resource] elements.
* 
* For example from the URL http://www.devbg.org/forum/index.php the following information
* should be extracted:
* 
* [protocol] = "http"
* [server] = "www.devbg.org"
* [resource] = "/forum/index.php"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractFromURL
{
    static void Main()
    {
        string urlAddress = @"https://www.devbg.org/forum/index.php";

        var protocolSeparator = "://";
        var serverSeparator = "/";
        
        var protocol = urlAddress.Substring(0, urlAddress.IndexOf(protocolSeparator));
        
        var server = urlAddress.Substring(protocol.Length + protocolSeparator.Length,
        urlAddress.IndexOf(serverSeparator, urlAddress.IndexOf(protocolSeparator) + 3) - (urlAddress.IndexOf(protocolSeparator) + protocolSeparator.Length));
        
        var resource = urlAddress.Substring(protocol.Length + protocolSeparator.Length + server.Length);

        Console.WriteLine("URL Address: {0}", urlAddress);
        Console.WriteLine("\n[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}\n", resource);
    }
}