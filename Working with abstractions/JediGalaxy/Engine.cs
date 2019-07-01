using System;
using System.Linq;

namespace JediGalaxy
{
    public class Engine
    {
        private int[,] matrix;

        private long sum;

        public void StartUp()
        {
            int[] dimensions = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            InitializeMatrix(rows, cols);

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] playerCoordinate = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int[] evilCoordinate = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int evilRow = evilCoordinate[0];
                int evilCol = evilCoordinate[1];

                MoveEvil(evilRow, evilCol);

                int playerRow = playerCoordinate[0];
                int playerCol = playerCoordinate[1];

                MovePlayer(playerRow, playerCol);

                command = Console.ReadLine();
            }

            PrintOutput(sum);

        }

        private static void PrintOutput(long sum)
        {
            Console.WriteLine(sum);
        }

        private void MovePlayer(int playerRow, int playerCol)
        {
            while (playerRow >= 0 && playerCol < matrix.GetLength(1))
            {
                if (IsInMatrix(playerRow, playerCol))
                {
                    sum += matrix[playerRow, playerCol];
                }

                playerCol++;
                playerRow--;
            }
        }

        private void MoveEvil(int evilRow, int evilCol)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (IsInMatrix(evilRow, evilCol))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }

        private bool IsInMatrix(int currentRow, int currentCol)
        {
            return currentRow >= 0 && currentRow < matrix.GetLength(0) && currentCol >= 0 && currentCol < matrix.GetLength(1);
        }

        private void InitializeMatrix(int rows, int cols)
        {
            int value = 0;
            matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = value++;
                }
            }

        }
    }
}
