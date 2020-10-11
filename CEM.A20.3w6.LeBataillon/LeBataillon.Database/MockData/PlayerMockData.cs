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
                },
                new Player()
                {
                   Id = 3,
                   NickName = "Pepo",
                   Email = "Will19@hotmail.com",
                   PhoneNumber = "450-234-7272",
                   FirstName = "Pep",
                   LastName = "Damn",
                   Level = PlayerLevel.avancé
                },
                new Player()
                {
                   Id = 4,
                   NickName = "ARG",
                   Email = "Hidden12@hotmail.com",
                   PhoneNumber = "450-253-7272",
                   FirstName = "Argus",
                   LastName = "Corrpt",
                   Level = PlayerLevel.intermédiaire
                },
                new Player()
                {
                   Id = 5,
                   NickName = "NEIL",
                   Email = "Spaceman88@hotmail.com",
                   PhoneNumber = "450-234-9372",
                   FirstName = "Neil",
                   LastName = "Armstrong",
                   Level = PlayerLevel.débutant
                }
            };
            return _Player;
        }
    }
}