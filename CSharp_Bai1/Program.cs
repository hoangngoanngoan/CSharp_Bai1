internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Xin chào thế giới");
        Console.WriteLine("Chương trình cộng hai số đơn giản");
        int i, j, z;
        Console.Write("Nhap i: ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap j: ");
        j = Convert.ToInt32(Console.ReadLine());
        z = i + j;
        Console.WriteLine("Tổng của hai số {0} và số {1} là {2}",i,j,z);

    }
}