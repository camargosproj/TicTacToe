
using System;

namespace TicTcToe
{
    class Program
    {
        
        const string xString = "X";
        const string oString = "O";
        public static bool gameover = false;
        public static string[] dashArray =
           {
                "-", "-", "-" ,
                 "-", "-", "-" ,
                 "-", "-", "-"
            };
        static void Main(string[] args)
        {
            
            while (gameover == false)
            {
                StartGame();
                Console.Read();
            }
        }
        public static void ShowBoard()
        {
            Console.WriteLine(dashArray[0] + " | " + dashArray[1] + " | " + dashArray[2]);
            Console.WriteLine("==========");
            Console.WriteLine(dashArray[3] + " | " + dashArray[4] + " | " + dashArray[5]);
            Console.WriteLine("==========");
            Console.WriteLine(dashArray[6] + " | " + dashArray[7] + " | " + dashArray[8]);
        }
        // Where the game starts
        public static void StartGame()
        {
            playerTurn();
        }
        // Check who wanna starts
        public static void playerTurn()
        {
            ShowBoard();
            Console.WriteLine("X or O ?");
            string whosturn = Console.ReadLine();
            

            if (whosturn == "x")
            {
                Console.Clear();
                Xturn();

            }
            else if (whosturn == "o")
            {
                Console.Clear();
                Oturn();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input!");
                playerTurn();
            }
  
        }
        public static void Xturn()
        {
           
            try
            {
                Console.WriteLine("Choose from 1-9 to place the X ?");
                ShowBoard();
                int xPlayer = int.Parse(Console.ReadLine());
                if (dashArray[xPlayer - 1] == "-")
                {
                    dashArray[xPlayer - 1] = xString; // Subtract one of the index to get the right position on the game
                    Console.Clear();
                    Xwin();
                }
               
                else
                {
                    Console.Clear();
                    Console.WriteLine("You can't place it here again");
                    Xturn();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
                Xturn();
            }


            if (gameover == false) Oturn();


        }
        public static void Oturn()
        {
            try
            {
                Console.WriteLine("Choose from 1-9 to place the O ?");
                ShowBoard();
                int oPlayer = int.Parse(Console.ReadLine());

                if (dashArray[oPlayer - 1] == "-")
                {
                    dashArray[oPlayer - 1] = oString; // Subtract one of the index to get the right position on the game
                    Console.Clear();
                    Owin();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You can't place here again");
                    Oturn();
                }
            }
            catch (Exception)
            {

                Console.Clear();
                Console.WriteLine("Invalid Input");
                Oturn();
            }
            

            if (gameover == false) Xturn();
        }
        public static void Xwin()
        {
            // Horizontal

            if (dashArray[0] == Program.xString && dashArray[1] == xString && dashArray[2] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            else if (dashArray[3] == xString && dashArray[4] == xString && dashArray[5] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            else if (dashArray[6] == xString && dashArray[7] == xString && dashArray[8] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            // Diagonal
            else if (dashArray[0] == xString && dashArray[4] == xString && dashArray[8] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            else if (dashArray[2] == xString && dashArray[4] == xString && dashArray[6] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!"); 
                gameover = true;
            }
            // Vertical
            else if (dashArray[0] == xString && dashArray[3] == xString && dashArray[6] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            else if (dashArray[1] == xString && dashArray[4] == xString && dashArray[7] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            else if (dashArray[2] == xString && dashArray[5] == xString && dashArray[8] == xString)
            {
                ShowBoard();
                Console.WriteLine("X Win!");
                gameover = true;
            }
            else IsTied();
        }
        public static void Owin()
        {
            // Horizontal

            if (dashArray[0] == oString && dashArray[1] == "o" && dashArray[2] == "o")
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            else if (dashArray[3] == oString && dashArray[4] == oString && dashArray[5] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            else if (dashArray[6] == oString && dashArray[7] == oString && dashArray[8] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            // Diagonal
            else if (dashArray[0] == oString && dashArray[4] == oString && dashArray[8] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            else if (dashArray[2] == oString && dashArray[4] == oString && dashArray[6] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            // Vertical
            else if (dashArray[0] == oString && dashArray[3] == oString && dashArray[6] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            else if (dashArray[1] == oString && dashArray[4] == oString && dashArray[7] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            else if (dashArray[2] == oString && dashArray[5] == oString && dashArray[8] == oString)
            {
                ShowBoard();
                Console.WriteLine("O Win!");
                gameover = true;
            }
            else IsTied();
        }
        //Check if the game is Tied, the game is going to be tied if counter is greater then  the length of the array
        public static bool IsTied()
        {
            int counter = 0;

            foreach (var arrayValue in dashArray)
            {
                // Counter gonna increment only of the user enter X or O
                if (arrayValue != "-")
                {

                    counter++;
                    if (counter >= dashArray.Length && gameover == false)
                    {
                        Console.Clear();
                        ShowBoard();
                        Console.WriteLine("It's Tied");
                        gameover = true;
                    }
                }

            }
            return gameover;
        }

    }
}
