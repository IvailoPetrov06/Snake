using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Interfaces
{
    public interface IMovable
    {
        void Move();
        Direction Direction { get; }

        void ChangeDirection(Direction newDirection);
    }
}
