using System;
using SwinAdventure;

namespace SwinAdventure
{
    public class LookCommand : Command
    {

        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look like that";
            }

            if (text[0] != "look")
            {
                return "Error in look input";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }
            }

            if (text.Length == 3)
            {
                IHaveInventory container = p as IHaveInventory;
                string ItemId = text[2];
                return LookAtIn(ItemId, container);
            }


            if (text.Length == 5)
            {
                string ItemId = text[2];
                string containerID = text[4];
                IHaveInventory container = FetchContainer(p, containerID);
                if (container is null)
                {
                    return $"i cannot find the {containerID}";
                }
                return LookAtIn(ItemId, container);
            }
            return "good";
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }


        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }

            return $"i cannot find the {thingId}";
        }
    }
}








