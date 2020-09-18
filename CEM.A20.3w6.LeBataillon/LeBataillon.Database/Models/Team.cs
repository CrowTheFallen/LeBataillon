namespace LeBataillon.Database.Models
{
    public class Team
    {
        
         public Team()
        {


        }

        public Team(int Id, string TeamName, int Captain)
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
            public int Id { get; set; }
        public string TeamName { get; set; }
        public int Captain { get; set; }

    }
}