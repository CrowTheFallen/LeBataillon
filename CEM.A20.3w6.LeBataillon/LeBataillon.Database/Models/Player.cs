using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public class Player
    {
        public Player()
        {


        }

        public Player(int Id, string NickName, string Email, string PhoneNumber, string FirstName, string LastName, PlayerLevel level)
        {
            this.Id = Id;
            this.NickName = NickName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Level = Level;

        }

        public void EditFrom(Player p)
        {
            this.Id = p.Id;
            this.NickName = p.NickName;
            this.Email = p.Email;
            this.PhoneNumber = p.PhoneNumber;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Level = p.Level;

        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Surnom")]
        public string NickName { get; set; }
        [Required(ErrorMessage = "Veuillez désigner un adresse email ")]
        [MaxLength(50), EmailAddress]
        [Display(Name = "Émail")]
        public string Email { get; set; }
        [Display(Name = "Numéro de téléphone")]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Veuillez désigner un prénom")]
        [MaxLength(50)]
        [Display(Name = "Nom du joueur")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Veuillez désigner un nom de famille")]
        [MaxLength(50)]
        [Display(Name = "Nom de famille du joueur")]
        public string LastName { get; set; }
        [Range(0, 3)]
        [Display(Name = "Niveau du joueur")]
        public PlayerLevel Level { get; set; }

        public virtual Team Team { get; set; }




    }
}