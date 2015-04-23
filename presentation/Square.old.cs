#region Public Methods

/// <summary>
/// Appends a list of moves of all the pieces that are attacking this square.
/// </summary>
/// <param name="moves">
/// Moves of pieces that are attacking this square.
/// </param>
/// <param name="player">
/// Player whose turn it is
/// </param>
public void AttackersMoveList(Moves moves, Player player)
{
    Piece piece;

    // Pawn
    piece = Board.GetPiece(this.Ordinal - player.PawnAttackLeftOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        moves.Add(
            0, 
            0, 
            Move.MoveNames.Standard, 
            Board.GetPiece(this.Ordinal - player.PawnAttackLeftOffset), 
            Board.GetSquare(this.Ordinal - player.PawnAttackLeftOffset), 
            this, 
            this.Piece, 
            0, 
            0);
    }

    piece = Board.GetPiece(this.Ordinal - player.PawnAttackRightOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        moves.Add(
            0, 
            0, 
            Move.MoveNames.Standard, 
            Board.GetPiece(this.Ordinal - player.PawnAttackRightOffset), 
            Board.GetSquare(this.Ordinal - player.PawnAttackRightOffset), 
            this, 
            this.Piece, 
            0, 
            0);
    }

    // Knight
    piece = Board.GetPiece(this.Ordinal + 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal + 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal + 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal + 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    // Bishop & Queen
    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 15)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 17)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -15)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -17)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    // Rook & Queen
    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 1)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -1)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 16)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -16)) != null)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    // King!
    piece = Board.GetPiece(this.Ordinal + 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal + 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal + 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal - 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }

    piece = Board.GetPiece(this.Ordinal + 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        moves.Add(0, 0, Move.MoveNames.Standard, piece, piece.Square, this, this.Piece, 0, 0);
    }
}

/// <summary>
/// Returns a list of player's pieces attacking this square.
/// </summary>
/// <param name="player">
/// Player who owns the attacking pieces that you want to find.
/// </param>
/// <returns>
/// List of pieces.
/// </returns>
public Pieces PlayersPiecesAttackingThisSquare(Player player)
{
    Piece piece;
    Pieces pieces = new Pieces();

    // Pawn
    piece = Board.GetPiece(this.Ordinal - player.PawnAttackLeftOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - player.PawnAttackRightOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    // Knight
    piece = Board.GetPiece(this.Ordinal + 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal + 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal + 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal + 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    // Bishop & Queen
    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 15)) != null)
    {
        pieces.Add(piece);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 17)) != null)
    {
        pieces.Add(piece);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -15)) != null)
    {
        pieces.Add(piece);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -17)) != null)
    {
        pieces.Add(piece);
    }

    // Rook & Queen
    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 1)) != null)
    {
        pieces.Add(piece);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -1)) != null)
    {
        pieces.Add(piece);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 16)) != null)
    {
        pieces.Add(piece);
    }

    if ((piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -16)) != null)
    {
        pieces.Add(piece);
    }

    // King!
    piece = Board.GetPiece(this.Ordinal + 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal + 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal + 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal - 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    piece = Board.GetPiece(this.Ordinal + 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        pieces.Add(piece);
    }

    return pieces;
}

/// <summary>
/// Determines whether the specified player can attack this square.
/// </summary>
/// <param name="player">
/// The player being tested.
/// </param>
/// <returns>
/// True if player can move a piece to this square.
/// </returns>
public bool PlayerCanAttackSquare(Player player)
{
    Piece piece;

    // Pawn
    piece = Board.GetPiece(this.Ordinal - player.PawnAttackLeftOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - player.PawnAttackRightOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    // Knight
    piece = Board.GetPiece(this.Ordinal + 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal + 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal + 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal + 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    // Bishop & Queen
    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 15) != null)
    {
        return true;
    }

    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 17) != null)
    {
        return true;
    }

    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -15) != null)
    {
        return true;
    }

    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -17) != null)
    {
        return true;
    }

    // Rook & Queen
    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 1) != null)
    {
        return true;
    }

    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -1) != null)
    {
        return true;
    }

    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 16) != null)
    {
        return true;
    }

    if (Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -16) != null)
    {
        return true;
    }

    // King!
    piece = Board.GetPiece(this.Ordinal + 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal + 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal + 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal - 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    piece = Board.GetPiece(this.Ordinal + 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return true;
    }

    return false;
}

/// <summary>
/// Calculates defense points for the player on this square. Returns the value of the cheapest piece defending the square.
/// If no pieces are defending, then returns a high value (15,000).
/// </summary>
/// <param name="player">
/// The defending player.
/// </param>
/// <returns>
/// Defense points.
/// </returns>
public int DefencePointsForPlayer(Player player)
{
    Piece piece;
    int value = 0;
    int bestValue = 0;

    // Pawn
    piece = Board.GetPiece(this.Ordinal - player.PawnAttackLeftOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - player.PawnAttackRightOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    // Knight
    piece = Board.GetPiece(this.Ordinal + 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal + 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal + 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal + 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    // Bishop & Queen
    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 15);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 17);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -15);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -17);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    // Rook & Queen
    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 1);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -1);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 16);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -16);
    value = piece != null ? piece.Value : 0;
    if (value > 0 && value < 9000)
    {
        return value;
    }

    if (value > 0)
    {
        bestValue = value;
    }

    if (bestValue > 0)
    {
        return bestValue; // This means a queen was found, but not a Bishop or Rook
    }

    // King!
    piece = Board.GetPiece(this.Ordinal + 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal + 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal + 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal - 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    piece = Board.GetPiece(this.Ordinal + 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece.Value;
    }

    return 15000;
}

/// <summary>
/// Gets the cheapest piece defending this square.
/// </summary>
/// <param name="player">
/// Defending player who pieces should be listed.
/// </param>
/// <returns>
/// List of pieces.
/// </returns>
public Piece CheapestPieceDefendingThisSquare(Player player)
{
    Piece piece;
    Piece pieceBest = null;

    // Pawn
    piece = Board.GetPiece(this.Ordinal - player.PawnAttackLeftOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - player.PawnAttackRightOffset);
    if (piece != null && piece.Name == Piece.PieceNames.Pawn && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    // Knight
    piece = Board.GetPiece(this.Ordinal + 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal + 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 33);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 18);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal + 14);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal + 31);
    if (piece != null && piece.Name == Piece.PieceNames.Knight && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    // Bishop & Queen
    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 15);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Bishop:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, 17);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Bishop:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -15);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Bishop:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Bishop, this, -17);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Bishop:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    // Rook & Queen
    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 1);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Rook:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -1);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Rook:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, 16);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Rook:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    piece = Board.LinesFirstPiece(player.Colour, Piece.PieceNames.Rook, this, -16);
    if (piece != null)
    {
        switch (piece.Name)
        {
            case Piece.PieceNames.Rook:
                return piece;
            case Piece.PieceNames.Queen:
                pieceBest = piece;
                break;
        }
    }

    if (pieceBest != null)
    {
        return pieceBest; // This means a queen was found, but not a Bishop or Rook
    }

    // King!
    piece = Board.GetPiece(this.Ordinal + 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal + 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal + 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 16);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 17);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal - 1);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    piece = Board.GetPiece(this.Ordinal + 15);
    if (piece != null && piece.Name == Piece.PieceNames.King && piece.Player.Colour == player.Colour)
    {
        return piece;
    }

    return null;
}

#endregion