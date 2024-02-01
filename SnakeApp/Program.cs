using SnakeApp.Controllers;

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
