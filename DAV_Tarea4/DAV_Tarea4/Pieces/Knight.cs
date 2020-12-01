using DAV_Tarea4.Models;
using DAV_Tarea4.Proxy;
using System;

namespace DAV_Tarea4.Pieces
{
    class Knight : IPieceProxy
    {
        public void ProcessMovement(Movement movement, Piece[,] board)
        {
            Piece originContent = board[movement.OriginCell.Row.Value, movement.OriginCell.Column.Value];
            Piece destinationContent = board[movement.DestinationCell.Row.Value, movement.DestinationCell.Column.Value];

            int deltaRow = Math.Abs(movement.DestinationCell.Row.Value - movement.OriginCell.Row.Value);
            int deltaColumn = Math.Abs(movement.DestinationCell.Column.Value - movement.OriginCell.Column.Value);

            if (destinationContent != null)
            {
                throw new Exception("Movimiento inválido para caballo. Pieza en celda destino.");
            }

            if (deltaRow > 2 || deltaRow == 0)
            {
                throw new Exception("Movimiento inválido para caballo. Solo movimiento en L.");
            }

            if (deltaColumn > 2 || deltaColumn == 0)
            {
                throw new Exception("Movimiento inválido para caballo. Solo movimiento en L.");
            }

            if (deltaRow == 2 && deltaColumn != 1)
            {
                throw new Exception("Movimiento inválido para caballo. Solo movimiento en L.");
            }

            if (deltaColumn == 2 && deltaRow != 1)
            {
                throw new Exception("Movimiento inválido para caballo. Solo movimiento en L.");
            }
        }
    }
}
