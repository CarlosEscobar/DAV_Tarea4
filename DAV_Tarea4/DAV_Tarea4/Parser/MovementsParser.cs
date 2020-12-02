using DAV_Tarea4.Models;
using System.Collections.Generic;
using System.IO;

namespace DAV_Tarea4.Parser
{
    public static class MovementsParser
    {
        public static Models.Type? getTypeFromCharacter(char character)
        {
            switch(char.ToUpper(character))
            {
                case 'P': return Models.Type.Pawn;
                case 'C': return Models.Type.Knight;
                case 'T': return Models.Type.Rook;
                default : return null;
            }
        }

        public static int? getRowFromSecondCharacterInMovement(char character)
        {
            switch(character)
            {
                case '8': return 0;
                case '7': return 1;
                case '6': return 2;
                case '5': return 3;
                case '4': return 4;
                case '3': return 5;
                case '2': return 5;
                case '1': return 7;
                default : return null;
            }
        }

        public static int? getColumnFromFirstCharacterInMovement(char character)
        {
            switch (char.ToUpper(character))
            {
                case 'A': return 0;
                case 'B': return 1;
                case 'C': return 2;
                case 'D': return 3;
                case 'E': return 4;
                case 'F': return 5;
                case 'G': return 5;
                case 'H': return 7;
                default : return null;
            }
        }

        public static List<Movement> ParseFile(string filePath)
        {
            List<Movement> result = new List<Movement>();
            StreamReader file = new StreamReader(filePath);
            string currentLine;

            while ((currentLine = file.ReadLine()) != null)
            {
                currentLine = currentLine.Trim();
                result.Add(new Movement()
                {
                    MovementInputString = currentLine,
                    PieceType = getTypeFromCharacter(currentLine[0]),
                    OriginCell = new Cell()
                    {
                        Row = getRowFromSecondCharacterInMovement(currentLine[2]),
                        Column = getColumnFromFirstCharacterInMovement(currentLine[1])
                    },
                    DestinationCell = new Cell()
                    {
                        Row = getRowFromSecondCharacterInMovement(currentLine[5]),
                        Column = getColumnFromFirstCharacterInMovement(currentLine[4])
                    }
                });
            }

            file.Close();
            return result;
        }
    }
}
