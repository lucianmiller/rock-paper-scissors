namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1Turn { get; set; }
    public string Player2Turn { get; set; }

    public Game(string playerOneTurn, string playerTwoTurn)
    {
      Player1Turn = playerOneTurn;
      Player2Turn = playerTwoTurn;

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    }
  }
}