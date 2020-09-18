using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Context
{
    public class PlayerData
    {
        
    public  List<Player> Data = new List<Player>();

             public void EnsureCreated(){

        for (int i = 1; i < 100; i++)
        {
          var name = SampleData.GenerateName(i);
            Data.Add(new Player(i,  $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i),SampleData.GenerateName(i+1), SampleData.GenerateLastName(i), SampleData.GenerateLevel()));
        } 
    }
 }



}
