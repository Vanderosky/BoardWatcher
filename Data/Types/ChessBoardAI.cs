using System.Collections.Generic;
public class PieceAI
{
    public string place { get; set; }
    public string piece { get; set; }
}

public class ChessBoardAI
{
    public List<PieceAI> pieces { get; set; }
}
