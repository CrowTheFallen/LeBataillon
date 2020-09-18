using System;

namespace LeBataillon.Database.Models
{
    public class Game
    {
        public Game()
        {


        }

        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendant = TeamDefendant;
            this.TeamAttacker = TeamAttacker;

        }

        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendant = g.TeamDefendant;
            this.TeamAttacker = g.TeamAttacker;

        }
        public int Id { get; set; }
        public DateTime GameDateTime { get; set; }
        public int TeamDefendant { get; set; }
        public int TeamAttacker { get; set; }
    }
}