using DAV_Tarea4.Models;
using DAV_Tarea4.Proxy;
using System;

namespace DAV_Tarea4.Pieces
{
    class Rook : IPieceProxy
    {
        public void ProcessMovement(Movement movement, Piece[,] board)
        {
            Piece originContent = board[movement.OriginCell.Row.Value, movement.OriginCell.Column.Value];
            Piece destinationContent = board[movement.DestinationCell.Row.Value, movement.DestinationCell.Column.Value];

            int deltaRow = movement.DestinationCell.Row.Value - movement.OriginCell.Row.Value;
            int deltaColumn = movement.DestinationCell.Column.Value - movement.OriginCell.Column.Value;

            if (destinationContent != null)
            {
                throw new Exception("Movimiento inválido para torre. Pieza en celda destino.");
            }

            if (deltaRow != 0 && deltaColumn != 0)
            {
                throw new Exception("Movimiento inválido para torre. Solo movimiento vertical o horizontal.");
            }

            int step = 1;
            int counter = 1;
            if(deltaRow == 0)
            {
                if (deltaColumn < 0) step = -1;
                while (counter < Math.Abs(deltaColumn)) {
                    if (board[movement.OriginCell.Row.Value, movement.OriginCell.Column.Value + step] != null)
                    {
                        throw new Exception("Movimiento inválido para torre. Pieza en camino.");
                    }
                    step += step;
                    counter++;
                }
            }
            else
            {
                if (deltaRow < 0) step = -1;
                while (counter < Math.Abs(deltaRow))
                {
                    if (board[movement.OriginCell.Row.Value + step, movement.OriginCell.Column.Value] != null)
                    {
                        throw new Exception("Movimiento inválido para torre. Pieza en camino.");
                    }
                    step += step;
                    counter++;
                }
            }
        }
    }
}
