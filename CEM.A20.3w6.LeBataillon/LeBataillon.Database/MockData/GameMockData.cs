using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class GameMockData
    {
        public static List<Game> GetGameTest()
        {
            var _Game = new List<Game>()
            {
                new Game
                {
                    Id = 1,
                    GameDateTime = DateTime.Now + TimeSpan.FromDays(23),
                    TeamDefendant = 666,
                    TeamAttacker = 667,
                    status = GameStatus.ongoing
                },
                new Game
                {
                    Id = 2,
                    GameDateTime = DateTime.Now + TimeSpan.FromDays(24),
                    TeamDefendant = 667,
                    TeamAttacker = 668,
                    status = GameStatus.forthcoming
                },
                new Game
                {
                    Id = 3,
                    GameDateTime = DateTime.Now + TimeSpan.FromDays(25),
                    TeamDefendant = 668,
                    TeamAttacker = 669,
                    status = GameStatus.forthcoming
                },
                new Game
                {
                    Id = 4,
                    GameDateTime = DateTime.Now + TimeSpan.FromDays(26),
                    TeamDefendant = 669,
                    TeamAttacker = 670,
                    status = GameStatus.forthcoming
                },
                new Game
                {
                    Id = 5,
                    GameDateTime = DateTime.Now + TimeSpan.FromDays(22),
                    TeamDefendant = 665,
                    TeamAttacker = 666,
                    status = GameStatus.finished
                }
            };
            return _Game;
        }
    }
}