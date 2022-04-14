using Xunit;
using AlphabetKata;

namespace AlphabetPositionTests;

public class AlphabetPositionShould
{

    [Fact]
    public void SampleTest()
    {
      Assert.Equal("20 8 9 1 7 15", Alphabet.AlphabetPosition("thiago"));
      Assert.Equal("20 8 9 1 7 15 8 15 12 4 5 18", Alphabet.AlphabetPosition("thiago holder"));
      Assert.Equal("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Alphabet.AlphabetPosition("The sunset sets at twelve o' clock."));
    }
}