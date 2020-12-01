using DAV_Tarea4.Models;

namespace DAV_Tarea4.Proxy
{
    interface IPieceProxy
    {
        void ProcessMovement(Movement movement, Piece[,] board);
    }
}