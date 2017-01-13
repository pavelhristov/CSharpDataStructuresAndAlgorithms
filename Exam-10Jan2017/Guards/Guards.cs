using System;

namespace Guards
{
    class Guards
    {
        static void Main()
        {
            const char ENEMY = 'e';
            const char WATCHED = 'w';

            string[] str = Console.ReadLine().Split(' ');

            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);

            char[,] enemies = new char[n + 1, m + 1];

            int enemiesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enemiesCount; i++)
            {
                var enemy = Console.ReadLine().Split(' ');
                string watched = enemy[2];
                int row = int.Parse(enemy[0]);
                int col = int.Parse(enemy[1]);

                enemies[row, col] = ENEMY;

                if (watched == "U" && row > 0)
                {
                    if (enemies[row - 1, col] != ENEMY)
                    {
                        enemies[row - 1, col] = WATCHED;
                    }
                }
                else if (watched == "D" && row < m)
                {
                    if (enemies[row + 1, col] != ENEMY)
                    {
                        enemies[row + 1, col] = WATCHED;
                    }
                }
                else if (watched == "L" && col > 0)
                {
                    if (enemies[row, col - 1] != ENEMY)
                    {
                        enemies[row, col - 1] = WATCHED;
                    }
                }
                else if (watched == "R" && col < m)
                {
                    if (enemies[row, col + 1] != ENEMY)
                    {
                        enemies[row, col + 1] = WATCHED;
                    }
                }
            }

            var maze = new long[n, m];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (enemies[i, j] == ENEMY)
                    {
                        maze[i, j] = -1;
                        continue;
                    }

                    if (i == 0 && j == 0)
                    {
                        maze[i, j] = 1;
                        continue;
                    }

                    int seconds = 1;
                    if (enemies[i, j] == WATCHED)
                    {
                        seconds = 3;
                    }

                    long optionUp = -1;
                    long optionLeft = -1;
                    if (i > 0)
                    {
                        optionUp = maze[i - 1, j];
                    }
                    if (j > 0)
                    {
                        optionLeft = maze[i, j - 1];
                    }

                    if (optionUp == -1)
                    {
                        if (optionLeft == -1)
                        {
                            maze[i, j] = -1;
                        }
                        else
                        {
                            maze[i, j] = optionLeft + seconds;
                        }
                    }
                    else if (optionLeft == -1)
                    {
                        maze[i, j] = optionUp + seconds;
                    }
                    else
                    {
                        maze[i, j] = (optionLeft > optionUp ? optionUp : optionLeft) + seconds;
                    }
                }
            }

            long fastest = maze[n - 1, m - 1];
            if (fastest == -1)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(fastest);
            }
        }
    }
}
