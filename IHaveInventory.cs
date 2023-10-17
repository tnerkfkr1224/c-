﻿using System;
using SwinAdventure;

namespace SwinAdventure
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name { get;}
    }
}


