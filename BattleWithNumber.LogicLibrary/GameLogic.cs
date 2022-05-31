using System;

namespace BattleWithNumber.LogicLibrary
{
    public class GameLogic
    {
        private readonly Random _rnd;
        private int gameNumber;
        private string winner;
        private Players _player;

        public GameLogic(Players player, Random rnd)
        {
            gameNumber = 0;
            winner = "";
            _player = player;
            _rnd = rnd;
        }

        public void SetGameNumber()
        {
            gameNumber = _rnd.Next(10, 21);
        }

        public int GetGameNumber() => gameNumber;

        public void PlayerMove(int points)
        {
            gameNumber -= points;
        }

        public void ResultMove(string currentPlayerName)
        {
            if (gameNumber <= 0)
            {
                winner = currentPlayerName;
            }
            else
            {
                _player.ChangeCurrentPlayer();
            }
        }

        public string GetWinner()
        {
            return winner;
        }
    }
}
