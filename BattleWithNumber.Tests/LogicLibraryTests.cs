using NUnit.Framework;
using BattleWithNumber.LogicLibrary;
using System;

namespace BattleWithNumber.Tests
{
    [TestFixture]
    public class LogicLibraryTests
    {
        Players _players;
        GameLogic _gameLogic;
        [SetUp]
        //public void Setup()
        //{
        //    _players = new Players();
        //    _gameLogic = new GameLogic(_players);
        //}

        //[Test]
        //public void SetStartPosition_Rnd0_User()
        //{
        //    int rnd = 0;
        //    var result = _players.SetStartPosition(rnd);
        //    var expected = "User";

        //    Assert.That(result, Is.EqualTo(expected));
        //}

        [Test]
        public void RenameUser_John_ChangeNameUserToNameJohn()
        {
            string newName = "John";

            _players.RenameUser(newName);
            var result = _players.GetUserName();

            Assert.That(result, Is.EqualTo(newName));
        }

        //[Test]
        //public void SetGameNumber_rnd10_GameNumberEqual10()
        //{
        //    int rnd = 10;
        //    _gameLogic.SetGameNumber(rnd);
        //    var result = _gameLogic.GetGameNumber();

        //    Assert.That(result, Is.EqualTo(rnd));
        //}

        //[Test]
        //public void PlayerMove_Point2_DecreaseGameNumberOn2()
        //{
        //    int point = 2;
        //    _gameLogic.SetGameNumber(10);

        //    _gameLogic.PlayerMove(point);
        //    int expectedResult = 8;
        //    int result = _gameLogic.GetGameNumber();

        //    Assert.That(expectedResult, Is.EqualTo(result));
        //}

        //[Test]
        //[TestCase(0)]
        //[TestCase(4)]
        //public void PlayerMove_PointCase_ThrowArgumentException(int value)
        //{
        //    int point = value;
        //    _gameLogic.SetGameNumber(10);

        //    Assert.Throws<ArgumentException>(() => _gameLogic.PlayerMove(point));
        //}


        [Test]
        public void ChangeCurrentPlayer_CurrentPlayer1_NewCurrentPlayer0()
        {
            int expected = 0;
            int result = _players.ChangeCurrentPlayer();

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
