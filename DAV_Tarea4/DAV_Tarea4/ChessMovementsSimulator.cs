using DAV_Tarea4.Models;
using System;
using System.Collections.Generic;

namespace DAV_Tarea4
{
    public static class ChessMovementsSimulator
    {
        public static void SimulateMovements(Piece[,] board, List<Movement> movements)
        {
            for(int i=0; i<movements.Count; i++)
            {
                if (movements[i].ValidateMovement())
                {
                    try
                    {
                        Singleton.Singleton.GetPieceProxy().ProcessMovement(movements[i], board);
                        Console.WriteLine(string.Format("Movimiento {0} es válido. ", movements[i].MovementInputString));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("Error Simulando Movimiento {0}", movements[i].MovementInputString));
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
