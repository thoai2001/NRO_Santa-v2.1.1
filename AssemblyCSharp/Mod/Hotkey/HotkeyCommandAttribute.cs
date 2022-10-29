﻿using System;

namespace Mod
{
    public class HotkeyCommandAttribute : BaseCommandAttribute
    {
        public char key;
        public string agrs = "";

        public HotkeyCommandAttribute(char key)
        {
            this.key = key;
        }
    }
}