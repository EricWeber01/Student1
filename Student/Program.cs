using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string rPath = @"D:\C#\REGULAR\REGULAR\bin\Debug\Read.cs";
           string wPath = "Write.cs";
           List<string> text = new List<string>();
           using (StreamReader file = new StreamReader(rPath,Encoding.UTF8))
           {

               while (file.EndOfStream == false)
                   text.Add(file.ReadLine());
           }

           for (int i = 0; i < text.Count; i++)
           {
               text[i] = Regex.Replace(text[i], @"(?i)(?<!-)\bpublic\b", @"private");
               text[i] = Regex.Replace(text[i], "[ ]+", " ");
           }

           using (StreamWriter writer = new StreamWriter(wPath, false))
           {
               foreach (var item in text)
                   writer.WriteLine(item);

           }*/
            Account account = new Account();
            account.SetUser();
        }
    }
}
