using FluentAssertions;
using tic_tac_yellow_belt;

namespace Test;

public class TicTacToeTests
{
    [Fact(DisplayName = "When player starts game, then a empty game bord should be printed")]
    public void PrintBord_WhenPlayerStartsGame_ThenGameBordShouldBePrinted()
    { 
        const string expectedOutput = "==========\r\n 1 | 2 | 3 \r\n---+---+---\r\n 4 | 5 | 6 \r\n---+---+---\r\n 7 | 8 | 9 \r\n==========\r\n";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        TicTacToe.PrintBord();   
        
        var output = stringWriter.ToString();
        output.Should().Be(expectedOutput);
    }
    
    [Fact(DisplayName = "When player picks number one, then the number should be replaced with X")]
    public void SelectSquare_WhenPlayerPicksOne_ThenTheNumberShouldBeReplacedWithX()
    {
        const string expectedOutput = "==========\r\n X | 2 | 3 \r\n---+---+---\r\n 4 | 5 | 6 \r\n---+---+---\r\n 7 | 8 | 9 \r\n==========\r\n";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        TicTacToe.SelectSquare(1);
        
        TicTacToe.PrintBord();
        
        var output = stringWriter.ToString();
        output.Should().Be(expectedOutput);
    }
    
    [Fact(DisplayName = "When bot picks number one, then the number should be replaced with 0")]
    public void SelectSquare_WhenBotPicksOne_ThenTheNumberShouldBeReplacedWith0()
    {
        const string expectedOutput = "==========\r\n 0 | 2 | 3 \r\n---+---+---\r\n 4 | 5 | 6 \r\n---+---+---\r\n 7 | 8 | 9 \r\n==========\r\n";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        TicTacToe.SelectSquare(1, false);
        
        TicTacToe.PrintBord();
        
        var output = stringWriter.ToString();
        output.Should().Be(expectedOutput);
    }
}
