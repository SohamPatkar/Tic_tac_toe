using System;
using System.Diagnostics.Metrics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            var y = 0;
            var z = 0;
            bool win = false;
            
            int[,] ticTactoe = 
            { 
                {0,0,0}, 
                {0,0,0}, 
                {0,0,0} 
            };

            int c = ticTactoe.GetLength(1) - 1;
            int counter = ticTactoe.GetLength(1) - 1;

            show();

            for (int i = 0; i < ticTactoe.Length; i++)
            {
                    Console.WriteLine("Enter the number");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the position");
                    int userPosrow = Convert.ToInt32(Console.ReadLine());
                    int userPoscol = Convert.ToInt32(Console.ReadLine());

                    ticTactoe[userPosrow, userPoscol] = userInput;
                    show();
                    checkLine();
                    checkDiagonals();
                    checkLineHorizontal();
                    if (win == true)
                    {
                        break;  
                    }
            }

            void checkLine()
            {
                Console.WriteLine("\n");
                for (int j = 0; j < ticTactoe.GetLength(1); j++)
                {
                    for (int i = 0; i < ticTactoe.GetLength(0); i++)
                    {
                        if (i == 0)
                        {
                            x = ticTactoe[i, j];
                        }
                        if (i == 1)
                        {
                            y = ticTactoe[i, j];
                        }
                        if (i == 2)
                        {
                            z = ticTactoe[i, j];
                        }
                        if (x == y)
                        {
                            if (y == z)
                            {
                                Console.WriteLine("You win");
                                win = true;
                                return;
                            }
                        }
                    }
                    Console.WriteLine("\n");
                }
                
            }

            void checkDiagonals()
            {
                for (int i = 0; i < ticTactoe.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTactoe.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            if (j == 0)
                            {
                                x = ticTactoe[i,j]; 
                            }

                            if (j == 1)
                            {
                                y =  ticTactoe[i, j];
                            }
                            if (j == 2)
                            {
                                z = ticTactoe[i, j];
                            }
                            if (x == y) 
                            {
                                if (y == z)
                                {
                                    Console.WriteLine("You win");
                                    win = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            void checkDiagonalRight()
            {
                for (int i = 0; i < ticTactoe.GetLength(1); i++)
                {
                    if(i== 0)
                    {
                        x = ticTactoe[i, c];
                    }
                    if (i == 0)
                    {
                        y = ticTactoe[i, c];
                    }
                    if (i == 0)
                    {
                        z = ticTactoe[i, c];
                    }
                    if (x == y)
                    {
                        if (y == z)
                        {
                            Console.WriteLine("You win");
                            win = true;
                            return;
                        }
                    }
                    c--;
                }
            }

            void checkLineHorizontal()
            {
                for (int i = 0; i < ticTactoe.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTactoe.GetLength(1); j++)
                    {
                            if (j == 0)
                            {
                                x = ticTactoe[i, j];
                            }

                            if (j == 1)
                            {
                                y = ticTactoe[i, j];
                            }
                            if (j == 2)
                            {
                                z = ticTactoe[i, j];
                            }
                            if (x == y)
                            {
                                if (y == z)
                                {
                                    Console.WriteLine("You win");
                                    win = true;
                                    return;
                                }
                            }
                    }
                }
            }

            void show()
            {
                Console.WriteLine("\n");
                for (int i = 0; i < ticTactoe.GetLength(0); i++)
                {
                    for (int j = 0; j < ticTactoe.GetLength(1); j++)
                    {
                        Console.Write(ticTactoe[i, j]);
                    }
                    Console.Write("\n");
                }
            }
        }
      
    }
}