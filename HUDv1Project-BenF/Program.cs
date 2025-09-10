using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace HUDv1Project_BenF
{
    internal class Program
    {
        //variables
        static string gameName = "Second Controller";
        static string characterName = "Alexa";
        static string studioName = "Frosti Studio";
        static int health = 100;
        static int shield = 0;
        static int score = 0;
        static int lives = 0;
        static float ver = 1.2f;

        static int TakeDamage(int amountofdam)
        {
            health -= amountofdam;
            return health;
        }

        static int addScore(int points)
        {
            score += points;
            return score;
        }
        static void ShowHUD()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,0}{1,55}{2,50}", studioName, gameName, $"Ver: {ver}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,30}{2,30}{3,30}", $"Lives: {lives}", $"Health: {health}", $"Shield: {shield}", $"Score: {score}");
        }
        static void Main(string[] args)
        {
            
            //hud
            ShowHUD();

            //start
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Second Controller!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //game start
            shield = shield + 50;
            lives = lives + 1;
            addScore(100);
            ShowHUD();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You make your way into the forest and find a bag. The bag includes 50 shield and 1 life!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //event 2
            Console.Clear();
            TakeDamage(50);
            addScore(-50);
            shield = shield - 50;
            ShowHUD();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You were ambushed! You lose your shield and 50 health!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //event 3
            Console.Clear();
            addScore(2000);

            ShowHUD();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You climb the crazy mountain and find a treasure chest. YOUR SCORE RAISES!!!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //event 4
            Console.Clear();
            TakeDamage(50);
            addScore(-1500);

            ShowHUD();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You fall off the mountain...wow! You die.");
            Console.WriteLine("Press any key to use a life...");
            lives = lives - 1;
            Console.ReadKey();

            //event 5
            Console.Clear();
            TakeDamage(80);
            addScore(500);

            ShowHUD();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You respawn. You are still falling...but this time a tree catches you! You still lose 80 hp to falling. You jump down from the tree and land on your feet! ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //finale
            Console.Clear();
            TakeDamage(50000);
            addScore(-1050);

            ShowHUD();

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
