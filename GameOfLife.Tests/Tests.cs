using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void DiesOnUnderpopulation()
        {
            // Arrange
            var board = new Board(3);
            var cell1 = new Cell(0, 1);
            var cell2 = new Cell(1, 0);

            board.SetLivingCell(cell1);
            board.SetLivingCell(cell2);

            // Act
            board.TestTest(cell1);

            // Assert
            Assert.IsFalse(board.IsCellALive(cell1));
        }
        
        [Test]
        public void DiesOnOverpopulation()
        {
            // Arrange
            var board = new Board(3);
            var cell1 = new Cell(1, 1);
            var cell2 = new Cell(0, 1);
            var cell3 = new Cell(1, 0);
            var cell4 = new Cell(1, 2);
            var cell5 = new Cell(2, 1);
            
            board.SetLivingCell(cell1);
            board.SetLivingCell(cell2);
            board.SetLivingCell(cell3);
            board.SetLivingCell(cell4);
            board.SetLivingCell(cell5);
            
            // Act
            board.TestTest(cell1);
            // Assert
            Assert.IsFalse(board.IsCellALive(cell1));
        }
        
        [Test]
        public void TwoSurvive()
        {
            // Arrange
            var board = new Board(3);
            var cell1 = new Cell(1, 1);
            var cell2 = new Cell(0, 1);
            var cell3 = new Cell(1, 0);

            
            board.SetLivingCell(cell1);
            board.SetLivingCell(cell2);
            board.SetLivingCell(cell3);

            
            // Act
            board.TestTest(cell1);
            // Assert
            Assert.IsTrue(board.IsCellALive(cell1));
        }
        
        [Test]
        public void ThreeSurvive()
        {
            // Arrange
            var board = new Board(3);
            var cell1 = new Cell(1, 1);
            var cell2 = new Cell(0, 1);
            var cell3 = new Cell(1, 0);
            var cell4 = new Cell(1, 2);

            
            board.SetLivingCell(cell1);
            board.SetLivingCell(cell2);
            board.SetLivingCell(cell3);
            board.SetLivingCell(cell4);
            
            // Act
            board.TestTest(cell1);
            // Assert
            Assert.IsTrue(board.IsCellALive(cell1));
        }
        
        [Test]
        public void TwoOrThreeSurvive()
        {
            // Arrange
            var board = new Board(3);
            var cell1 = new Cell(1, 1);
            var cell2 = new Cell(0, 1);
            var cell3 = new Cell(1, 0);


            board.SetLivingCell(cell1);
            board.SetLivingCell(cell2);
            board.SetLivingCell(cell3);

            // Act
            board.TestTest(cell1);
            // Assert
            Assert.IsTrue(board.IsCellALive(cell1));
        }

        [Test]
        public void ReproduceDealCellWithThreeNeighbours()
        {
            // Arrange
            var board = new Board(3);
            var deadCell = new Cell(0, 0);
            var cell1 = new Cell(0, 1);
            var cell2 = new Cell(1, 0);
            var cell3 = new Cell(1, 1);
            
            board.SetLivingCell(cell1);
            board.SetLivingCell(cell2);
            board.SetLivingCell(cell3);
            
            // Act
            board.TestTest(deadCell);
            // Assert
            Assert.IsTrue(board.IsCellALive(deadCell));
            
        }
        
        // [Test]
        // public void DiesOnUnderpopulation()
        // {
        //     // Arrange
        //     var board = new Board(3);
        //     var cell1 = new Cell(0, 0);
        //     board.SetLivingCell(cell1);
        //
        //
        //     _board[livingCell.x, livingCell.y] = true;
        //     
        //     var countNeighbours = livingCell.GetNumberOfLivingNeighbours(_board);
        //
        //     // Act
        //
        //     if (countNeighbours < 2)
        //     {
        //         _board[livingCell.x, livingCell.y] = false;
        //     }
        //     // Assert
        //     Assert.IsFalse(_board[livingCell.x, livingCell.y]);
        // }
        //
        // [Test]
        // public void DiesOnOverpopulation()
        // {
        //     // Arrange
        //     var livingCell1 = new Cell(0, 0);
        //     var livingCell2 = new Cell(0, 1);
        //     var livingCell3 = new Cell(1, 0);
        //     var livingCell4 = new Cell(1, 1);
        //     
        //     _board[livingCell1.x, livingCell1.y] = true;
        //     _board[livingCell2.x, livingCell2.y] = true;
        //     _board[livingCell3.x, livingCell3.y] = true;
        //     _board[livingCell4.x, livingCell4.y] = true;
        //     
        //     var countNeighbours = livingCell1.GetNumberOfLivingNeighbours(_board);
        //
        //     // Act
        //
        //     if (countNeighbours > 3)
        //     {
        //         _board[livingCell1.x, livingCell1.y] = false;
        //     }
        //     
        //     
        //     // Assert
        //     Assert.IsFalse(_board[livingCell1.x, livingCell1.y]);
        // }
    }
}