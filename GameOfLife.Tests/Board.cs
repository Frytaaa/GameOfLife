namespace GameOfLife.Tests
{
    public class Board
    {
        public bool[,] board;
        public Board(int size)
        {
            board = new bool[size, size];
        }

        public void SetLivingCell(Cell cell)
        {
            board[cell.x, cell.y] = true;
        }

        private void KillLivingCell(Cell cell)
        {
            board[cell.x, cell.y] = false;
        }

        public bool IsCellALive(Cell cell)
        {
            return board[cell.x, cell.y];
        }

        public void TestTest(Cell cell)
        {
            var countNeighbours = cell.GetNumberOfLivingNeighbours(board);
            if (board[cell.x, cell.y] == false)
            { 
                if (countNeighbours == 3 || countNeighbours == 2) {
                    SetLivingCell(cell);
                }
            }
            else
            {
                if (countNeighbours < 2) {
                    KillLivingCell(cell);
                } else if (countNeighbours > 3) {
                    KillLivingCell(cell);
                }    
            }
        }
    }
}