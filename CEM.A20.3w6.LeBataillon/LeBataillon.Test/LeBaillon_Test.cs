using System;
using Xunit;
using System.Linq;
using LeBataillon.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LeBataillon.Database.Models;
using LeBataillon.Database.MockData;
using Moq;
using LeBataillon.Database.Context;

namespace LeBataillon.Test
{
    public class LeBaillon_Test
    {
        [Fact]
        public void PlayerCreate_Test()
        {
            //Arrange
            Player player = new Player()
            {
                Id = 3,
                NickName = "Pepo",
                Email = "Will19@hotmail.com",
                PhoneNumber = "450-234-7272",
                FirstName = "Pep",
                LastName = "Damn",
                Level = PlayerLevel.avancé
            };
            //Act

            //Assert

        }

        [Fact]
        public void PlayerValide_Test()
        {
            //Arrange

            //Act

            //Assert
            //Assert.
        }
        [Fact]
        public void PlayerIndex_Test()
        {
            //Arrange
            //var mockRepo = new Mock<PlayerData>();
            //mockRepo.Setup(n => n.Players).Returns(PlayerMockData.GetPlayerTest());
            //var controller = new PlayerController(mockRepo.Object);
            //Act
            //var result = controller.Index();

            //Assert
            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Team_Test()
        {
            //Arrange
            var mockRepo = new Mock<Team>();

            //Act

            //Assert
        }

        [Fact]
        public void Game_Test()
        {
            //Arrange
            var mockRepo = new Mock<Game>();

            //Act

            //Assert
        }
    }
}
