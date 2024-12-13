namespace tic_tac_yellow_belt;

public class TicTacToe
{
    private static char[,] _board =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };
    
    public bool Method1()
    {
        return true;
    }

    public static void PrintBord()
    {
        Console.WriteLine("==========");
        Console.WriteLine($" {_board[0, 0]} | {_board[0, 1]} | {_board[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {_board[1, 0]} | {_board[1, 1]} | {_board[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {_board[2, 0]} | {_board[2, 1]} | {_board[2, 2]} ");
        Console.WriteLine("==========");
    }
}
