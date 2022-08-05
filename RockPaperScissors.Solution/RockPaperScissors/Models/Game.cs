namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1Name { get; set; }
    public string Player2Name { get; set; }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    
    public Game(string player1Name, string player2Name)
    {
      Player1Name = player1Name;
      Player2Name = player2Name;
    }
  }
}