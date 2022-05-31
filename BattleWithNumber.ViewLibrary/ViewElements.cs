using BattleWithNumber.LogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleWithNumber.ViewLibrary
{
    public class ViewElements
    {
        private Players _player;
        private GameLogic _gameLogic;
        private readonly Random _rnd;
        private string Viva { get; set; }
        private string Vic { get; set; }
        private string Death { get; set; }
        private string Skill { get; set; }
        private string Egor { get; set; }

        public ViewElements(Players player, GameLogic gameLogic, Random rnd)
        {
            _player = player;
            _gameLogic = gameLogic;
            _rnd = rnd;
            Viva = "Па Бам !!!  Па Ба Па Пам !!!";
            Vic = "{0}, ты круче всех крутых, ты победил!!!!!";
            Death = "Это game over, мой друг! Ты проиграл.";

            Skill = "Skillbox University";
            Egor = "Evgeniy Lyapunov production";
        }

        /// <summary>
        /// метод выводит имена авторов
        /// </summary>
        public void Presents()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(8, 4);
            Console.WriteLine(Skill);
            Thread.Sleep(1500);


            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(36, 12);
            Console.WriteLine("and");
            Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((74 - Egor.Length), 22);
            Console.WriteLine(Egor);
            Thread.Sleep(3000);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string a = "ПРЕДСТАВЛЯЮТ:";
            Console.SetCursorPosition(27, 12);
            foreach (var e in a)
            {
                Console.Write($"{e} ");
                Thread.Sleep(70);
            }
            Thread.Sleep(1500);
            Console.Clear();
        }

        /// <summary>
        /// Метод выводит рамку из звёздочек
        /// </summary>
        public void MakeFrames(ConsoleColor color)
        {
            int X = 2;
            int Y = 2;
            Console.CursorVisible = false;
            Console.ForegroundColor = color;

            for (int i = 2; i < 78; i++)               // X(i) = 2, Y = 2 >>>> X(i) = 76, Y = 2
            {
                Console.SetCursorPosition(i, Y);
                Console.Write("*");
                Thread.Sleep(8);
            }
            X = 77;
            for (int i = 2; i < 21; i++)               // X = 76, Y(i) = 2 >>>> X = 76, Y(i) = 20
            {
                Console.SetCursorPosition(X, i);
                Console.Write("*");
                Thread.Sleep(8);
            }
            Y = 20;
            for (int i = 77; i > 1; i--)              // X(i) = 76, Y = 20 >>>> X(i) = 2, Y = 20
            {
                Console.SetCursorPosition(i, Y);
                Console.Write("*");
                Thread.Sleep(8);
            }
            X = 2;
            for (int i = 20; i > 1; i--)               // X = 2, Y(i) = 20 >>>> X = 2, Y(i) = 2
            {
                Console.SetCursorPosition(X, i);
                Console.Write("*");
                Thread.Sleep(8);
            }
        }

        /// <summary>
        /// метод выводит название игры
        /// </summary>
        public void Introduction()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            int X = 31;
            int Y = 7;
            Console.SetCursorPosition(X - 2, Y);
            Console.WriteLine(new string('_', 22));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(X - 2, Y + 4);
            Console.WriteLine(new string('_', 22));

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y + 2);
            Console.WriteLine("Battle Of The Mind");
            Console.SetCursorPosition(X + 3, Y + 3);
            Console.WriteLine("with NUMBERS");
            Thread.Sleep(1500);
        }

        /// <summary>
        /// Метод выводит меню для выбора начала игры или чтения правил игры
        /// </summary>
        public void GameMenu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(35, 14);
            Console.WriteLine("Меню игры:");
            Console.SetCursorPosition(15, 16);
            Console.WriteLine("Нажмите \"1\" если вы хотите прочитать правила игры.");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine("Нажмите \"2\" если вы хотите начать игру.");
            Console.SetCursorPosition(39, 19);
        }

        /// <summary>
        /// метод стирает с консоли строчки меню игры
        /// </summary>
        public void ClearGameMenu()
        {
            for (int i = 14; i < 20; i++)
            {
                Console.SetCursorPosition(7, i);
                Console.WriteLine(new string(' ', 65));
            }

        }

        /// <summary>
        /// Метод выводит на экран правила игры
        /// </summary>
        public void GameRules()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if(key.KeyChar == '1')
                {
                    Console.Clear();
                    MakeFrames(ConsoleColor.Green);
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(8, 4);
                        Console.WriteLine("В этой версии игры вы играете против компьютера.");
                        Console.SetCursorPosition(8, 5);
                        Console.WriteLine("Введите своё имя, когда попросят, и нажмите Enter.");
                        Console.SetCursorPosition(8, 6);
                        Console.WriteLine("Далее выбирается игрок, начинающий первым.");
                        Console.SetCursorPosition(8, 7);
                        Console.WriteLine("В центре, на синем фоне, появляется Игровое Число.");
                        Console.SetCursorPosition(8, 8);
                        Console.WriteLine("Игроки по очереди вводят любую цифру от 1 до 3.");
                        Console.SetCursorPosition(8, 9);
                        Console.WriteLine("На эту цифру уменьшается Игровое Число.");
                        Console.SetCursorPosition(8, 10);
                        Console.WriteLine("Выигрывает тот игрок, после хода которого,");
                        Console.SetCursorPosition(8, 11);
                        Console.WriteLine("Игровое Число становится равным или меньше 0.");
                        Console.SetCursorPosition(8, 12);
                        Console.WriteLine("Удачи.");
                        Console.SetCursorPosition(8, 15);
                        Console.WriteLine("Если всё понятно, жми Enter!");
                        Console.CursorVisible = false;

                        key = Console.ReadKey(true);
                    }
                    while (key.Key != ConsoleKey.Enter);

                    Console.Clear();

                    MakeFrames(ConsoleColor.Red);
                    Introduction();
                    GameMenu();
                }
            }
            while (key.KeyChar != '2');
        }

        /// <summary>
        /// метод сообщает о начале игры и предлагает игрокам представиться
        /// </summary>
        public void GameIntroduction()
        {   // стираем название игры
            for (int i = 7; i < 13; i++)
            {
                for (int j = 29; j < 52; j++)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                    Thread.Sleep(10);
                }

            }
            // пишем и поднимаем "Игра началась!"
            string StartGame = "Игра началась!";
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 9; i > 3; i--)
            {

                Console.SetCursorPosition(32, i);
                Console.WriteLine(StartGame);
                if (i == 9)
                {
                    Thread.Sleep(1500);                // задержка надписи до поднятия
                }
                Thread.Sleep(100);
                Console.SetCursorPosition(32, i);
                Console.WriteLine("              ");
                if (i == 4)
                {
                    Console.SetCursorPosition(32, i);
                    Console.WriteLine(StartGame);      // закрепление надписи вверху поля
                }
            }
            // пишем и поднимаем "Время представиться игрокам"
            string TimeToName = "Время огласить на Арене имя смельчака!";
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 9; i > 4; i--)
            {

                Console.SetCursorPosition((40 - TimeToName.Length / 2), i);
                Console.WriteLine(TimeToName);
                if (i == 9)
                {
                    Thread.Sleep(1500);    // задержка надписи до поднятия
                }
                Thread.Sleep(100);
                Console.SetCursorPosition((40 - TimeToName.Length / 2), i);
                Console.WriteLine(new string(' ', TimeToName.Length));
                if (i == 5)
                {
                    Console.SetCursorPosition((40 - TimeToName.Length / 2), i);
                    Console.WriteLine(TimeToName);
                }
            }
        }

        /// <summary>
        /// Метод даёт возможность ввести своё имя и выводит имя компьютера
        /// </summary>
        public void PlayersName()
        {
            string player = "";

            // игроки представляются
            Console.SetCursorPosition(4, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("на левой стороне:");
            Console.SetCursorPosition(4, 11);
            Console.CursorVisible = true;
            do
            {
                try
                {
                    player = Console.ReadLine();      // имя первого игрока
                    if(player == "")
                    {
                        throw new FormatException();
                    }
                }
                catch(FormatException)
                {
                    Console.SetCursorPosition(4, 11);
                }
            }
            while (string.IsNullOrEmpty(player));

            _player.RenameUser(player);

            Console.CursorVisible = false;
            Console.SetCursorPosition(4, 11);
            Console.WriteLine(player);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(56, 9);
            Console.WriteLine("на правой стороне:");
            Console.SetCursorPosition(56, 11);
            Console.CursorVisible = true;
            _player.RenameComputer();       // имя компьютера
            Console.CursorVisible = false;
            Console.SetCursorPosition(56, 11);
            Console.WriteLine(new string(' ', _player.GetComputerName().Length));
            Console.SetCursorPosition(75 - _player.GetComputerName().Length, 11);
            Console.WriteLine(_player.GetComputerName());
            Thread.Sleep(1000);
        }

        /// <summary>
        /// метод поднимает игроков вверх поля
        /// </summary>
        public void PlayerGo()
        {
            //игроки выходят на "позицию боя"
            for (int i = 11; i > 3; i--)                                // движение игроков вверх
            {
                Console.SetCursorPosition(4, i);
                Console.WriteLine(new string(' ', 71));
                Console.SetCursorPosition(4, i);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(_player.GetUserName());
                Console.SetCursorPosition(75 - _player.GetComputerName().Length, i);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(_player.GetComputerName());
                Thread.Sleep(150);
                Console.SetCursorPosition(4, i);
                Console.WriteLine(new string(' ', 71));

                if (i == 4)                                              // остановка игроков на позиции
                {
                    Console.SetCursorPosition(4, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(_player.GetUserName());
                    Console.SetCursorPosition(75 - _player.GetComputerName().Length, i);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(_player.GetComputerName());
                }
            }
        }

        /// <summary>
        /// метод выводит на экран игровое число
        /// </summary>
        public void NumberOfGame()
        {
            int X = 38;
            int Y = 10;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(new string(' ', 2));
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(_gameLogic.GetGameNumber());
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// метод подбрасывает монету и определяет того, кто начнет первым
        /// </summary>
        public void Coin()
        {
            int X = 38;
            int Y = 10;
            char[] arrayCoin = new char[5] { '_', '/', '|', '\\', '_' };
            string txt = "Пусть монета определит, кто ходит первым.";
            int temp = txt.Length;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(X, Y);
            Console.SetCursorPosition((X - temp / 2), Y - 1);
            Console.WriteLine(txt);
            Thread.Sleep(1500);


            for (int i = 0; i < 5; i++) // монетка вверх
            {
                Console.SetCursorPosition(X, (Y - 2) - i);
                Console.WriteLine(arrayCoin[i]);
                Thread.Sleep(300);
                Console.SetCursorPosition(X, (Y - 2) - i);
                Console.WriteLine(" ");
            }
            for (int i = 1; i < 5; i++) // монетка вниз
            {
                Console.SetCursorPosition(X, (Y - 6) + i);
                Console.WriteLine(arrayCoin[i]);
                Thread.Sleep(300);
                Console.SetCursorPosition(X, (Y - 6) + i);
                Console.WriteLine(" ");
            }
            Console.SetCursorPosition((X - temp / 2), Y - 1);
            Console.WriteLine(new string(' ', txt.Length));

            _player.SetStartPosition();

            Console.SetCursorPosition(X, (Y - 2));
            string txt1 = $"Игрок {_player.GetUserName()} начинает";
            string txt2 = $"Игрок {_player.GetComputerName()} начинает";
            if (_player.GetCurrentPlayer() == 0)
            {
                Console.SetCursorPosition((X - txt1.Length / 2), (Y - 4));
                Console.WriteLine(txt1);
                Thread.Sleep(2000);
                Console.SetCursorPosition((X - txt.Length / 2), (Y - 2));
                Console.WriteLine(new string(' ', txt.Length));
            }
            else
            {
                Console.SetCursorPosition((X - txt2.Length / 2), (Y - 2));
                Console.WriteLine(txt2);
                Thread.Sleep(2000);
                Console.SetCursorPosition((X - txt.Length / 2), (Y - 2));
                Console.WriteLine(new string(' ', txt.Length));
            }
        }

        /// <summary>
        /// метод выводит экран победы
        /// </summary>
        public void Victory()
        {
            int X, Y;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            int color;
            for (int i = 0; i < 300; i++)
            {
                X = _rnd.Next(4, 76);
                Y = _rnd.Next(2, 25);
                color = _rnd.Next(2, 15);
                Console.SetCursorPosition(X, Y);
                Console.ForegroundColor = colors[color];
                Console.WriteLine("*");
                Thread.Sleep(5);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((40 - Viva.Length / 2), 9);
            Console.WriteLine(Viva);
            Console.SetCursorPosition((40 - Vic.Length / 2), 11);
            Console.WriteLine(Vic, _gameLogic.GetWinner());

        }

        /// <summary>
        /// метод выводит экран поражения
        /// </summary>
        public void Lesion()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.SetCursorPosition((40 - Death.Length / 2), 9);
            Console.WriteLine(Death);
        }


    }
}
