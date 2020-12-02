using DAV_Tarea4.Models;
using DAV_Tarea4.Proxy;
using System;

namespace DAV_Tarea4.Pieces
{
    public class Pawn : IPieceProxy
    {
        public void ProcessMovement(Movement movement, Piece[,] board)
        {
            Piece originContent = board[movement.OriginCell.Row.Value, movement.OriginCell.Column.Value];
            Piece destinationContent = board[movement.DestinationCell.Row.Value, movement.DestinationCell.Column.Value];

            int deltaRow = Math.Abs(movement.DestinationCell.Row.Value - movement.OriginCell.Row.Value);
            int deltaColumn = Math.Abs(movement.DestinationCell.Column.Value - movement.OriginCell.Column.Value);

            if(destinationContent != null)
            {
                throw new Exception("Movimiento inválido para peón. Pieza en celda destino.");
            }

            if (deltaColumn != 0)
            {
                throw new Exception("Movimiento inválido para peón. Solo movimiento vertical.");
            }

            if (deltaRow > 2)
            {
                throw new Exception("Movimiento inválido para peón. No puede moverse mas de 2 casillas verticalmente.");
            }

            if (originContent.Color == Color.White
                && deltaRow == 2
                && movement.OriginCell.Row.Value != 6)
            {
                throw new Exception("Movimiento inválido para peón. Solo puede mover 2 casillas al comienzo.");
            }

            if (originContent.Color == Color.Black
                && deltaRow == 2
                && movement.OriginCell.Row.Value != 1)
            {
                throw new Exception("Movimiento inválido para peón. Solo puede mover 2 casillas al comienzo.");
            }

            if (originContent.Color == Color.White
                && deltaRow == 2
                && movement.OriginCell.Row.Value == 6
                && board[5, movement.OriginCell.Column.Value] != null)
            {
                throw new Exception("Movimiento inválido para peón. Pieza en camino.");
            }

            if (originContent.Color == Color.Black
                && deltaRow == 2
                && movement.OriginCell.Row.Value == 1
                && board[2, movement.OriginCell.Column.Value] != null)
            {
                throw new Exception("Movimiento inválido para peón. Pieza en camino.");
            }
        }
    }
}
