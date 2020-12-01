using DAV_Tarea4.Models;
using DAV_Tarea4.Pieces;
using System;

namespace DAV_Tarea4.Proxy
{
    class PieceProxy : IPieceProxy
    {
        private Pawn _pawn;
        private Rook _rook;
        private Knight _knight;

        public PieceProxy()
        {
            _pawn = new Pawn();
            _rook = new Rook();
            _knight = new Knight();
        }

        public void ValidatePieceBeingMoved(Movement movement, Piece[,] board)
        {
            if(board[movement.OriginCell.Row.Value,movement.OriginCell.Column.Value].Type != movement.PieceType.Value) 
            {
                throw new Exception("El tipo de pieza del movimiento no coincide con la pieza en el tablero.");    
            }
        }

        public void ProcessMovement(Movement movement, Piece[,] board)
        {
            switch(movement.PieceType)
            {
                case Models.Type.Pawn:
                    ValidatePieceBeingMoved(movement, board);
                    _pawn.ProcessMovement(movement, board);
                    break;
                case Models.Type.Rook:
                    ValidatePieceBeingMoved(movement, board);
                    _rook.ProcessMovement(movement, board);
                    break;
                case Models.Type.Knight:
                    ValidatePieceBeingMoved(movement, board);
                    _knight.ProcessMovement(movement, board);
                    break;
                default:
                    throw new Exception(string.Format("No se puede simular el movimiento con tipo de pieza {0}.",  movement.PieceType.Value));
            }
        }
    }
}