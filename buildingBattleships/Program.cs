using System;
using System.IO;

namespace buildingBattleships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] myGameBoard = new string[10, 10];
            string[,] aiGameBoard = new string[10, 10];
            Random random = new Random();
            int myBoatX = random.Next(1, 10);
            int myBoatY = random.Next(1, 10);
            int aiBoatX = random.Next(1, 10);
            int aiBoatY = random.Next(1, 10);
            bool Hit = false;

            Console.WriteLine(" \n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                          *********************************************");
            Console.WriteLine(" ");
            Console.Write("                          *"); Console.ForegroundColor = ConsoleColor.White; Console.Write("    Welcome to Caleb's Battleship Game!!! "); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(" *");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" \n                          *********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            //SetupGameBoard(myGameBoard, aiGameBoard);
            //show the Boats
            //Console.WriteLine("My Boat is at " + myBoatX + myBoatY);
            //Console.WriteLine("AI Boat is at " + aiBoatX + aiBoatY);
            myGameBoard[myBoatY - 1, myBoatX - 1] = "@ ";
            aiGameBoard[aiBoatY - 1, aiBoatX - 1] = "@ ";
            SetupGameBoard(myGameBoard, aiGameBoard);

            //Get User Co-ordinates & check for win
            while (Hit == false)
            {
                int UserX = GetX();
                int UserY = GetY();
                Console.WriteLine("X is " + UserX + " Y is " + UserY);
                if (UserX == aiBoatX && UserY == aiBoatY)
                {
                    Console.WriteLine("*BOOM* you got him!\n Game Over");
                    Hit = true;
                }
                else
                {
                    Console.WriteLine("*OOPS* You missed... Keep Going...");
                }
            }
            Console.ReadLine();
        }


    //I set up my gameboard and aigameboard using arrays
    static void SetupGameBoard(string[,] myGameBoard, string[,] aiGameBoard)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (myGameBoard[i, j] != "@ ")
                    {
                        myGameBoard[i, j] = "~ ";
                    }
                    Console.Write(myGameBoard[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (aiGameBoard[i, j] != "@ ")
                        aiGameBoard[i, j] = "^ ";
                    Console.Write(aiGameBoard[i, j]);
                }
                Console.WriteLine();

            }

        }
        static int GetX()
        {
            Console.Write("\n Please enter your X coordinate: ");
            int XX = Convert.ToInt32(Console.ReadLine());
            return XX;
        }
        static int GetY()
        {
            Console.Write("\n Please enter your Y coordinate: ");
            int YY = Convert.ToInt32(Console.ReadLine());
            return YY;
        }
    }


}

