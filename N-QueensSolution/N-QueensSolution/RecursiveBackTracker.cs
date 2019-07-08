using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_QueensSolution
{
    class RecursiveBackTracker
    {
        int N { get; set; }
        public int steps { get; set; }

        char[,] board;

        public RecursiveBackTracker(int queens)
        {
            N = queens;
            populateBoard();
        }
        public bool QueenSolutionPossible()
        {
            return CheckNQueen(board, 0);
        }
        bool CheckNQueen(char[,] board, int col)
        {
            bool DoesWork = false;

            if (col >= N)
                return true;

            for (int i = 0; i < N; i++)
            {
                if (CanPlace(board, i, col))
                {
                    board[i, col] = 'Q';
                    steps++;
                    if(CheckNQueen(board, col + 1))
                    {
                        DoesWork = true;
                        break;
                    }
                    board[i,col] = '-';
                }
            }
            return DoesWork;
        }

        bool CanPlace(char[,] board, int row, int col)
        {
            int i, j;
            bool canPlace = true;

            if (N == 1)
                return canPlace;

            for (i = 0; i < col; i++)
            {
                if (board[row,i] == 'Q')
                    canPlace = false;
            }

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i,j] == 'Q')
                    canPlace = false;
            }

            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i,j] == 'Q')
                    canPlace = false;
            }
            return canPlace;
        }

        void populateBoard()
        {
            board = new char[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board[i,j] = '-';
                }
            }
        }

        public string GetBoard()
        {
            string s = "";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    s += (j == 0) ? board[i,j] + "" : " " + board[i,j];
                }
                s += "\n";
            }
            return s;
        }
    }
}
