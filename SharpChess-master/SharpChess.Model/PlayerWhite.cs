// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerWhite.cs" company="SharpChess.com">
//   SharpChess.com
// </copyright>
// <summary>
//   The player white.
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
    /// The player white.
    /// </summary>
    public class PlayerWhite : Player
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerWhite"/> class.
        /// </summary>
        public PlayerWhite(int[] order)
        {
            this.Colour = PlayerColourNames.White;
            if (order == null)
            {
                generateRandomOrder();
                this.Intellegence = PlayerIntellegenceNames.Computer;
            }
            else
            {
                this.Intellegence = PlayerIntellegenceNames.Human;
            }

            this.SetPiecesAtStartingPositions(order);
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
                return 15;
            }
        }

        /// <summary>
        /// Gets PawnAttackRightOffset.
        /// </summary>
        public override int PawnAttackRightOffset
        {
            get
            {
                return 17;
            }
        }

        /// <summary>
        /// Gets PawnForwardOffset.
        /// </summary>
        public override int PawnForwardOffset
        {
            get
            {
                return 16;
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
            this.Pieces.Add(this.King = new Piece(Piece.PieceNames.King, this, 4, 0, Piece.PieceIdentifierCodes.WhiteKing));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 0, 1, Piece.PieceIdentifierCodes.WhitePawn1));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 1, 1, Piece.PieceIdentifierCodes.WhitePawn2));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 2, 1, Piece.PieceIdentifierCodes.WhitePawn3));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 3, 1, Piece.PieceIdentifierCodes.WhitePawn4));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 4, 1, Piece.PieceIdentifierCodes.WhitePawn5));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 5, 1, Piece.PieceIdentifierCodes.WhitePawn6));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 6, 1, Piece.PieceIdentifierCodes.WhitePawn7));
            this.Pieces.Add(new Piece(Piece.PieceNames.Pawn, this, 7, 1, Piece.PieceIdentifierCodes.WhitePawn8));


            //The Queen, Rooks, Bishops, and Knights are all concealed.
            Piece.PieceIdentifierCodes[] ids = new Piece.PieceIdentifierCodes[7];
            ids[0] = Piece.PieceIdentifierCodes.WhiteQueensRook;
            ids[1] = Piece.PieceIdentifierCodes.WhiteQueensKnight;
            ids[2] = Piece.PieceIdentifierCodes.WhiteQueensBishop;
            ids[3] = Piece.PieceIdentifierCodes.WhiteQueen;
            ids[4] = Piece.PieceIdentifierCodes.WhiteKingsBishop;
            ids[5] = Piece.PieceIdentifierCodes.WhiteKingsKnight;
            ids[6] = Piece.PieceIdentifierCodes.WhiteKingsRook;

            //Arrange and place the concealed pieces.
            addArrangedPieces(order, ids);
        }

        private void generateRandomOrder()
        {
            //stub
        }
        #endregion
    }
}