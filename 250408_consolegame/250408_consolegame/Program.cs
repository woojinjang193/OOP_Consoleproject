using System.Text;

namespace _250408_consolegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //특수문자 출력
            Game.Run();
        }
    }
}
