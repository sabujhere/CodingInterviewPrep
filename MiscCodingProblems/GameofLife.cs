using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 289. Game of Life
    /// </summary>
    public class GameofLife
    {
        // dead          0
        // alive         1
        // alive -> dead 2
        // dead -> alive 3   
        private List<Tuple<int, int>> directions = new List<Tuple<int, int>>()
        {
            Tuple.Create(-1, -1),
            Tuple.Create(-1, 0),
            Tuple.Create(-1, 1),
            Tuple.Create(0, -1),
            Tuple.Create(0, 1),
            Tuple.Create(1, -1),
            Tuple.Create(1, 0),
            Tuple.Create(1, 1)
        };
        public void GameOfLife(int[][] board)
        {
            var m = board.Length;
            var n = board[0].Length;
            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int lives = GetLives(r, c, board);
                    int currentVal = board[r][c];
                    if (currentVal == 1)
                    {
                        if (lives > 3 || lives < 2)
                        {
                            board[r][c] = 2;
                        }
                    }
                    else
                    {
                        if (lives == 3)
                        {
                            board[r][c] = 3;
                        }
                    }
                }
            }

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    board[r][c] %= 2;
                }
            }
        }

        private int GetLives(int i, int j, int[][] board)
        {
            int lives = 0;
            var m = board.Length;
            var n = board[0].Length;
            foreach (var direction in directions)
            {
                var x = i + direction.Item1;
                var y = j + direction.Item2;
                if(x >= m || x < 0 || y >= n || y < 0) continue;
                if (board[x][y] == 1 || board[x][y] == 2) lives++;
            }

            return lives;
        }
    }
}
