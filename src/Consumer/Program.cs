using System;

namespace Jenx.CsSourceCodeGeneratorConsumer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CompileTimeGenerated.JenxWelcome.SayHello();
            Console.ReadLine();

            // executing my second C# Source Generator...
            CompileTimeGenerated.PersonsWelcome.SayHelloFromAll();
            Console.ReadLine();
        }
    }
}