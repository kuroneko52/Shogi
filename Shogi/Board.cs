using System;

public class Board
{
    public const int BoardSize = 9;
    public string[,] Squares { get; private set; } = new string[BoardSize, BoardSize];

    /// <summary>
    /// Initializes a new instance of the <see cref="Board"/> class.
    /// </summary>
    /// <remarks>This constructor creates a new board object with default settings. Use this constructor to
    /// instantiate a board before configuring its properties or adding elements.</remarks>
    public Board()
    {
        InitializeBoard();
    }

    /// <summary>
    /// Resets the board to its initial state.
    /// </summary>
    /// <remarks>This method clears all squares on the board, effectively resetting it to an empty state.</remarks>
    public void Reset()
    {
        InitializeBoard();
    }

    /// <summary>
    /// Initializes the board with empty squares.
    /// </summary>
    private void InitializeBoard()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                Squares[i, j] = string.Empty;
            }
        }
    }
}
