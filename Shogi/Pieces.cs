using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shogi
{
    /// <summary>
    /// Represents the different types of pieces in a Shogi game.
    /// </summary>
    /// <remarks>This enumeration defines the standard and promoted piece types used in Shogi. Each value
    /// corresponds to a specific piece, including both unpromoted and promoted variants.</remarks>
    public enum PieceType
    {
        King,
        Rook,
        Bishop,
        GoldGeneral,
        SilverGeneral,
        Knight,
        Lance,
        Pawn,
        PromotedRook,
        PromotedBishop,
        PromotedSilver,
        PromotedKnight,
        PromotedLance
    }

    /// <summary>
    /// Represents the color of a game piece in a two-player board game.
    /// </summary>
    /// <remarks>This enumeration is typically used to distinguish between the two players or sides in a
    /// game.</remarks>
    public enum PieceColor
    {
        Black,
        White
    }

    /// <summary>
    /// Represents a chess piece with a specific type and color.
    /// </summary>
    /// <remarks>Instances of the <see cref="Pieces"/> class are immutable after creation. This class provides
    /// methods for comparing pieces and generating string representations.</remarks>
    class Pieces
    {
        public PieceType Type { get; private set; }
        public PieceColor Color { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pieces"/> class with the specified type and color.
        /// </summary>
        /// <param name="type">The type of the chess piece, such as King, Queen, or Pawn.</param>
        /// <param name="color">The color of the chess piece, typically White or Black.</param>
        public Pieces(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
        }

        /// <summary>
        /// Returns a string representation of the object, including its color and type.
        /// </summary>
        /// <returns>A string in the format "<c>{Color} {Type}</c>", where <c>Color</c> represents the object's color and
        /// <c>Type</c> represents its type.</returns>
        public override string ToString()
        {
            return $"{Color} {Type}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance. Can be <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the specified object is of type <c>Pieces</c> and has the same <c>Type</c> and
        /// <c>Color</c> values as the current instance; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Pieces other)
            {
                return Type == other.Type && Color == other.Color;
            }

            return false;
        }

        /// <summary>
        /// Generates a hash code for the current object based on its type and color.
        /// </summary>
        /// <remarks>The hash code is computed using the <see cref="System.HashCode.Combine"/> method, 
        /// which combines the hash codes of the <see cref="Type"/> and <see cref="Color"/> properties. This ensures a
        /// consistent and efficient hash code for use in hash-based collections.</remarks>
        /// <returns>An integer representing the hash code of the current object.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Color);
        }
    }
}
