using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.Title = "TicTacToe!";
            string[][] grid = new string[3][];
            grid[0] = new string[] { "1", "2", "3" };
            grid[1] = new string[] { "4", "5", "6" };
            grid[2] = new string[] { "7", "8", "9" };
            byte turn = 0;
            string playerturn = "";
            int input = 0;
            bool player1 = false;
            string player = "";
            bool gameover = false;
            while (gameover == false)
            {
                if (grid[0][0] == "X" || grid[0][0] == "O") { Console.Write($"| "); Console.ForegroundColor = grid[0][0] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[0][0]}"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" |  "); }
                else Console.Write($"| {grid[0][0]} |  ");


                if (grid[0][1] == "X" || grid[0][1] == "O") { Console.ForegroundColor = grid[0][1] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[0][1]}"); Console.ForegroundColor = ConsoleColor.White; Console.Write("  |  "); }
                else Console.Write($"{grid[0][1]}  |  ");

                if (grid[0][2] == "X" || grid[0][2] == "O") { Console.ForegroundColor = grid[0][2] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[0][2]}"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" |"); }
                else Console.WriteLine($"{grid[0][2]} |");

                Console.WriteLine("+---+-----+----+");

                if (grid[1][0] == "X" || grid[1][0] == "O") { Console.Write($"| "); Console.ForegroundColor = grid[1][0] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[1][0]}"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" |  "); }
                else Console.Write($"| {grid[1][0]} |  ");


                if (grid[1][1] == "X" || grid[1][1] == "O") { Console.ForegroundColor = grid[1][1] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[1][1]}"); Console.ForegroundColor = ConsoleColor.White; Console.Write("  |  "); }
                else Console.Write($"{grid[1][1]}  |  ");


                if (grid[1][2] == "X" || grid[1][2] == "O") { Console.ForegroundColor = grid[1][2] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[1][2]}"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" |"); }
                else Console.WriteLine($"{grid[1][2]} |");

                Console.WriteLine("+---+-----+----+");



                if (grid[2][0] == "X" || grid[2][0] == "O") { Console.Write($"| "); Console.ForegroundColor = grid[2][0] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[2][0]}"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" |  "); }
                else Console.Write($"| {grid[2][0]} |  ");

                if (grid[2][1] == "X" || grid[2][1] == "O") { Console.ForegroundColor = grid[2][1] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[2][1]}"); Console.ForegroundColor = ConsoleColor.White; Console.Write("  |  "); }
                else Console.Write($"{grid[2][1]}  |  ");

                if (grid[2][2] == "X" || grid[2][2] == "O") { Console.ForegroundColor = grid[2][2] == "X" ? ConsoleColor.Red : ConsoleColor.Blue; Console.Write($"{grid[2][2]}"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" |"); }
                else Console.WriteLine($"{grid[2][2]} |");
                //  Console.WriteLine($"| {grid[0][0]} |  {grid[0][1]}  |  {grid[0][2]} |");
                // Console.WriteLine("+---+-----+----+");
                //Console.WriteLine($"| {grid[1][0]} |  {grid[1][1]}  |  {grid[1][2]} |");
                // Console.WriteLine("+---+-----+----+");
                //Console.WriteLine($"| {grid[2][0]} |  {grid[2][1]}  |  {grid[2][2]} |");
                if (GameIsOver(grid) == true)
                {
                    Console.ForegroundColor = player1 == false ? ConsoleColor.Red : ConsoleColor.Blue;
                    Console.WriteLine($"Congratulations player {player} won!"); gameover = true;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press 1 to play again,Press any other key to exit the game.");
                    string inputt = Console.ReadLine();
                    
                    if(inputt == "1") { Console.Clear(); Main(); }
                    else
                    break;
                }
                if(AvailibleMoves(grid) == 9) 
                { Console.WriteLine("The game is a tie!");
                    Console.WriteLine("Press 1 to play again,Press any other key to exit the game.");
                    string inputt = Console.ReadLine();

                    if (inputt == "1") { Console.Clear(); Main(); }
                    else
                    break;



                }
                player1 = !player1;
                player = player1 == true ? "1" : "2";
                turn++;
                Console.ForegroundColor = player1 == false ? ConsoleColor.Red : ConsoleColor.Blue;
                input = AskForNumberInRange($"Player {player} enter a number", 1, 9);
              Console.ForegroundColor=  ConsoleColor.White;
                switch (input)
                {
                    case 1:
                        if (grid[0][0] == "X" || grid[0][0] == "O") { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 2:
                        if (grid[0][1] == "X" || grid[0][1] == "O") { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 3:
                        if (grid[0][2] == "X" || "O" == grid[0][2]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 4:
                        if (grid[1][0] == "X" || "O" == grid[1][0]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 5:
                        if (grid[1][1] == "X" || "O" == grid[1][1]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 6:
                        if (grid[1][2] == "X" || "O" == grid[1][2]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 7:
                        if (grid[2][0] == "X" || "O" == grid[2][0]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 8:
                        if (grid[2][1] == "X" || "O" == grid[2][1]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;
                    case 9:
                        if (grid[2][2] == "X" || "O" == grid[2][2]) { Console.Clear(); Console.WriteLine("this has already been taken"); turn++; player1 = !player1; continue; }
                        break;

                }

                {
                    switch (input)
                    {
                        case 1:                         
                            grid[0][0] = turn % 2 == 0 ? "X" : "O";                          
                            break;
                        case 2:                        
                            grid[0][1] = turn % 2 == 0 ? "X" : "O";                         
                            break;
                        case 3:                          
                            grid[0][2] = turn % 2 == 0 ? "X" : "O";                        
                            break;
                        case 4:                    
                            grid[1][0] = turn % 2 == 0 ? "X" : "O";
                            break;
                        case 5:
                            grid[1][1] = turn % 2 == 0 ? "X" : "O";                           
                            break;
                        case 6:                           
                            grid[1][2] = turn % 2 == 0 ? "X" : "O";                          
                            break;
                        case 7:                          
                            grid[2][0] = turn % 2 == 0 ? "X" : "O";                          
                            break;
                        case 8:
                            grid[2][1] = turn % 2 == 0 ? "X" : "O";                        
                            break;
                        case 9:                        
                            grid[2][2] = turn % 2 == 0 ? "X" : "O";     
                            break;
                        default:
                            Console.WriteLine("sorry,something must have gone wrong pls try again");
                            break;






                    }



                   
                     Console.Clear();













                }
            }





        }

        public static bool GameIsOver(string[][] _grid)
        {
            if (_grid[0][0] == _grid[0][1] && _grid[0][1] == _grid[0][2]) { return true; }
            else if (_grid[1][0] == _grid[1][1] && _grid[1][1] == _grid[1][2]) { return true; }
            else if (_grid[2][0] == _grid[2][1] && _grid[2][1] == _grid[2][2]) { return true; }

            else if (_grid[0][0] == _grid[1][0] && _grid[1][0] == _grid[2][0]) { return true; }
            else if (_grid[0][1] == _grid[1][1] && _grid[1][1] == _grid[2][1]) { return true; }
            else if (_grid[0][2] == _grid[1][2] && _grid[1][2] == _grid[2][2]) { return true; }


            else if (_grid[0][0] == _grid[1][1] && _grid[1][1] == _grid[2][2]) { return true; }
            else if (_grid[2][0] == _grid[1][1] && _grid[1][1] == _grid[0][2]) { return true; }
            else return false;









        }
        static int askfornumber(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int AskForNumberInRange(string text, int min, int max)
        {

            while (true)
            {
                int number = askfornumber(text);
                if (number >= min && number <= max) { return number; }
            }
        }
      static int AvailibleMoves(string[][] _grid)
        {
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if(_grid[i][x] =="X" || _grid[i][x] == "O") { result++; }
                }
            }
            return result;
        }
    }

}