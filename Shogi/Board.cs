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
    /// Initializes the board with empty squares and sets up the initial piece placement for Shogi.
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


        // 先手の駒
        Squares[0, 0] = "香";
        Squares[1, 0] = "桂";
        Squares[2, 0] = "銀";
        Squares[3, 0] = "金";
        Squares[4, 0] = "王";
        Squares[5, 0] = "金";
        Squares[6, 0] = "銀";
        Squares[7, 0] = "桂";
        Squares[8, 0] = "香";
        Squares[1, 1] = "飛";
        Squares[7, 1] = "角";
        for (int i = 0; i < BoardSize; i++) Squares[i, 2] = "歩";

        // 後手の駒
        Squares[0, 8] = "香";
        Squares[1, 8] = "桂";
        Squares[2, 8] = "銀";
        Squares[3, 8] = "金";
        Squares[4, 8] = "玉";
        Squares[5, 8] = "金";
        Squares[6, 8] = "銀";
        Squares[7, 8] = "桂";
        Squares[8, 8] = "香";
        Squares[7, 7] = "飛";
        Squares[1, 7] = "角";
        for (int i = 0; i < BoardSize; i++) Squares[i, 6] = "歩";
    }
}
