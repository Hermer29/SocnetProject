using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Socnet
{

    public abstract class CommandHandler 
    {
        public CommandHandler()
        {
            
        }
    }
    
    public class ClientHandler : CommandHandler
    {
        
    }
    
    public class ServerHandler : CommandHandler
    {
       
    }
}