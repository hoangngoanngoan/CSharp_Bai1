internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Xin chào thế giới");
        Console.WriteLine("Chương trình cộng hai và trừ hai số đơn giản");
        int i, j, z, x;
        Console.Write("Nhap i: ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap j: ");
        j = Convert.ToInt32(Console.ReadLine());
        z = i + j;
        x = i - j;
        Console.WriteLine("Tổng của hai số {0} và số {1} là {2}",i,j,z);
        Console.WriteLine("Hiệu của hai sô {0} vá số {1} là {2}",i,j,x);
        try
        {
            double thuong;
            thuong = i / j;
            Console.WriteLine($"Thuong cua hai so {i} và {j} là {thuong}");
        }catch {
            Console.WriteLine("Khong the chia cho 0");
        }

    }
}