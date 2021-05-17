using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BoardWatcher.Data
{

    public class PieceCV
    {
        public PieceCV(int id, Boolean colour)
        {
            this.Id = id;
            this.Color = colour;
        }

        public int Id { get; set; }
        public Boolean Color { get; set; }
    }

    public class ChessGameState
    {
        public List<PieceCV> Board { get; set; }
    }
}
