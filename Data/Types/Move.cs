namespace BoardWatcher.Data
{
    public class Move
    {
        public Move(int pieceId, int fromField, int toField)
        {
            this.pieceId = pieceId;
            this.fromField = fromField;
            this.toField = toField;
        }

        public int pieceId { get; set; }
        public int fromField { get; set; }

        public int toField { get; set; }
    }
}
