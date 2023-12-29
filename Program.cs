class Program
{
    private static void Main(string[] args)
    {
        string[] s = { "a", "b", "c", "a", "d", "e" };
        Console.WriteLine("Nhap ki tu can dem: ");
        string x = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (x == s[i])
            {
                count++;
            }
        }
        Console.WriteLine("so luong ki tu la: " + count);
    }
}