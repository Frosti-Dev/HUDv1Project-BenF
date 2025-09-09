using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace HUDv1Project_BenF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string gameName = "Second Controller";
            string characterName = "Alexa";
            string studioName = "Frosti Studio";
            int health = 100;
            int shield = 0;
            int score = 0;
            int lives = 0;
            float ver = 1.1f;

            //hud
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");
            
            //start
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Second Controller!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //game start
            shield = shield + 50;
            lives = lives + 1;
            score = score + 100;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You make your way into the forest and find a bag. The bag includes 50 shield and 1 life!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //event 2
            Console.Clear();
            health = health / 2;
            score = score / 2;
            shield = shield - 50;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You were ambushed! You lose your shield and 50 health!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //event 3
            Console.Clear();
            score = score + 2000;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You climb the crazy mountain and find a treasure chest. YOUR SCORE RAISES!!!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //event 4
            Console.Clear();
            health = 0;
            score = score / 4;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You fall off the mountain...wow! You die.");
            Console.WriteLine("Press any key to use a life...");
            lives = lives - 1;
            Console.ReadKey();

            //event 5
            Console.Clear();
            health = 20;
            score = score + 500;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You respawn. You are still falling...but this time a tree catches you! You still lose 80 hp to falling. You jump down from the tree and land on your feet! ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //finale
            Console.Clear();
            health = health - 500000;
            score = score / 4;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You trip on a tree stump and the pain is too unbearable...you die. (Def a skill issue)");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU DIED. GAME OVER");
            Console.ReadKey();
            Console.Clear();
        }
       
    }
}
