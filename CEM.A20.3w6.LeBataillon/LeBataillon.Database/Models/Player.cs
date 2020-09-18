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
            public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerLevel Level { get; set; }

    }
}