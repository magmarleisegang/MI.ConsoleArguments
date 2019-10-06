using System;
namespace MI.ConsoleArguments
{
    public static class ConsoleArgumentPrompter
    {
        public static string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
