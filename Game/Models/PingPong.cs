namespace Game
{
  public class PingPong
  {
    public bool PingPongList(int number)
    {
      if (number % 5 == 0)
      {
        return true;
      }
      else
      {
      return number % 3 == 0;
      }
    }
  }
}
