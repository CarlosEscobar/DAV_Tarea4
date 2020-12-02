using DAV_Tarea4.Models;

namespace DAV_Tarea4.Tests
{
    public class TestBase
    {
        public Piece[,] chessBoard = new Piece[,]
        {
            { null, null, null, null, null, null, null, new Piece{ Color = Color.White, Type = Models.Type.Rook} },
            { null, null, new Piece{ Color = Color.Black, Type = Models.Type.Pawn}, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, new Piece{ Color = Color.White, Type = Models.Type.Knight}, null, null, null, null, null, new Piece{ Color = Color.White, Type = Models.Type.Rook} },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
        };
    }
}
