using System.Linq;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System;
using Newtonsoft.Json;

namespace BoardWatcher.Data
{
    public class ChessGameStateService
    {
        public ChessGameState gameState = new ChessGameState();
        public PieceCV[] generateNewBoard()
        {
            PieceCV[] pieces = new PieceCV[64];
            PieceCV[] blackPieces = new PieceCV[]
            {
                new PieceCV(2, false),
                new PieceCV(3, false),
                new PieceCV(4, false),
                new PieceCV(5, false),
                new PieceCV(6, false),
                new PieceCV(4, false),
                new PieceCV(3, false),
                new PieceCV(2, false),

                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false)
            };
            PieceCV[] whitePieces = new PieceCV[]
            {
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),

                new PieceCV(2, true),
                new PieceCV(3, true),
                new PieceCV(4, true),
                new PieceCV(5, true),
                new PieceCV(6, true),
                new PieceCV(4, true),
                new PieceCV(3, true),
                new PieceCV(2, true)
            };
            blackPieces.CopyTo(pieces, 0);
            for (int i = 16; i < 48; i++)
            {
                pieces[i] = new PieceCV(0, false);
            }
            whitePieces.CopyTo(pieces, 48);
            return pieces;
        }
        public Task<PieceCV[]> GetPieceData()
        {
            PieceCV[] pieces = new PieceCV[64];
            pieces = generateNewBoard();
            return Task.FromResult(pieces.ToArray());
        }

        public PieceCV[] getPieceDataFromJson()
        {
           return System.Text.Json.JsonSerializer.Deserialize<PieceCV[]>("/piecesTest.json");
        }

    public string GetPiece(int tileId)
    {
        PieceCV tmpPiece = this.gameState.Board[tileId];
        if (tmpPiece.Color)
        {
            switch (tmpPiece.Id)
            {
                case 1:
                    return "♟";
                case 2:
                    return "♜";
                case 3:
                    return "♞";
                case 4:
                    return "♝";
                case 5:
                    return "♛";
                case 6:
                    return "♚";
                default:
                    return "";
            }
        }
        else
        {
            switch (tmpPiece.Id)
            {
                case 1:
                    return "♙";
                case 2:
                    return "♖";
                case 3:
                    return "♘";
                case 4:
                    return "♗";
                case 5:
                    return "♕";
                case 6:
                    return "♔";
                default:
                    return "";
            }
        }
    }
}
}
