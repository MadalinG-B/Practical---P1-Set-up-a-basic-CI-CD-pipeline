namespace Practical1.Tests;

public class UnitTest1
{
    [Fact]
    public void AlwaysTrue_ShouldPass()
    {
      var expected = true;
      
      var actual = true;

      Assert.Equal(expected,actual);
    }

    [Fact]
    public void StringNotEmpty_ShouldPass()
    {
      var value = "Hello, Azure DevOps!";

      Assert.False(string.IsNullOrEmpty(value));
    }

}
