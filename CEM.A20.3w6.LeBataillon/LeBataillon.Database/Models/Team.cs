using System.Collections.Generic;
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

        public Team(int Id, string TeamName, int JoueurMaximum, int? CaptainId)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.JoueurMaximum = JoueurMaximum;
            this.CaptainId = CaptainId;
        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.JoueurMaximum = t.JoueurMaximum;
            this.CaptainId = t.CaptainId;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez désigner un nom d'équipe")]
        [MaxLength(25)]
        [Display(Name = "Nom de l'équipe")]
        public string TeamName { get; set; }

        [Required(ErrorMessage = "Veuillez désigner un capitaine")]
        [Display(Name = "Capitaine")]
        [ForeignKey("CaptainId")]
        public Player Captain;

        [Required(ErrorMessage = "Veuillez désigner un nombre de personne maximum")]
        [Range(6, 12, ErrorMessage = "Il faut que le nombre soit entre 6 et 12")]
        [Display(Name = "Nombre de joueur maximum")]
        public int JoueurMaximum { get; set; }

        public int? CaptainId { get; set; }
        [InverseProperty("Team")]
        public List<Player> Players;
    }
}