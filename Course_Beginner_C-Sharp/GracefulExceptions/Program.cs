using System;
using System.IO;

namespace GracefulExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\RandomDirectory\file.txt");
                Console.WriteLine(content);
            }
            //should check most specific exceptions first, most general last...
            catch (FileNotFoundException ex)
            { Console.WriteLine("I'm sorry, the required file does not appear to exist."); }
            catch (DirectoryNotFoundException ex)
            { Console.WriteLine("I'm sorry, the required directory does not appear to exist."); }
            catch (Exception ex)
            { Console.WriteLine("I'm sorry, there appears to have been an error."); }
            finally
            { Console.WriteLine("Application will need to be close now."); }
        }
    }
}
