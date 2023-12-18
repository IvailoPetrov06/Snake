using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Interfaces
{
    public interface IDrawer
    {
        void DrawPoint(int x, int y, char symbol);
    }
}
