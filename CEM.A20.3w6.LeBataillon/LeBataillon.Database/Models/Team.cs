using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public class Team
    {

        public Team()
        {


        }

        public Team(int Id, string TeamName, Player Captain)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.Captain = Captain;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.Captain = t.Captain;

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Required]
        public Player Captain { get; set; }

    }
}