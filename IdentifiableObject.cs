using System;
using System.Collections.Generic;

namespace SwinAdventure
{
    public class Identifiable_Object
    {
        private List<string> _identifiers;

        public Identifiable_Object(string[] idents)
        {
            _identifiers = new List<string>();

            foreach (string _id in idents)
            {
                AddIdentifier(_id);
            }
        }


        public bool AreYou(string id)
        {
            id = id.ToLower();

            for (int i = 0; i < _identifiers.Count; i++)
            {
                if (id == _identifiers[i])
                    return true;
            }

            return false;
        }

        public string FirstID
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers.First();
                }
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());

        }

     
    }
}