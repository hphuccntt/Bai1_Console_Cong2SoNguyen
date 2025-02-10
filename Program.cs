internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write(" Chao Toi Ten La :");
        string ten = Console.ReadLine();
        Console.WriteLine("Toi Ten :" + ten);
        Console.ReadKey();

        /*
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(" Nhap So Thu Nhat! ");
        double sothunhat = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Nhap So Thu Hai! ");
        double sothuhai = Convert.ToDouble(Console.ReadLine());
        double tong = sothunhat + sothuhai;
        Console.WriteLine(" Tong cua hai so la :" + tong) ;
        Console.WriteLine("{0} + {1} = {2}",  sothunhat, sothuhai, tong);
        */
       

    }
}