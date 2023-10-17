using System;
using SwinAdventure;

namespace SwinAdventure
{
    public abstract class GameObject : Identifiable_Object
    {
        private string _description, _name;

        protected GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _description = desc;
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string ShortDescription
        {
            get
            {
                return $"{Name} {FirstID}";
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }
    }
}