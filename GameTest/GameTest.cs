using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHall;

namespace GameTest
{
    [TestClass]
    public class GameTest
    {


        [TestMethod]
        public void ChooseCup()
        {
            //ARRANGE
            Game.Cups middle = Game.Cups.Middle;
            Game game = new Game(1,middle);

            //ACT


            //ASSERT
            Assert.AreEqual(middle, game.SelectedCup);
        }


        [TestMethod]
        public void GameExecution()
        {
            //Arrange
            Game game1 = new Game(1,Game.Cups.Left);
            game1.RemoveCup();
            bool didUserChange = true;
            game1.ReassignCup(didUserChange);
            bool result = game1.Result();

            //Assert
            
        }

    }
}
