using System;
using System.Diagnostics;
using System.Reflection;

namespace SemanticConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var assem = Assembly.GetExecutingAssembly();
            string assemblyVersion = assem.GetName().Version.ToString();
            string fileVersion = FileVersionInfo.GetVersionInfo(assem.Location).FileVersion;

            Console.WriteLine("Semantic version example app!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Assembly version:\t{0}", assemblyVersion);
            Console.WriteLine("File version:\t\t{0}", fileVersion);
        }
    }
}
