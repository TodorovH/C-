namespace Problem8DistanceInLabyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DistanceInLabyrinth
    {
        static void Main(string[] args)
        {
            object startingPositionRow = 0;
            object startingPositionCol = 0;
            int currentPositionRow = 0;
            int currentPositionCol = 0;
            int currentRow = 0;
            int currentCol = 0;
            int currentValue = 0;
            Queue<string> positions = new Queue<string>();
            Queue<string> visitedPositions = new Queue<string>();
            string rowAndColStr = "";

            object[,] matrix = {
                                {0, 0, 0, "X", 0, "X"},
                                {0, "X", 0, "X", 0, "X"},
                                {0, "*", "X", 0, "X", 0},
                                {0, "X", 0, 0, 0, 0},
                                {0, 0, 0, "X", "X", 0},
                                {0, 0, 0, "X", 0, "X"}
                                };

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    if (matrix[row, col].Equals("*"))
                    {
                        startingPositionRow = row;
                        startingPositionCol = col;
                        rowAndColStr = row.ToString() + " " + col.ToString();
                        continue;
                    }
                }
            }

            positions.Enqueue(rowAndColStr);

            while (positions.Count != 0)
            {
                string currentPositionStr = positions.Dequeue();
                List<int> currentPosition = currentPositionStr.Split().Select(int.Parse).ToList();
                currentPositionRow = currentPosition[0];
                currentPositionCol = currentPosition[1];

                if (matrix[currentPositionRow, currentPositionCol].Equals("*"))
                {
                    currentValue = 0;
                }
                else
                {
                    currentValue = (int)matrix[currentPositionRow, currentPositionCol];
                }


                bool isValidPositionOnLeft = isValidPosition(matrix, currentPositionRow, currentPositionCol - 1);
                bool isValidPositionOnRight = isValidPosition(matrix, currentPositionRow, currentPositionCol + 1);
                bool isValidPositionOnUp = isValidPosition(matrix, currentPositionRow - 1, currentPositionCol);
                bool isValidPositionOnDown = isValidPosition(matrix, currentPositionRow + 1, currentPositionCol);

                if (isValidPositionOnLeft && matrix[currentPositionRow, currentPositionCol - 1].Equals(0))
                {
                    currentRow = currentPositionRow;
                    currentCol = currentPositionCol - 1;
                    rowAndColStr = currentRow.ToString() + " " + currentCol.ToString();

                    if (!visitedPositions.Contains(rowAndColStr))
                    {
                        currentValue += 1;
                        matrix[currentPositionRow, currentPositionCol - 1] = currentValue;
                        positions.Enqueue(rowAndColStr);
                        visitedPositions.Enqueue(rowAndColStr);
                        currentValue -= 1;
                    }
                }

                if (isValidPositionOnRight && matrix[currentPositionRow, currentPositionCol + 1].Equals(0))
                {
                    currentRow = currentPositionRow;
                    currentCol = currentPositionCol + 1;
                    rowAndColStr = currentRow.ToString() + " " + currentCol.ToString();

                    if (!visitedPositions.Contains(rowAndColStr))
                    {
                        currentValue += 1;
                        matrix[currentPositionRow, currentPositionCol + 1] = currentValue;
                        positions.Enqueue(rowAndColStr);
                        visitedPositions.Enqueue(rowAndColStr);
                        currentValue -= 1;
                    }
                }

                if (isValidPositionOnUp && matrix[currentPositionRow - 1, currentPositionCol].Equals(0))
                {
                    currentRow = currentPositionRow - 1;
                    currentCol = currentPositionCol;
                    rowAndColStr = currentRow.ToString() + " " + currentCol.ToString();

                    if (!visitedPositions.Contains(rowAndColStr))
                    {
                        currentValue += 1;
                        matrix[currentPositionRow - 1, currentPositionCol] = currentValue;
                        positions.Enqueue(rowAndColStr);
                        visitedPositions.Enqueue(rowAndColStr);
                        currentValue -= 1;
                    }
                }

                if (isValidPositionOnDown && matrix[currentPositionRow + 1, currentPositionCol].Equals(0))
                {
                    currentRow = currentPositionRow + 1;
                    currentCol = currentPositionCol;
                    rowAndColStr = currentRow.ToString() + " " + currentCol.ToString();

                    if (!visitedPositions.Contains(rowAndColStr))
                    {
                        currentValue += 1;
                        matrix[currentPositionRow + 1, currentPositionCol] = currentValue;
                        positions.Enqueue(rowAndColStr);
                        visitedPositions.Enqueue(rowAndColStr);
                        currentValue -= 1;
                    }
                }
            }

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    if (matrix[row, col].Equals(0))
                    {
                        matrix[row, col] = "U";
                    }
                }
            }

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool isValidPosition(object[,] matrix, int row, int col)
        {
            bool isValidRow = true;
            bool isValidCol = true;

            if (row < 0 || row > matrix.GetUpperBound(0))
            {
                isValidRow = false;
            }

            if (col < 0 || col > matrix.GetUpperBound(1))
            {
                isValidCol = false;
            }

            return (isValidRow && isValidCol);
        }
    }
}
