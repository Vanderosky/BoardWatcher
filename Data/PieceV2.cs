using System;
using System.Linq;
using System.Threading.Tasks;

namespace BoardWatcher.Data
{
    public class PieceV2
    {
        public PieceV2(int id, Boolean colour)
        {
            this.Id = id;
            this.Color = colour;
        }

        public int Id { get; set; }
        public Boolean Color { get; set; }
    }
}
