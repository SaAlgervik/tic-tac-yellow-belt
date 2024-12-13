using tic_tac_yellow_belt;

namespace Test;

public class TicTacToeTests
{
    [Fact(DisplayName = "Test")]
    public void Test()
    { 
        var ticTacToe = new TicTacToe();
        Assert.True(ticTacToe.Method1());
    }
}
