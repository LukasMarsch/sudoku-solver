using System.Collections;

namespace Sudoku;

public class Board {
    private byte[,] board;

    public Board(String input) {
        this.board = new byte[9, 9];
        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                Char s = input.ElementAt(i+j);
                double d = Char.GetNumericValue(s);
                if(Double.IsInteger(d)){
                    this.board[i,j] = (byte) d;
                }
            }
        }
    }

    public IEnumerator GetEnumerator()
    {
        return (IEnumerator) this.board.GetEnumerator();
    }
}

public class Possibilities {
    Boolean[,,] possibilities;

    public Possibilities() {
        // just fill everything with true, we need to check later
        this.possibilities = new Boolean[9,9,9];
        for(int x = 0; x < 9; x++) {
            for(int y = 0; y < 9; y++) {
                for(int n = 0; n < 9; n++) {
                    this.possibilities[x, y, n] = true;
                }
            }
        }
    }

    public IEnumerator GetEnumerator()
    {
        return (IEnumerator) this.possibilities.GetEnumerator();
    }
}