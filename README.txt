Kevin Dittmar
7 May 2015
Schrodinger's Chess README

    Schrodinger's Chess is a variant of chess whose engine was based on the
SharpChess engine (http://sharpchess.com/).  My contribution to this project was all
modification necessary for the existing SharpChess engine to be used as a suitable
engine for Schrodinger's Chess.  These modifications include small changes to the
engine's AI, addition of sprites for the concealed pieces, and addition of GUIs
for arranging the pieces at the game's start.

Playing Schrodinger's Chess:
    On startup, you will be prompted to select the difficulty for the Artificial
Intelligence.  This has no effect on a game between two human players.
    After selecting the difficulty, you will be prompted to select the arrangement
for the White pieces.  There is a picture of each of the seven pieces to be
concealed, and each one has a number select box under its picture.
    The number corresponds to the position of the piece at the back rank of
the player's side of the board from left to right.  For example, the leftmost
rook is usually at position 1, the leftmost knight is usually at position 2,
etc.
    These numbers can be changed however the player wishes, but there cannot
be duplicates of any number.  When you are finished selecting an arrangement,
click the "Select Order (Human)" button.  Submitting an order with duplicates
will result in an error, and the form will prompt you to fix it.  This prompt
should only be filled out for human players.  If the player is supposed to be
a computer player, then click the "Random Order (Computer)" button.  After
selecting the arrangement for the White pieces, a prompt to select the
arrangement for black pieces will appear.
    The game will now start.  To start a new game, click the "File->New Game"
option from the menu at the top of the screen.

Human Player Controls:
    Hold left click over the piece to be moved to pick it up.
    Move the piece over a highlighted square (legal move markers) and
    release left click to make a move.
    Right click a concealed piece to reveal it as the piece that it is.
Computer Player Instructions:
        When playing against a human player, the artificial intelligence player
    will automatically start its turn after the human takes a turn.  In the
    case that two computer players are playing, they will not automatically
    take turns in succession.  This is to prevent the computer players from
    racing through the game.
        To make the next computer player take its turn, press the "Think"
    button (the button with a Knight icon next to it) toward the end of the
    toolbar below the menu bar.
    
Schrodinger's Chess Rules (Variations from Standard Chess):
1.	All pieces except for each player’s King and Pawns are obscured at the
    start of the game.
2.	The obscured pieces act as their own class of piece, which is allowed
    to move one or two spaces horizontally, vertically, and diagonally as
    long as the path is not obstructed.
3.	Obscured pieces can be arranged within their starting zones in any way
    that they see fit at the start of the game.
4.	Obscured pieces can capture any other piece and can place the opposing
    piece in check, just like normal pieces can.
5.	Since pieces can be arranged in non-standard positions, the castling
    maneuver between Rooks and the King is not allowed because it makes
    no sense in Schrödinger’s Chess.
6.	Unlike castling, revealing a piece counts as the player’s move for the
    turn.
