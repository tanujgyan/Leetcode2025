namespace GraphGemini;

class Program
{
    static void Main(string[] args)
    {
        char[][] board = new char[][] {
            new char[] { 'X', 'O', 'O', 'X', 'X', 'X', 'O', 'X', 'O', 'O' },
            new char[] { 'X', 'O', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
            new char[] { 'X', 'X', 'X', 'X', 'O', 'X', 'X', 'X', 'X', 'X' },
            new char[] { 'X', 'O', 'X', 'X', 'X', 'O', 'X', 'X', 'X', 'O' }
        };
        _130 _130 = new _130();
        _130.Solve(board);
    }
}