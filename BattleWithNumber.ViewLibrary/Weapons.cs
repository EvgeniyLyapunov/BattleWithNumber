using System;
using System.Threading;

namespace BattleWithNumber.ViewLibrary
{
    public class Weapons
    {
        private ViewElements _viewElements;
        private int X { get; set; }
        private int Y { get; set; }
        private string Sword1 { get; set; }
        private string Sword2 { get; set; }
        private readonly Random _rnd;
        public Weapons(Random rnd, ViewElements viewElements)
        {
            X = 4;
            Y = 10;
            Sword1 = "(==O)==========-";
            Sword2 = "<==========|)==o";

            _rnd = rnd;
            _viewElements = viewElements;
        }
         
        public void Sword()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Sword1);         // даём меч игроку 1
            X = 74 - Sword2.Length;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Sword2);         // даём меч игроку 2
        }

        /// <summary>
        /// метод реализует удар игрока 1
        /// </summary>
        public void UserSwordMove()
        {
            X = 4;
            Y = 10;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(new string(' ', Sword1.Length));

            for (int i = 1; i < 18; i++)             // начало движения меча вперёд
            {
                Console.SetCursorPosition(X + i, Y);
                Console.WriteLine(Sword1);

                Thread.Sleep(40);

                Console.SetCursorPosition(X + i, Y);
                Console.WriteLine(new string(' ', Sword1.Length));
            }
            Console.SetCursorPosition(X + 17, Y);
            Console.WriteLine(Sword1);               // окончание движения меча вперёд

            SwordStrike();
            _viewElements.NumberOfGame();

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X + 17, Y);    // меч на исходной позиции
            Console.WriteLine(new string(' ', Sword1.Length));
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Sword1);
        }

        /// <summary>
        /// метод реализует удар игрока 2
        /// </summary>
        public void CompSwordMove()
        {
            X = 74 - Sword2.Length;
            Y = 10;
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(new string(' ', Sword2.Length));

            for (int i = 1; i < 18; i++)             // начало движения меча вперёд
            {
                Console.SetCursorPosition(X - i, Y);
                Console.WriteLine(Sword2);

                Thread.Sleep(40);

                Console.SetCursorPosition(X - i, Y);
                Console.WriteLine(new string(' ', Sword2.Length));
            }
            Console.SetCursorPosition(X - 17, Y);
            Console.WriteLine(Sword2);

            SwordStrike();
            _viewElements.NumberOfGame();

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X - 17, Y);    // меч на исходной позиции
            Console.WriteLine(new string(' ', Sword2.Length));
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Sword2);
        }

        /// <summary>
        /// Звуки битвы
        /// </summary>
        private void SwordStrike()
        {
            int[] arrayX = new int[] { 34, 40 };
            int[] arrayY = new int[] { 8, 12 };
            string[] arrayTxt = new string[11] { "бах", "бабах", "херакс", "дзинь", "на", "вжих", "иии-ха", "бух", "бдыщь", "трах", "Ээээх" };
            int qX = _rnd.Next(0, 2);
            int qY = _rnd.Next(0, 2);
            int qTxt = _rnd.Next(0, 11);

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(arrayX[qX], arrayY[qY]);
            Console.WriteLine(arrayTxt[qTxt]);

            Thread.Sleep(650);

            Console.SetCursorPosition(arrayX[qX], arrayY[qY]);
            Console.WriteLine(new string(' ', arrayTxt[qTxt].Length));
        }

    }
}
