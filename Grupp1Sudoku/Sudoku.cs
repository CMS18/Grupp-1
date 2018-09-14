﻿using System;
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

        public int FindOnlyPossibleNumber(int cellX, int cellY) {
           
            
            bool[] eliminatedNumbers = new bool[9];

            //Search the row
            for (int x = 0; x < 9; x++) {
                int cellVal = board[cellY, x];
                if (cellVal != 0) {
                    eliminatedNumbers[cellVal - 1] = true;
                }
            }

            //Search the column
            for (int y = 0; y < 9; y++) {
                int cellVal = board[y, cellX];
                if (cellVal != 0) {
                    eliminatedNumbers[cellVal - 1] = true;
                }
            }

            //Search the block
            int blockX = cellX / 3;
            int blockY = cellY / 3;

            //hitta block koordinater
            for (int y = blockY*3; y < (blockY*3) + 3; y++)
            {
                for (int x = blockX*3; x < (blockX*3) + 3; x++)
                {
                    int cellVal = board[y, x];
                    if (cellVal != 0)
                    {
                        eliminatedNumbers[cellVal - 1] = true;
                    }
                }
               
            }
            int trueCount = 0;

            foreach(bool b in eliminatedNumbers)
            {
                if(b == true)
                {
                    trueCount++;
                }
            }

            if(trueCount == 8)
            {
                for (int i = 0; i < 9; i++)
                {
                    if(eliminatedNumbers[i] == false)
                    {
                        return i + 1; 
                    }

                }
            }         
            return 0;

        }

        public void Solve() {

        }
//        Loopa tills färdig
//Loopa igenom alla celler(med nästlade for-loopar)
//Om cellen är tom(siffran 0)

//    HittaSiffrorPåRadKolumnBlock(x, y)
//Om dess rad/kolumn/block bara lämnar ett alternativ kvar
//fyll i den siffran..
//Lyckades programmet inte fylla i en enda cell denna vändan?
//Om alla är fylllda - Vinst.Om det finns tomma kvar - Förlust/Olösbar.
//Skriv ut den lösta sudokun, eller så långt man kom om den inte är löst.
 
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

        public void PrintSudoku()
        {
            for (int y = 0; y < board.GetLength(1); y++) //For-loop för kolumnen
            {
                if (y % 3 == 0)
                {
                    Console.WriteLine("-------------------------"); //Skriv ut strecksrad
                }

                for (int x = 0; x < board.GetLength(0); x++) //For-loop för raden
                {
                    if (x % 3 == 0)
                    {
                        Console.Write("| ");
                    }
                    if (board[y, x] == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(board[y, x] + " ");    //Annars: Skriv ut siffran
                    }
                }
                Console.Write("|\n");
            }
            Console.WriteLine("-------------------------"); //Skriv ut understrecksrad

        }


    }




}
