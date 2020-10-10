using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;
namespace LeBataillon.Database.MockData
{
    public class TeamMockData
    {
        public static List<Team> GetTeamTest()
        {
            var _Team = new List<Team>()
            {
                new Team
                {
                    Id = 1,
                    TeamName = "Bouffe",
                    CaptainId = 1,
                    JoueurMaximum = 7
                },
                new Team
                {
                    Id = 2,
                    TeamName = "Pizza",
                    CaptainId = 2,
                    JoueurMaximum = 6
                },
                new Team
                {
                    Id = 3,
                    TeamName = "Lazer",
                    CaptainId = 3,
                    JoueurMaximum = 12
                }
            };
            return _Team;
        }
    }
}