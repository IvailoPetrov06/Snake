using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Interfaces
{
    public interface IKeyboardHandler
    {
        ConsoleKey PressedKey
        {
            get;
        }

        bool IsKeyAvailable
        {
            get;
        }
    }
}
