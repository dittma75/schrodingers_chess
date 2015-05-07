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

        /// <summary>
        /// Concealed moveset offsets:
        /// +/- 1 is the right/left move
        /// 15,16, and 17 are the up-left, up, and up-right moves
        /// -15,-16, and -17 are the down-left, down, and down-right moves
        /// These move numbers represent all moves one square from the piece.
        /// The two-square moves are dependent on the results of the first
        /// move, and are found by doubling the offset.
        /// </summary>
        private static readonly int[] CONCEALED_OFFSETS = { -1, 1, -15, 15, -16, 16, -17, 17 };

        /// <summary>
        /// The piece that this Concealed piece represents and will become
        /// when it is revealed.
        /// </summary>
        private IPieceTop revealed_piece_top;

        /// <summary>
        /// The ID of the piece to keep the FEN happy
        /// </summary>
        public Piece.PieceIdentifierCodes identifier;
        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Makes a new concealed piece with information about the piece it will be.
        /// </summary>
        /// <param name="pieceBase">
        ///     The base of the piece used for
        ///     book-keeping on the board
        /// </param>
        /// <param name="revealed_piece_top">The real type of the piece.</param>
        /// <param name="identifier">The identifier for the real piece.</param>
        public Concealed(Piece pieceBase, IPieceTop revealed_piece_top, Piece.PieceIdentifierCodes identifier)
        {
            this.Base = pieceBase;
            this.revealed_piece_top = revealed_piece_top;
            this.identifier = identifier;
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
        /// A concealed piece is stronger than a bishop, but not nearly as
        /// strong as a queen.  Similiar strength to a rook seems to be a good
        /// compromise.
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
                return this.Base.Player.Colour == Player.PlayerColourNames.White ? 13 : 12;
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

        /// <summary>
        /// Gets the positional points assigned to this piece.
        /// </summary>
        public int PositionalPoints
        {
            get
            {
                int intPoints = 0;

                /* After the opening, Concealed pieces are penalized slightly depending
                    * on "taxicab" distance to the enemy king.
                    */
                if (Game.Stage != Game.GameStageNames.Opening)
                {
                    intPoints -= this.Base.TaxiCabDistanceToEnemyKingPenalty();
                }

                // Mobility
                Squares squares = new Squares();
                squares.Add(this.Base.Square);
                AddThreatenedSquares(this.Base.Square, squares);
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
            switch (movesType)
            {
                case Moves.MoveListNames.All:
                    /* Adds each Concealed piece one-square move and, if
                        * possible, its two-square move to the move list.
                        */
                    foreach (int offset in CONCEALED_OFFSETS)
                    {
                        AddMovePair(moves, offset);
                    }
                    AddRevealMove(moves);
                    break;
                default:
                    break;
            } 
        }

        /// <summary>
        /// Reveals the concealed piece as what it actually is.
        /// </summary>
        public void revealPiece()
        {
            //To reveal this piece, we just have to switch out the piece top.
            this.Base.Top = revealed_piece_top;
        }

        /// <summary>
        ///     Add a reveal move to the move list if it is lucrative to do so.
        /// </summary>
        /// <param name="moves">The list that a RevealMove will be on.</param>
        public void AddRevealMove(Moves moves)
        {
            /* Make revealing the concealed piece an option if it's
             * in a good spot or it's a queen.
             */
            if ((this.revealed_piece_top.PositionalPoints >
                 this.PositionalPoints * 2) ||
                this.revealed_piece_top.Abbreviation.Equals("Q"))
            {
                moves.Add(Game.TurnNo,
                          this.Base.LastMoveTurnNo,
                          Model.Move.MoveNames.RevealMove,
                          this.Base,            //Piece affected
                          this.Base.Square,     //Start square
                          this.Base.Square,     //End square
                          null,                 //Piece to be captured
                          0,
                          0);
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Adds a set of moves for one space and two spaces forward to the
        /// moves list in the positive and negative directions of the
        /// offset starting from the location of the piece.
        /// </summary>
        /// <param name="moves">moves list to add the move to</param>
        /// <param name="offset">direction of move (See CONCEALED_OFFSETS)</param>
        private void AddMovePair(Moves moves, int offset)
        {
            Square first_move_square = Board.GetSquare(this.Base.Square.Ordinal + offset);
            AddMove(first_move_square, moves);
            //If the first move square is valid and has no piece
            if (first_move_square != null && first_move_square.Piece == null)
            {
                AddMove(Board.GetSquare(first_move_square.Ordinal + offset), moves);
            }   
        }
        /// <summary>
        /// Verifies the move to be added and, if valid, adds it.
        /// </summary>
        /// <param name="square">The square that the piece could move to.</param>
        /// <param name="moves">The moves list to add the move to.</param>
        private void AddMove(Square square, Moves moves)
        {
            if (square != null &&
                (square.Piece == null ||
                (square.Piece.Player.Colour != this.Base.Player.Colour && square.Piece.IsCapturable)))
            {
                moves.Add(0, 0, Move.MoveNames.Standard, this.Base, this.Base.Square, square, square.Piece, 0, 0);
            }
        }

        /// <summary>
        ///     Add squares that are threatened by this concealed piece to 
        ///     the list of threatened squares.
        /// </summary>
        /// <param name="start_square">The square where the piece is.</param>
        /// <param name="squares">
        ///     The list of squares threatened by the piece at start_square.
        /// </param>
        private void AddThreatenedSquares(Square start_square, Squares squares)
        {
            foreach (int offset in CONCEALED_OFFSETS)
            {
                int ordinal = start_square.Ordinal;
                Square square = Board.GetSquare(ordinal + offset);
                if (square != null)
                {
                    /* If the square is unoccupied or is occupied by a
                     * capturable enemy piece, add it to the list.
                     */
                    if (square.Piece == null ||
                        (square.Piece.Player.Colour != this.Base.Player.Colour && 
                         square.Piece.IsCapturable))
                    {
                        squares.Add(square);
                        /* First square was successfully added, let's try the
                         * concealed piece's second square move.
                         */
                        square = Board.GetSquare(ordinal + 2 * offset);
                        if (square != null)
                        {
                            if (square.Piece == null ||
                                (square.Piece.Player.Colour != this.Base.Player.Colour &&
                                 square.Piece.IsCapturable))
                            {
                                squares.Add(square);
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}