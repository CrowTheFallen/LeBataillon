using System;
using System.ComponentModel.DataAnnotations;
namespace LeBataillon.Database.Models
{
    public class Game
    {
        public Game()
        {


        }

        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker, GameStatus status)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendant = TeamDefendant;
            this.TeamAttacker = TeamAttacker;
            this.status = status;
        }

        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendant = g.TeamDefendant;
            this.TeamAttacker = g.TeamAttacker;
            this.status = g.status;
        }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Veuillez désigner le moment du match")]
        [Display(Name = "Moment du match")]
        public DateTime GameDateTime { get; set; }
        [Display(Name = "Équipe défendante")]
        public int? TeamDefendant { get; set; }
        [Display(Name = "Équipe attaquante")]
        public int? TeamAttacker { get; set; }
        [Required(ErrorMessage = "Veuillez désigner le status du match")]
        [Range(0, 2)]
        [Display(Name = "Status du match")]
        public GameStatus status { get; set; }
    }
}