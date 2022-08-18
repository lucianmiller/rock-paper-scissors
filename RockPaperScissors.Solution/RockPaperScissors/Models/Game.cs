using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1Name { get; set; }
    public string Player2Name { get; set; }

    public Game(string player1Name, string player2Name)
    {
      Player1Name = player1Name;
      Player2Name = player2Name;
    }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    public string ComputerTurn() 
    {
      string[] options = {"rock", "paper", "scissors"};
      Random rand = new Random();
      int randNum = rand.Next(0, 3);
      return options[randNum];
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Please enter your name:");
      string playerOne = Console.ReadLine();

      Game newGame = new Game(playerOne, "Computer");
      string continueGame = "y";

      while (continueGame == "y")
      {
        Console.WriteLine("Would you like to play a round? (y or n)");
        continueGame = Console.ReadLine();

        Console.WriteLine("Enter Rock, Paper, Scissors:");
        string playerOneTurn = Console.ReadLine();
        string playerTwoTurn = newGame.ComputerTurn();
        Console.WriteLine(playerOneTurn);
        Console.WriteLine(playerTwoTurn);
      }
      Console.WriteLine("Game Over!");
    }
  }
}
// next steps
// 2) prompt user for rock paper or scissors and store in variable
// 3) method determining win or lose
// create player and computer score properties in class and constructor