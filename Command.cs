using System;
using SwinAdventure;

namespace SwinAdventure
{
    public abstract class Command : Identifiable_Object
    {      

        public Command(string[] ids) : base(ids)
        {
            
        }

        public abstract string Execute(Player p, string[] text);
        
    }
}


