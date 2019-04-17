﻿using System.Collections.Generic;
using System;

namespace QUT.CSharpTicTacToe
{
    /// <summary>
    /// This represents the current state of the game, 
    /// including the size of the game (NxN), 
    /// who's turn it is and the pieces on the board
    /// </summary>    
    public class Game : ITicTacToeGame<Player>
    {
        public int Size;
        public Player Turn;
        public List<Move> path;
        public int[] lines;
        public Player evenPlayer;
        public Player oddPlayer;
        public List<Move> squares;
        public int winningSumEven;
        public int winningSumOdd;
        public Move[] diag1;
        public Move[] diag2;

        int ITicTacToeGame<Player>.Size => this.Size;
        Player ITicTacToeGame<Player>.Turn => (this.path.Count % 2 == 0) ? evenPlayer : oddPlayer;

        public Game(Player first, int size)
        {
            this.Turn = first;
            this.Size = size;
            diag1 = new Move[size];
            diag2 = new Move[size];
            for (int i = 0; i < size; i++)
            {
                diag1[i] = new Move(i, i);
                diag2[i] = new Move(i, (size - i - 1));
            }
            lines = new int[2 * size + 2];
            squares = new List<Move>();
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    squares.Add(new Move(row, col));
                }
            }
            path = new List<Move>();
        }

        public bool IsDraw()
        {
            bool lineIsDraw(int sum)
            {
                if ((sum > 100) & (sum % 100) != 0) { return true; }
                return false;
            }

            bool linesChecker = true;
            foreach (int i in lines){
                if (lineIsDraw(i) != true) { linesChecker = false; }
            }
            if (linesChecker) { return true; }
            return false;
        }

        public Player Winner()
        {
            if (((IList<int>)lines).Contains(this.winningSumEven)){
                return evenPlayer;
            }
            else if (((IList<int>)lines).Contains(this.winningSumOdd))
            {
                return oddPlayer;
            }
            return 0;
        }

        public int Score(Player player)
        {
            if (this.IsDraw())
            {
                return +0;
            }

            if (player == evenPlayer) { return +1; }
            else if (player == oddPlayer)
            {
                return +1;
            }
            return +0;
        }

        public int TheSize
        {
            get { return this.Size; }
        }

        public Player WhosTurn
        {
            get
            {
                if (this.path.Count % 2 == 0) { return this.evenPlayer; }
                return this.oddPlayer;
            }

            set { this.Turn = value; }
        }

        public string getPiece(int row, int col)
        {
            String piece(Player player)
            {
                if (player == Player.Cross) { return "X"; }
                else if (player == Player.Nought) { return "O"; }
                return null;
            }
            //find index that matches the row and column in the list path
            int n = this.path.FindIndex(a => a.Row == row); //Only uses row
            if (n == 0) { return ""; }
            else if ((this.path.Count - 1 - n) % 2 == 0) { piece(evenPlayer); }
            else { piece(oddPlayer); }
            return null;
        }

    }
}