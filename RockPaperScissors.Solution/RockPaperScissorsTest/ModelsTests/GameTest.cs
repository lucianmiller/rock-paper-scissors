using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  //use line below when its time to start clearing data between tests
  //public class GameTests: IDisposable
  //lesson ref (3.1.2.6)
  {
  //   public void Dispose()
  //   {
  //     Game.ClearAll();
  //   }

    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
  }
}