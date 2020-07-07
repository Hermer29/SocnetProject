using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Socnet
{

    public abstract class Command 
    {
        private string commandText;
        private string CommandText 
        {
            get
            {
                return commandText;
            }
            set
            {
                commandText = !value.Contains(' ')?value:commandText;
            }
            
        }
        private int[] OverloadArgsCount;
        public virtual void CommandAction()
        {
            throw new NotImplementedException();
        }
    }
    
    public class SQLCommand : Command
    {
        private static List<SQLCommand> SQLCommandList;
    }
    
    public class ClientCommand : Command
    {
        private static List<ClientCommand> ClientCommandList;
        static ClientCommand()
        {
            ClientCommandList = new List<ClientCommand>();
        }
        public ClientCommand()
        {
            
        }
    }
    
    public class ServerCommand : Command
    {
        private static List<ServerCommand> ServerCommandList;
        static ServerCommand()
        {
            ServerCommandList = new List<ServerCommand>();
        }
        public ServerCommand()
        {
            
        }
    }
    
}