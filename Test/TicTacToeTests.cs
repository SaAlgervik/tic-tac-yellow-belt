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
    
    [Fact(DisplayName = "When player picks a number between 1-9, then the number should not be replaced with X")]
    public void SelectSquare_WhenPlayerPicksNumberBetweenOneAndNine_ThenTheNumberShouldBeReplacedWithX()
    {
        const string expectedOutput = "==========\r\n X | X | X \r\n---+---+---\r\n X | X | X \r\n---+---+---\r\n X | X | X \r\n==========\r\n";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        TicTacToe.SelectSquare(1);
        TicTacToe.SelectSquare(2);
        TicTacToe.SelectSquare(3);
        TicTacToe.SelectSquare(4);
        TicTacToe.SelectSquare(5);
        TicTacToe.SelectSquare(6);
        TicTacToe.SelectSquare(7);
        TicTacToe.SelectSquare(8);
        TicTacToe.SelectSquare(9);
        
        TicTacToe.PrintBord();
        
        var output = stringWriter.ToString();
        output.Should().Be(expectedOutput);
    }
    
        
    [Fact(DisplayName = "When bot picks a number between 1-9, then the number should not be replaced with 0")]
    public void SelectSquare_WhenBotPicksNumberBetweenOneAndNine_ThenTheNumberShouldBeReplacedWith0()
    {
        const string expectedOutput = "==========\r\n 0 | 0 | 0 \r\n---+---+---\r\n 0 | 0 | 0 \r\n---+---+---\r\n 0 | 0 | 0 \r\n==========\r\n";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        TicTacToe.SelectSquare(1, false);
        TicTacToe.SelectSquare(2, false);
        TicTacToe.SelectSquare(3, false);
        TicTacToe.SelectSquare(4, false);
        TicTacToe.SelectSquare(5, false);
        TicTacToe.SelectSquare(6, false);
        TicTacToe.SelectSquare(7, false);
        TicTacToe.SelectSquare(8, false);
        TicTacToe.SelectSquare(9, false);
        
        TicTacToe.PrintBord();
        
        var output = stringWriter.ToString();
        output.Should().Be(expectedOutput);
    }
    
    
    
    [Fact(DisplayName = "When bot turn, then the bot should pick between one and nine")]
    public void BotMove_WhenBotTurn_ShouldPickBetweenOneAndNine()
    {
        var botTurn = TicTacToe.BotMove();

        botTurn.Should().BeInRange(1, 9);
    }
 
}
