using DAV_Tarea4.Models;
using DAV_Tarea4.Parser;
using System;
using System.Collections.Generic;

namespace DAV_Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Piece[,] chessBoard = new Piece[,]
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

            List<Movement> validMovements = MovementsParser.ParseFile("C:\\validMoves.txt");
            List<Movement> invalidMovements = MovementsParser.ParseFile("C:\\invalidMoves.txt");

            Console.WriteLine("*************************");
            Console.WriteLine("*  Movimiento  Validos  *");
            Console.WriteLine("*************************");
            ChessMovementsSimulator.SimulateMovements(chessBoard, validMovements);

            Console.WriteLine("*************************");
            Console.WriteLine("*  Movimiento Invalidos *");
            Console.WriteLine("*************************");
            ChessMovementsSimulator.SimulateMovements(chessBoard, invalidMovements);
        }
    }
}
