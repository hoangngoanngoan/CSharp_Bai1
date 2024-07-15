using System.ComponentModel;

internal class Program
{
    internal static int Tinhtong(int i, int j)
    {
        return i + j;
    }
    internal static int Tinhhieu(int i, int j)
    {
        return i - j;
    }
    internal static int Tinhtich(int i, int j)
    {
        return i * j;
    }
    internal static string Tinhthuong(int i, int j)
    {
        try
        {
            return Convert.ToString(i / j);
        }catch
        {
            return "Khong the chia het cho 0";
        }
    }
    internal static int Chialaydu(int i, int j)
    {
        return i % j;
    }
    
    
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Chương trình tính toán đơn giản");
        int i, j;
        Console.Write("Nhap i: ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap j: ");
        j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tổng của hai số {0} và số {1} là {2}",i,j,Tinhtong(i,j));
        Console.WriteLine("Hiệu của hai sô {0} vá số {1} là {2}",i,j,Tinhhieu(i,j));
        Console.WriteLine($"Thuong cua hai so {i} và {j} là {Tinhthuong(i,j)}");
        Console.WriteLine($"Tich cua hai so {i} và {j} là {Tinhtich(i, j)}");
        Console.WriteLine($"Du cua so {i} chia cho {j} là {Chialaydu(i, j)}");
    }
}