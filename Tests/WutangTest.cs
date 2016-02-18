using System;
using System.Collections.Generic;
using Xunit;

namespace FindReplaceNameSpace
{
  public class Wutangclass
  {
      [Fact]
      public void Test1_ArrayShift_True()
      {
        Wutang newWutang = new Wutang("This is not test", "not", "a");
        Assert.Equal("This is a test", newWutang.ArrayShift());
      }
  }
}
