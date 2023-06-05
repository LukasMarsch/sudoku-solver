namespace Main;

using System;
using Sudoku;


class SudokuSolver {
    static String path = @"C:\Users\lmarsch\Repositories\sudoku-solver\resources\Input.txt";
    static void Main(String[] args) {
        String[] input = File.ReadAllLines(path);
        List<Sudoku> games = new List<Sudoku>(input.Length);
        for(int i = 0; i < input.Length; i++) {
            try {
                games.Add(new Sudoku(input[i]));
            } catch (InvalidCastException ex) {
                Console.WriteLine("Error: Array was not imported! " + path.ToString() + $" line {i+1}", ex);
            }
        }
        foreach(Sudoku game in games){
            Console.WriteLine(game.ToString());
        }
    }
}