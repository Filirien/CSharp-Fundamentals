using System;
using System.Linq;

namespace _01._Dangerous_Floor
{
    public class Program
    {
        static char[][] board;
        public static void Main()
        {
            board = new char[8][];
            for (int row = 0; row < board.Length; row++)
            {
                board[row] = Console.ReadLine()
                    .Split(',')
                    .Select(char.Parse)
                    .ToArray();
            }

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                char figureType = inputLine[0];
                int startingRow = int.Parse(inputLine[1].ToString());
                int startingCol = int.Parse(inputLine[2].ToString());
                int targetRow = int.Parse(inputLine[4].ToString());
                int targetCol = int.Parse(inputLine[5].ToString());

                if (!FigureExists(figureType, startingCol, startingRow))
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }

                if (!IsMoveValid(figureType, startingRow, startingCol, targetRow, targetCol))
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                if (!OutOfBoard(targetRow, targetCol))
                {
                    Console.WriteLine("Move go out of board!");
                    continue;
                }

                board[targetRow][targetCol] = figureType;
                board[startingRow][startingCol] = 'x';
            }
        }

        private static bool OutOfBoard(int targetRow, int targetCol)
        {
            bool validRow = targetRow >= 0 && targetRow < 8;
            bool validCol = targetCol >= 0 && targetCol < 8;
            return validRow && validCol;
        }

        private static bool IsMoveValid(char figureType, int startingRow, int startingCol, int targetRow, int targetCol)
        {
            switch (figureType)
            {
                case 'P':
                    return ValidPawnMove(startingRow, startingCol, targetRow, targetCol);
                case 'R':
                    return ValidStraightMove(startingRow, startingCol, targetRow, targetCol);
                case 'B':
                    return ValidDiagonalMove(startingRow, startingCol, targetRow, targetCol);
                case 'Q':
                    return ValidStraightMove(startingRow, startingCol, targetRow, targetCol) ||
                        ValidDiagonalMove(startingRow, startingCol, targetRow, targetCol);
                case 'K':
                    return ValidKingMove(startingRow, startingCol, targetRow, targetCol);
                default:
                    return false;
            }
        }

        private static bool ValidKingMove(int startingRow, int startingCol, int targetRow, int targetCol)
        {
            bool validRow = Math.Abs(startingRow - targetRow) == 1
                || Math.Abs(startingRow - targetRow) == 0;
            bool validCol = Math.Abs(startingCol - targetCol) == 1 
                || Math.Abs(startingCol - targetCol) == 0;

            return validCol && validRow;
        }

        private static bool ValidDiagonalMove(int startingRow, int startingCol, int targetRow, int targetCol)
        {
            return Math.Abs(startingRow - targetRow) == Math.Abs(startingCol - targetCol);
        }

        private static bool ValidStraightMove(int startingRow, int startingCol, int targetRow, int targetCol)
        {
            bool sameRow = startingRow == targetRow;
            bool sameCol = startingCol == targetCol;

            return sameRow || sameCol;
        }

        private static bool ValidPawnMove(int startingRow, int startingCol, int targetRow, int targetCol)
        {
            bool validColumn = startingCol == targetCol;
            bool validRow = startingRow - 1 == targetRow;
            return validColumn && validRow;
        }

        private static bool FigureExists(char figureType, int startingCol, int startingRow)
        {
            return board[startingRow][startingCol] == figureType;
        }
    }
}
