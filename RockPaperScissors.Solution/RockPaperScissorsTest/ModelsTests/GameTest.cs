using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests: IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }
  }
}