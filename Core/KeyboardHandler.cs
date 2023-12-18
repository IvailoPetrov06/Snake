using Snake.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Core
{
    public class KeyboardHandler : IKeyboardHandler
    {
        public ConsoleKey PressedKey
        {
            get
            {
                return Console.ReadKey().Key;
            }
        }
        public bool IsKeyAvailable
        {
            get
            {
                return Console.KeyAvailable;
            }
        }
    }
}
