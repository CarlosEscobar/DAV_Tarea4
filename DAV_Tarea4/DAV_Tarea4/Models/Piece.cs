namespace DAV_Tarea4.Models
{
    public enum Color
    {
        White,
        Black
    }

    public enum Type
    {
        Pawn,
        Rook, 
        Knight,
        Bishop,
        Queen,
        King
    }

    public class Piece
    {
        public Color Color { get; set; }
        public Type Type { get; set; }
    }
}
