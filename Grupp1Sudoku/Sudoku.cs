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

            return 0;

        }

//        Public int HittaSiffrorPåRadKolumnBlock(x, y)

//    Skapa ett minne = [f, f, f, f, f, f, f, f, f]
//        Loopar genom rad
//            Läser siffran
//            Om inte 0
//			Ändra dess index till true (Akta för OBOE)

//    Likadant för kolumn
//Hitta block-koordinater
//Loopa igenom block X
//Loopa igenom block Y
//Läs siffran
//Om inte 0
//Ändra dess index till true (oboe)
//Skapa Int false-räknare = 9
//Loopa igenom minnesarrayen
//Om false-räknare ==1
//		Loopa igenom minnesarray igen



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
