/// <summary>
/// The user clicked a piece on the board to move it or
/// try to reveal it.
/// </summary>
/// <param name="sender">
/// The sending picture square (representation of a piece).
/// </param>
/// <param name="e">
/// The mouse event.
/// </param>
private void picSquare_MouseDown(object sender, MouseEventArgs e)
{
    if (this.m_blnInMouseDown)
    {
        return;
    }

    if (Game.PlayerToPlay.Brain.IsThinking && !Game.PlayerToPlay.Brain.IsPondering)
    {
        return;
    }

    this.m_blnIsLeftMouseButtonDown = true;
    this.m_blnInMouseDown = true;

    Game.SuspendPondering();

    PictureBox picFrom = (PictureBox)sender;

    int intOrdinalFrom = Convert.ToInt32(picFrom.Tag);

    Square squareFrom = Board.GetSquare(intOrdinalFrom);

    Piece pieceFrom = squareFrom.Piece;
    if (pieceFrom != null && pieceFrom.Player.Colour == Game.PlayerToPlay.Colour)
    {
        picFrom.Image = null;
        picFrom.Refresh();

        this.m_curPieceCursor = this.GetPieceCursor(pieceFrom);
        this.pnlEdging.Cursor = this.m_curPieceCursor;

        // Mark possible moves
        this.m_squareFrom = squareFrom;
        this.m_squareTo = null;
        this.m_movesPossible = new Moves();
        pieceFrom.GenerateLegalMoves(this.m_movesPossible);
        this.RenderBoardColours();
        this.pnlEdging.Refresh();

        Game.ResumePondering();

        //Right clicking a concealed piece reveals it.
        if (e.Button == MouseButtons.Right && pieceFrom.Name == Piece.PieceNames.Concealed)
        {
            Game.SuspendPondering();
            //Add the reveal move to the move list.
            this.m_movesPossible.Add(Game.TurnNo,
                                     pieceFrom.Base.LastMoveTurnNo,
                                     Model.Move.MoveNames.RevealMove,
                                     pieceFrom.Base,        //Piece affected
                                     pieceFrom.Base.Square, //Start square
                                     pieceFrom.Base.Square, //End square
                                     null,                  //Piece to be captured
                                     0,
                                     0
            );
            //Actually do the reveal move.
            Game.MakeAMove(Model.Move.MoveNames.RevealMove, pieceFrom, squareFrom);
            this.RenderBoardColours();
            Game.ResumePondering();
        }
        else if (this.m_blnIsLeftMouseButtonDown
            && ((PictureBox)sender).DoDragDrop(pieceFrom, DragDropEffects.Move) == DragDropEffects.Move)
        {
            Game.SuspendPondering();

            bool blnMoveMade = false;
            Piece pieceTo = this.m_squareTo.Piece;

            // Is it an empty space or enemy piece
            if (pieceTo == null || pieceTo != null && pieceTo.Player.Colour != Game.PlayerToPlay.Colour)
            {
                // Check to see it the move is valid, by comparing against all possible valid moves
                bool blnIsPromotion = false;
                Move.MoveNames movenamePromotion = Model.Move.MoveNames.NullMove;
                foreach (Move move in this.m_movesPossible)
                {
                    if (move.To == this.m_squareTo)
                    {
                        if (!blnIsPromotion)
                        {
                            switch (move.Name)
                            {
                                case Model.Move.MoveNames.PawnPromotionQueen:
                                case Model.Move.MoveNames.PawnPromotionRook:
                                case Model.Move.MoveNames.PawnPromotionBishop:
                                case Model.Move.MoveNames.PawnPromotionKnight:
                                    blnIsPromotion = true;
                                    frmPieceSelector formPieceSelector = new frmPieceSelector();
                                    formPieceSelector.Colour = move.Piece.Player.Colour;
                                    formPieceSelector.ShowDialog(this);
                                    movenamePromotion = formPieceSelector.MoveNameSelected;
                                    break;
                            }
                        }

                        if (!blnIsPromotion || move.Name == movenamePromotion)
                        {
                            this.m_squareFrom = null;
                            this.m_movesPossible = new Moves();

                            Game.MakeAMove(move.Name, move.Piece, move.To);
                            blnMoveMade = true;
                            break;
                        }
                    }
                }
            }

            if (!blnMoveMade)
            {
                this.m_picSquares[this.m_squareFrom.File, this.m_squareFrom.Rank].Image =
                    this.imgPieces.Images[this.m_squareFrom.Piece.ImageIndex];
                this.m_squareFrom = null;
                this.m_movesPossible = null;
                this.RenderBoardColours();
            }
        }
        else
        {
            Game.SuspendPondering();

            this.m_picSquares[this.m_squareFrom.File, this.m_squareFrom.Rank].Image =
                this.imgPieces.Images[this.m_squareFrom.Piece.ImageIndex];
            this.m_squareFrom = null;
            this.m_movesPossible = null;
            this.RenderBoardColours();

            Game.ResumePondering();
        }

        this.pnlEdging.Cursor = Cursors.Default;
    }
    else
    {
        Game.ResumePondering();
    }

    this.m_blnInMouseDown = false;
}