namespace GameOfLife.Tests
{
    public class Cell
    {
        public int x;
        public int y;
    
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetNumberOfLivingNeighbours(bool[,] board)
        {
            var count = 0;
            
            var xMin = 0;
            var xMax = 0;

            if (this.x <= 0)
            {
                xMax = this.x + 1;
            } else if (this.x <= 2)
            {
                xMin = this.x - 1;
                xMax = this.x + 1;

            } else if (this.x > 2)
            {
                xMin = this.x - 1;
                xMax = this.x;
            }
            

            var yMin = 0;
            var yMax = 0;
            if (this.y <= 0)
            {
                yMin = 0;
                yMax = this.y + 1;
            } else if (this.y < 2)
            {
                yMin = this.y - 1;
                yMax = this.y + 1;
            }
            else
            {
                yMin = this.y - 1;
                yMax = this.y;
            }
            
            
            for (var xI = xMin; xI <= xMax; xI++)
            {
                for (var yI = yMin; yI <= yMax; yI++)
                {
                    if (x == xI && y == yI)
                    {
                        continue;
                    }
                    if (board[xI, yI])
                    {
                        count++;
                    }
                }                
            }
            
            
            return count;
        }
    }
}