using DAV_Tarea4.Models;
using DAV_Tarea4.Parser;
using DAV_Tarea4.Pieces;
using System;
using Xunit;

namespace DAV_Tarea4.Tests
{
    public class PawnTests : TestBase
    {
        [Theory]
        [InlineData("pc7-c5")]
        [InlineData("pc7-c6")]
        public void PawnCanValidateMovementsTheory(string movementString)
        {
            // Arrange
            Pawn pawn = new Pawn();
            Exception expectedError = null;
            Movement movement = new Movement()
            {
                MovementInputString = movementString,
                PieceType = MovementsParser.getTypeFromCharacter(movementString[0]),
                OriginCell = new Cell()
                {
                    Row = MovementsParser.getRowFromSecondCharacterInMovement(movementString[2]),
                    Column = MovementsParser.getColumnFromFirstCharacterInMovement(movementString[1])
                },
                DestinationCell = new Cell()
                {
                    Row = MovementsParser.getRowFromSecondCharacterInMovement(movementString[5]),
                    Column = MovementsParser.getColumnFromFirstCharacterInMovement(movementString[4])
                }
            };

            // Act
            try
            {
                pawn.ProcessMovement(movement, chessBoard);
            }
            catch(Exception ex)
            {
                expectedError = ex;
            }

            // Assert
            Assert.Null(expectedError);
        }
    }
}
