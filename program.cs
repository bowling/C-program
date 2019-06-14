using System;
using System.IO;
using System.Collections;
using System.Drawing;

/*
Author: Michael Redbourne
<Removed>
Language: C#
Purpose: Grab all usernames belonging to company <removed>
*/

namespace DirectoryNames___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("Z:/");
            DirectoryInfo[] diArr = di.GetDirectories();
            try
            {
                StreamWriter sw = new StreamWriter("H:/AppendedNames.txt");
                StreamWriter sw2 = new StreamWriter("H:/UnAppendedNames.txt");
                foreach (DirectoryInfo dri in diArr)
                {
                    sw.WriteLine(dri.Name + "@<Removed>");
                    sw2.WriteLine(dri.Name);
                }
                sw.Close();
                sw2.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally {
                Console.WriteLine("Application Complete.");
            }
        }
    }
}
