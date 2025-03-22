namespace GraphGemini;

class Program
{
    static void Main(string[] args)
    {
        char[][] board = new char[][] {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'E', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        };
        _79 _79 = new _79();
        _79.Exist(board, "ABCESEEEFS");
    }
}