using SnakeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp.Interfaces
{
    public interface ICurrentPosition
    {
        //Get current position of the object
        Coordinate GetCurrentPosition();
    }
}
