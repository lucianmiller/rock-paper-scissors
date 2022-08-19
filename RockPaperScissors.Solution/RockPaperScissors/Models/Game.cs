using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1Name { get; set; }
    public string Player2Name { get; set; }
    public int Player1Score{ get; set;}
    public int Player2Score{ get; set;}

    public Game(string player1Name, string player2Name)
    {
      Player1Name = player1Name;
      Player2Name = player2Name;
      Player1Score = 0;
      Player2Score = 0;
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

    public string RoundEndDetermineWinner(string playerOneMove, string playerTwoMove)
    {
      if (playerOneMove == playerTwoMove)
      {
        return "Draw";
      }
      else
      {
        if (playerOneMove == "rock" && playerTwoMove == "scissors")
        {
          this.Player1Score += 1;
          return " wins";
        }
        else if (playerOneMove == "paper" && playerTwoMove == "rock")
        {
          this.Player1Score += 1;
          return " wins";
        }
        else if (playerOneMove == "scissors" && playerTwoMove == "rock")
        {
          this.Player1Score += 1;
          return " wins";
        }
        else
        {
          this.Player2Score += 1;
          return " loses";
        }
      }
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
        Console.WriteLine("Enter Rock, Paper, Scissors:");
        string playerOneTurn = Console.ReadLine();
        string playerTwoTurn = newGame.ComputerTurn();
        Console.WriteLine($"{newGame.Player1Name} {newGame.RoundEndDetermineWinner(playerOneTurn, playerTwoTurn)}");
        Console.WriteLine("Round Over!");
        Console.WriteLine($"{newGame.Player1Name} Score: {newGame.Player1Score}");
        Console.WriteLine($"{newGame.Player2Name} Score: {newGame.Player2Score}");
        
        Console.WriteLine("Would you like to play a round? (y or n)");
        continueGame = Console.ReadLine();
      }
      Console.WriteLine("Game Over!");
    }
  }
}
// next steps
// 2) prompt user for rock paper or scissors and store in variable
// 3) method determining win or lose
// create player and computer score properties in class and constructor