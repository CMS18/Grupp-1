using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Sudoku
{
    class Sudoku
    {
        int[,] board;
        public Sudoku(string input)
        {
            board = TransformStringToArray(input);
        }

        private int[,] TransformStringToArray(string input)
        {
            int[,] newboard = new int[9, 9];  //Skapa en array[9, 9]
            for (int y = 0; y < newboard.GetLength(1); y++) // For loop Y
            {
                for (int x = 0; x < newboard.GetLength(0); x++)//For loop X
                {
                    newboard[y, x] = int.Parse(input[x + (y * 9)].ToString());
                }
            }

            return newboard;
        }



    }
}
