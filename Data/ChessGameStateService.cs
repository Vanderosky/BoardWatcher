using System.Linq;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System;

namespace BoardWatcher.Data
{
    public class ChessGameStateService
    {
        CancellationTokenSource disposalTokenSource = new CancellationTokenSource();
        ClientWebSocket webSocket = new ClientWebSocket();
        public string message = "Hello, websocket!";
        public string log = "";
        public ChessGameState gameState = new ChessGameState();
        public Piece[] generateNewBoard()
        {
            Piece[] pieces = new Piece[64];
            Piece[] blackPieces = new Piece[]
            {
                new Piece(2, false),
                new Piece(3, false),
                new Piece(4, false),
                new Piece(5, false),
                new Piece(6, false),
                new Piece(4, false),
                new Piece(3, false),
                new Piece(2, false),

                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false)
            };
            Piece[] whitePieces = new Piece[]
            {
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),

                new Piece(2, true),
                new Piece(3, true),
                new Piece(4, true),
                new Piece(5, true),
                new Piece(6, true),
                new Piece(4, true),
                new Piece(3, true),
                new Piece(2, true)
            };
            blackPieces.CopyTo(pieces, 0);
            for (int i = 16; i < 48; i++)
            {
                pieces[i] = new Piece(0, false);
            }
            whitePieces.CopyTo(pieces, 48);
            return pieces;
        }
        public Task<Piece[]> GetPieceData()
        {
            Piece[] pieces = new Piece[64];
            pieces = generateNewBoard();
            return Task.FromResult(pieces.ToArray());
        }

        protected async Task OnInitializedAsync()
        {
            await webSocket.ConnectAsync(new Uri("127.0.0.1:8181"), disposalTokenSource.Token);
            _ = ReceiveLoop();
        }

        async Task ReceiveLoop()
        {
            var buffer = new ArraySegment<byte>(new byte[1024]);
            while (!disposalTokenSource.IsCancellationRequested)
            {
                // Note that the received block might only be part of a larger message. If this applies in your scenario,
                // check the received.EndOfMessage and consider buffering the blocks until that property is true.
                // Or use a higher-level library such as SignalR.
                var received = await webSocket.ReceiveAsync(buffer, disposalTokenSource.Token);
                var receivedAsText = Encoding.UTF8.GetString(buffer.Array, 0, received.Count);
                log += $"Received: {receivedAsText}\n";
                Console.WriteLine("Received: ", log);
            }
        }

        public void Dispose()
        {
            disposalTokenSource.Cancel();
            _ = webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bye", CancellationToken.None);
        }

    public string GetPiece(int tileId)
    {
        Piece tmpPiece = this.gameState.Board[tileId];
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
