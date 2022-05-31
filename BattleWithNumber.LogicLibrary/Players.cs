using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleWithNumber.LogicLibrary
{
    public class Players
    {
        private readonly Random _rnd;
        private List<string> playerNames;
        private readonly List<string> ComputerNames = new List<string>()
        {
            "Spectrum ZX MegaBrain", "Crazy Calculator", "IBM PC", "Freandly Killer"
        };
        private int currentPlayer;
        private int pointsOfPlayerMove;

        public Players(Random rnd)
        {
            playerNames = new List<string>() { "User", "Computer" };
            currentPlayer = 1;
            pointsOfPlayerMove = 0;
            _rnd = rnd;
        }

        public void RenameUser(string newUserName)
        {
            playerNames[0] = newUserName;
        }

        public void RenameComputer()
        {
            playerNames[1] = ComputerNames[_rnd.Next(0, 4)];
        }

        public string SetStartPosition()
        {
            currentPlayer = _rnd.Next(0, 2);
            return playerNames[currentPlayer];
        }

        public int GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public string GetCurrentPlayerName()
        {
            return playerNames[currentPlayer];
        }

        public string GetUserName()
        {
            return playerNames[0];
        }

        public string GetComputerName()
        {
            return playerNames[1];
        }

        public void ChangeCurrentPlayer()
        {
            currentPlayer = currentPlayer == 0 ? 1 : 0;
        }

        public int PointsMove()
        {
            int.TryParse(Console.ReadLine(), out pointsOfPlayerMove);

            return pointsOfPlayerMove;
        }

    }
}
