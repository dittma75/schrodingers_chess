// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerBlack.cs" company="SharpChess.com">
//   SharpChess.com
// </copyright>
// <summary>
//   The player black.
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
    /// The player black.
    /// </summary>
    public class PlayerBlack : Player
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerBlack"/> class.
        /// </summary>
        public PlayerBlack(int[] black_order)
        {
            this.Colour = PlayerColourNames.Black;
            //Computer players don't have a specified order; it is randomly generated.
            if (black_order == null)
            {
                this.Intellegence = PlayerIntellegenceNames.Computer;
            }
            //If an order was specified, the player is human.
            else
            {
                this.Intellegence = PlayerIntellegenceNames.Human;
            }

            this.SetPiecesAtStartingPositions(black_order);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets PawnAttackLeftOffset.
        /// </summary>
        public override int PawnAttackLeftOffset
        {
            get
            {
                return -17;
            }
        }

        /// <summary>
        /// Gets PawnAttackRightOffset.
        /// </summary>
        public override int PawnAttackRightOffset
        {
            get
            {
                return -15;
            }
        }

        /// <summary>
        /// Gets PawnForwardOffset.
        /// </summary>
        public override int PawnForwardOffset
        {
            get
            {
                return -16;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The set pieces at starting positions.
        /// </summary>
        protected override sealed void SetPiecesAtStartingPositions(int[] order)
        {
            //The King and Pawns are not concealed.
            this.Pieces.Add(this.King = new Piece(Piece.PieceNames.King, this, 4, 7, Piece.PieceIdentifierCodes.BlackKing));

            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 0, 6, Piece.PieceIdentifierCodes.BlackPawn1));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 1, 6, Piece.PieceIdentifierCodes.BlackPawn2));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 2, 6, Piece.PieceIdentifierCodes.BlackPawn3));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 3, 6, Piece.PieceIdentifierCodes.BlackPawn4));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 4, 6, Piece.PieceIdentifierCodes.BlackPawn5));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 5, 6, Piece.PieceIdentifierCodes.BlackPawn6));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 6, 6, Piece.PieceIdentifierCodes.BlackPawn7));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 7, 6, Piece.PieceIdentifierCodes.BlackPawn8));

            //The Queen, Rooks, Bishops, and Knights are all concealed.
            Piece.PieceIdentifierCodes[] ids = new Piece.PieceIdentifierCodes[7];
            ids[0] = Piece.PieceIdentifierCodes.BlackQueensRook;
            ids[1] = Piece.PieceIdentifierCodes.BlackQueensKnight;
            ids[2] = Piece.PieceIdentifierCodes.BlackQueensBishop;
            ids[3] = Piece.PieceIdentifierCodes.BlackQueen;
            ids[4] = Piece.PieceIdentifierCodes.BlackKingsBishop;
            ids[5] = Piece.PieceIdentifierCodes.BlackKingsKnight;
            ids[6] = Piece.PieceIdentifierCodes.BlackKingsRook;

            //Arrange and place the concealed pieces.
            addArrangedPieces(order, ids);
        }
        #endregion
    }
}