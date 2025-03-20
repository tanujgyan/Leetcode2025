namespace Top150;

class Program
{
    static void Main(string[] args)
    {
        _105 _105 = new _105();
        var root = _105.BuildTree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7]);
        Console.WriteLine(root);
    }
}