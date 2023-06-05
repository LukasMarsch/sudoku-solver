namespace Sudoku;

using System.Collections;

class Sudoku {
    public Board board;
    public Possibilities possibilities;

    public Sudoku(String numbers) {
        this.possibilities = new Possibilities();
        this.board = new Board(numbers);
    }

    public override string ToString() {
        if(this.board != null){
            String concat = "";
            foreach(byte b in board) {
                concat += b + ", ";
            }
            return concat;
        } else {
            return "";
        }
    }
}