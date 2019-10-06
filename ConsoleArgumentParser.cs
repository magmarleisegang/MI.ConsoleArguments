using System;
using System.Collections.Generic;

namespace MI.ConsoleArguments
{
    public class ConsoleArgumentParser
    {
        public static T ParseArgs<T>(string[] args, Dictionary<string, Action<string, T>> argsList)
            where T : new()
        {
           T details = new T();
            for (int i = 0; i < args.Length; i++)
            {
                if (argsList.ContainsKey(args[i]))
                {
                    argsList[args[i]].Invoke(args[++i], details);
                }
            }
            return details;
        }        
    }
}
