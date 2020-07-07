using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Socnet
{

    public static class Info 
    {
      internal static string DBName = "Main.db";
      internal static string OpenMethod = "Data Source";
      internal static Dictionary<string,string> ReservedAccount =
         new Dictionary<string,string>();
 
      public static void AddResAcc(string login, string password)
        {
         ReservedAccount.Add(login,password);
        }
      static Info()
        {
         AddResAcc("admin","admin");
        }
    }
    
    private static class CommandList
    {
        internal static List<Command> ServerCommand,ClientCommands;
    }
}