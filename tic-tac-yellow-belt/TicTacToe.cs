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
        var row = (i - 1) / 3;
        var col = (i - 1) % 3;
        
        if (isPlayer)
        {
            Board[row, col] = PlayerMark;
            return;
        }

        Board[row, col] = BotMark;
    }

    public static int BotMove()
    {
        var canMakeMove = false;
        var botPosition = 0;

        while (!canMakeMove)
        {
            botPosition = new Random().Next(1, 10);

            var row = (botPosition - 1) / 3;
            var col = (botPosition - 1) % 3;
            
            if(Board[row, col] != PlayerMark)
            {
                canMakeMove = true;
            }
        }

        return botPosition;
    }
}