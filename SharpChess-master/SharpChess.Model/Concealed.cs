// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Concealed.cs" author="Kevin Dittmar">
// </copyright>
// <summary>
//   The concealed piece.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region License

// SharpChess
// Copyright (C) 2012 SharpChess.com
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
#endregion

namespace SharpChess.Model
{
    /// <summary>
    /// A concealed piece top.
    /// </summary>
    public class Concealed : IPieceTop
    {
        #region Constants and Fields

        /// <summary>
        /// Simple positional piece-square score values.
        /// </summary>
        //No idea what to do with this right now.
        private static readonly int[] SquareValues =
        {
            1, 1,  1,  1,  1,  1, 1, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 7,  7,  7,  7,  7, 7, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 7, 18, 18, 18, 18, 7, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 7, 18, 27, 27, 18, 7, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 7, 18, 27, 27, 18, 7, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 7, 18, 18, 18, 18, 7, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 7,  7,  7,  7,  7, 7, 1,   0, 0, 0, 0, 0, 0, 0, 0, 
            1, 1,  1,  1,  1,  1, 1, 1,   0, 0, 0, 0, 0, 0, 0, 0
        };

        private IPieceTop revealed_piece_top;
        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Concealed"/> class.
        /// </summary>
        /// <param name="pieceBase">
        /// Base part of the piece.
        /// </param>
        public Concealed(Piece pieceBase, IPieceTop revealed_piece_top)
        {
            this.Base = pieceBase;
            this.revealed_piece_top = revealed_piece_top;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Abbreviation.
        /// </summary>
        public string Abbreviation
        {
            get
            {
                return "?";
            }
        }

        /// <summary>
        /// Gets the base part of the piece. i.e. the bit that sits on the chess square.
        /// </summary>
        public Piece Base { get; private set; }

        /// <summary>
        /// Gets basic value of the piece. e.g. pawn = 1, bishop = 3, queen = 9
        /// </summary>
        public int BasicValue
        {
            get
            {
                return revealed_piece_top.BasicValue;
            }
        }

        /// <summary>
        /// Gets the image index for this piece. Used to determine which graphic image is displayed for thie piece.
        /// </summary>
        public int ImageIndex
        {
            get
            {
                return this.Base.Player.Colour == Player.PlayerColourNames.White ? 3 : 2;
//                return this.Base.Player.Colour == Player.PlayerColourNames.White ? 13 : 12;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the piece is capturable. Kings aren't, everything else is.
        /// </summary>
        public bool IsCapturable
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets the piece's name.
        /// </summary>
        public Piece.PieceNames Name
        {
            get
            {
                return Piece.PieceNames.Concealed;
            }
        }
        /*No idea what to do with this yet*/
                /// <summary>
                /// Gets the positional points assigned to this piece.
                /// </summary>
                public int PositionalPoints
                {
                    get
                    {
                        int intPoints = 0;

                        intPoints += SquareValues[this.Base.Square.Ordinal] << 1;

                        if (Game.Stage != Game.GameStageNames.End)
                        {
                            if (this.Base.CanBeDrivenAwayByPawn())
                            {
                                intPoints -= 30;
                            }
                        }

                        // Mobility
                        Squares squares = new Squares();
                        squares.Add(this.Base.Square);
                        Board.LineThreatenedBy(this.Base.Player, squares, this.Base.Square, 15);
                        Board.LineThreatenedBy(this.Base.Player, squares, this.Base.Square, 17);
                        Board.LineThreatenedBy(this.Base.Player, squares, this.Base.Square, -15);
                        Board.LineThreatenedBy(this.Base.Player, squares, this.Base.Square, -17);
                        int intSquareValue = 0;
                        foreach (Square square in squares)
                        {
                            intSquareValue += SquareValues[square.Ordinal];
                        }

                        intPoints += intSquareValue >> 2;

                        intPoints += this.Base.DefensePoints;

                        return intPoints;
                    }
                }
/*        */
        /// <summary>
        /// Gets the material value of this piece.
        /// </summary>
        public int Value
        {
            get
            {
                return revealed_piece_top.Value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Generate "lazy" moves for this piece, which is all usual legal moves, but also includes moves that put the king in check.
        /// </summary>
        /// <param name="moves">
        /// Moves list that will be populated with lazy moves.
        /// </param>
        /// <param name="movesType">
        /// Types of moves to include. e.g. All, or captures-only.
        /// </param>
        public void GenerateLazyMoves(Moves moves, Moves.MoveListNames movesType)
        {
            Board.AppendPiecePath(moves, this.Base, this.Base.Player, 17, movesType);
            Board.AppendPiecePath(moves, this.Base, this.Base.Player, 15, movesType);
            Board.AppendPiecePath(moves, this.Base, this.Base.Player, -15, movesType);
            Board.AppendPiecePath(moves, this.Base, this.Base.Player, -17, movesType);
        }

        /// <summary>
        /// Reveals the concealed piece as what it actually is.
        /// </summary>
        public void revealPiece()
        {
            //Add this piece's hidden_piece_type to this player's Pieces list at this piece's Square
            //Remove this piece from player's Pieces
        }
        #endregion
    }
}