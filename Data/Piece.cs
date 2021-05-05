using System;
using System.Linq;
using System.Threading.Tasks;

namespace BoardWatcher.Data
{
    public class Piece
    {
        public Piece(int id, Boolean colour)
        {
            this.Id = id;
            this.Color = colour;
        }

        public int Id { get; set; }
        public Boolean Color { get; set; }
    }
}
