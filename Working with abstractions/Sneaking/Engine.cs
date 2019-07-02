using System;
using System.Collections.Generic;
using System.Text;

namespace Sneaking
{
    public class Engine
    {
        static char[][] field;
        static int[] enemyCells = new int[2];
        static int playerRow;
        static int playerCol;

        public void Run()
        {
            int rows = int.Parse(Console.ReadLine());
            field = new char[rows][];

            InitializeField(rows);

            var directions = Console.ReadLine().ToCharArray();

            for (int i = 0; i < directions.Length; i++)
            {
                for (int row = 0; row < field.Length; row++)
                {
                    for (int col = 0; col < field[row].Length; col++)
                    {
                        col = CheckEnemyDirections(row, col);
                    }
                }

                FindEnemy();

                if (CheckLeftFaceKill(enemyCells))
                {
                    PrintDeadField();
                }

                else if (CheckRightfaceKill(enemyCells))
                {
                    PrintDeadField();
                }


                MovePlayer(directions, i);

                FindEnemy();

                if (IsWin(enemyCells))
                {
                    PrintWinField();

                }
            }
        }

        private static void FindEnemy()
        {
            for (int j = 0; j < field[playerRow].Length; j++)
            {
                if (field[playerRow][j] != '.' && field[playerRow][j] != 'S')
                {
                    enemyCells[0] = playerRow;
                    enemyCells[1] = j;
                }
            }
        }

        private void PrintWinField()
        {
            field[enemyCells[0]][enemyCells[1]] = 'X';

            Console.WriteLine("Nikoladze killed!");

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static bool IsWin(int[] enemyCells)
        {
            return field[enemyCells[0]][enemyCells[1]] == 'N' && playerRow == enemyCells[0];
        }

        private static void MovePlayer(char[] directions, int i)
        {
            field[playerRow][playerCol] = '.';

            switch (directions[i])
            {
                case 'U':
                    playerRow--;
                    break;
                case 'D':
                    playerRow++;
                    break;
                case 'L':
                    playerCol--;
                    break;
                case 'R':
                    playerCol++;
                    break;
                default:
                    break;
            }

            field[playerRow][playerCol] = 'S';
        }

        private static bool CheckRightfaceKill(int[] enemyCells)
        {
            return enemyCells[1] < playerCol && field[enemyCells[0]][enemyCells[1]] == 'b' && enemyCells[0] == playerRow;
        }

        private static bool CheckLeftFaceKill(int[] enemyCells)
        {
            return playerCol < enemyCells[1] && field[enemyCells[0]][enemyCells[1]] == 'd' && enemyCells[0] == playerRow;
        }

        private static void PrintDeadField()
        {
            field[playerRow][playerCol] = 'X';

            Console.WriteLine($"Sam died at {playerRow}, {playerCol}");

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static int CheckEnemyDirections(int row, int col)
        {
            if (field[row][col] == 'b')
            {
                if (row >= 0 && row < field.Length && col + 1 >= 0 && col + 1 < field[row].Length)
                {
                    field[row][col] = '.';
                    field[row][col + 1] = 'b';
                    col++;
                }
                else
                {
                    field[row][col] = 'd';
                }
            }
            else if (field[row][col] == 'd')
            {
                if (row >= 0 && row < field.Length && col - 1 >= 0 && col - 1 < field[row].Length)
                {
                    field[row][col] = '.';
                    field[row][col - 1] = 'd';
                }
                else
                {
                    field[row][col] = 'b';
                }
            }

            return col;
        }

        private static void InitializeField(int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                field[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    field[row][col] = input[col];

                    if (field[row][col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}

