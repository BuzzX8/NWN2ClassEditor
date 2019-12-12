using System;

namespace Dnd35.Class
{
    [Flags]
    public enum SaveThrow 
    { 
        Fortidute = 0x01, 
        Reflex = 0x02, 
        Will = 0x08 
    }
}