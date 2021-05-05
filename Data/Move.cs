using System;
namespace BoardWatcher.Data
{
    public class Move
    {
        public Move(int fromField, int toField)
        {
            this.fromField = fromField;
            this.toField = toField;
        }

        public int fromField { get; set; }
        public int toField { get; set; }
    }
}
