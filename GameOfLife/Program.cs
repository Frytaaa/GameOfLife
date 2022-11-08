// See https://aka.ms/new-console-template for more information

using GameOfLife.Tests;

Console.WriteLine("Hello, World!");

var board = new Board(3);
var deadCell = new Cell(0, 0);
var cell1 = new Cell(0, 1);
var cell2 = new Cell(1, 0);
var cell3 = new Cell(1, 1);
            
board.SetLivingCell(cell1);
board.SetLivingCell(cell2);
board.SetLivingCell(cell3);


//??????

Console.Write(board.board[deadCell.x, deadCell.y]);