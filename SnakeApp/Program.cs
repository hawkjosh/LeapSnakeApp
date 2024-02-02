using SnakeApp.Controllers;
using SnakeApp.Models;

namespace SnakeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gm = new GameController();
            gm.Start();


        }
    }
}
