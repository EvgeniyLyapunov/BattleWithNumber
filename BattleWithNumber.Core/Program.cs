using BattleWithNumber.LogicLibrary;
using BattleWithNumber.ViewLibrary;
using System;

namespace BattleWithNumber.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gold Games Collection";
            Console.WindowWidth = 80;
            Console.WindowHeight = 24;

            Random rnd = new Random();

            Players _players = new Players(rnd);
            GameLogic _game = new GameLogic(_players, rnd);
            ViewElements _viewElements = new ViewElements(_players, _game, rnd);
            Weapons _weapons = new Weapons(rnd, _viewElements);

            _viewElements.Presents();
            _viewElements.MakeFrames(ConsoleColor.Red);
            _viewElements.Introduction();
            _viewElements.GameMenu();
            _viewElements.GameRules();
            _viewElements.ClearGameMenu();
            _viewElements.GameIntroduction();
            _viewElements.PlayersName();
            _viewElements.PlayerGo();
            _weapons.Sword();
            _game.SetGameNumber();
            _viewElements.NumberOfGame();
            _viewElements.Coin();

            while(_game.GetGameNumber() > 0)
            {
                Console.CursorVisible = false;

                if (_players.GetCurrentPlayer() == 0)
                {
                    int point = 0;
                    while (point <= 0 || point >= 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.CursorVisible = true;
                        Console.SetCursorPosition(10, 7);
                        Console.WriteLine(new string(' ', 60));
                        Console.SetCursorPosition(10, 7);
                        string TempPoint = Console.ReadLine();
                        int.TryParse(TempPoint, out point);
                    }

                    _game.PlayerMove(point);
                    _weapons.UserSwordMove();
                }
                else
                {
                    int point = 0;
                    point = rnd.Next(1, 4);
                    _game.PlayerMove(point);
                    _weapons.CompSwordMove();
                }
                _game.ResultMove(_players.GetCurrentPlayerName());
            }

            if(_game.GetWinner() == _players.GetComputerName())
            {
                _viewElements.Lesion();
            }
            else
            {
                _viewElements.Victory();
            }

            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(36, 11);
            Console.WriteLine("Ещё раз?");

            Console.CursorVisible = false;
            Console.ReadKey(false);

        }
    }
}
