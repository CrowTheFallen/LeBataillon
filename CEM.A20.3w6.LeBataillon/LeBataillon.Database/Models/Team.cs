using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LeBataillon.Database.Context;

namespace LeBataillon.Database.Models
{
    public class Team
    {

        public Team()
        {


        }

        public Team(int Id, string TeamName, int Captain, int JoueurMaximum)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.Captain = Captain;
            this.JoueurMaximum = JoueurMaximum;
        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.Captain = t.Captain;
            this.JoueurMaximum = JoueurMaximum;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez désigner un nom d'équipe")]
        [MaxLength(25)]
        [Display(Name = "Nom de l'équipe")]
        public string TeamName { get; set; }

        [Required(ErrorMessage = "Veuillez désigner un capitaine")]
        [MaxLength(1)]
        [Display(Name = "Capitaine")]
        //[ForeignKey("CaptainId")]
        public int Captain { get; set; }

        [Required(ErrorMessage = "Veuillez désigner un nombre de personne maximum")]
        [Range(6, 12)]
        [Display(Name = "Nombre de joueur maximum")]
        public int JoueurMaximum { get; set; }
    }
}