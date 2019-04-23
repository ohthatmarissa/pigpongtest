using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void PingPongList_NumberDivisiblebyThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.PingPongList(6));
    }
    [TestMethod]
    public void PingPongList_NumberDivisiblebyFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.PingPongList(10));
    }
  }
}
