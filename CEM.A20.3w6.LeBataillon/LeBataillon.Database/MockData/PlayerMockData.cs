using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class PlayerMockData
    {
        public static List<Player> GetPlayerTest()
        {
            var _Player = new List<Player>()
            {
                new Player()
                {
                   Id = 1,
                   NickName = "SlomoRedrigues",
                   Email = "Bob12@hotmail.com",
                   PhoneNumber = "450-234-4532",
                   FirstName = "Bob",
                   LastName = "Morley",
                   Level = PlayerLevel.débutant
                },
                new Player()
                {
                   Id = 2,
                   NickName = "Pep",
                   Email = "Alex12@hotmail.com",
                   PhoneNumber = "450-234-7372",
                   FirstName = "Pepito",
                   LastName = "Sanchez",
                   Level = PlayerLevel.avancé
                }
            };
            return _Player;
        }
    }
}