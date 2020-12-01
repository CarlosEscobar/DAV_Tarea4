using System;

namespace DAV_Tarea4.Models
{
    public class Cell
    {
        public int? Row { get; set; }
        public int? Column { get; set; }
    }

    public class Movement
    {
        public string MovementInputString { get; set; }
        public Type? PieceType { get; set; }
        public Cell OriginCell { get; set; }
        public Cell DestinationCell { get; set; }

        public bool ValidateMovement()
        {
            bool result = true;
            
            if(PieceType == null)
            {
                result = false;
                Console.WriteLine(string.Format("Error on Movement [{0}] - Wrong format for Piece Type.",MovementInputString));
            }

            if (OriginCell.Row == null)
            {
                result = false;
                Console.WriteLine(string.Format("Error on Movement [{0}] - Wrong format for Origin Row.", MovementInputString));
            }

            if (OriginCell.Column == null)
            {
                result = false;
                Console.WriteLine(string.Format("Error on Movement [{0}] - Wrong format for Origin Column.", MovementInputString));
            }

            if (DestinationCell.Row == null)
            {
                result = false;
                Console.WriteLine(string.Format("Error on Movement [{0}] - Wrong format for Destination Row.", MovementInputString));
            }

            if (DestinationCell.Column == null)
            {
                result = false;
                Console.WriteLine(string.Format("Error on Movement [{0}] - Wrong format for Destination Column.", MovementInputString));
            }

            return result;
        }
    }
}