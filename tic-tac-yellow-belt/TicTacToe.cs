namespace tic_tac_yellow_belt;

public class TicTacToe
{
    private const char PlayerMark = 'X';
    private const char BotMark = '0';

    private static readonly char[,] Board =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    public static void PrintBord()
    {
        Console.WriteLine("==========");
        Console.WriteLine($" {Board[0, 0]} | {Board[0, 1]} | {Board[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {Board[1, 0]} | {Board[1, 1]} | {Board[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {Board[2, 0]} | {Board[2, 1]} | {Board[2, 2]} ");
        Console.WriteLine("==========");
    }

    public static void SelectSquare(int i, bool isPlayer = true)
    {
        if (isPlayer)
        {
            Board[0, i - 1] = PlayerMark;
            return;
        }

        Board[0, i - 1] = BotMark;
    }

    public static int BotMove()
    {
        return new Random().Next(1, 10);
    }
}