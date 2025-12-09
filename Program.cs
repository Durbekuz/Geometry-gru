// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        bool restart = true;

        while (restart)
        {
            Console.Clear();
            Console.WriteLine("=== Geometry Guru ===");
            Console.WriteLine("1. Uchburchak yuzasi");
            Console.WriteLine("2. To'rtburchak yuzasi");
            Console.WriteLine("3. Doira yuzasi");
            Console.WriteLine("4. Ikki tomon bo'yicha uchinchi tomon oraliği");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlang: ");

            int tanlov = int.Parse(Console.ReadLine());

            switch (tanlov)
            {
                case 1:
                    UchburchakYuzasi();
                    break;
                case 2:
                    TortburchakYuzasi();
                    break;
                case 3:
                    DoiraYuzasi();
                    break;
                case 4:
                    UchinchiTomonOraligi();
                    break;
                case 5:
                    restart = false;
                    continue;
                default:
                    Console.WriteLine("Noto'g'ri tanlov!");
                    break;
            }

            Console.Write("\nYana davom ettirasizmi? (ha/yoq): ");
            restart = Console.ReadLine().ToLower() == "ha";
        }

        Console.WriteLine("Dastur tugadi, rahmat!");
    }

    static void UchburchakYuzasi()
    {
        Console.Write("Asos = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Balandlik = ");
        double h = double.Parse(Console.ReadLine());

        double s = (a * h) / 2;
        Console.WriteLine($"Uchburchak yuzasi = {s}");
    }

    static void TortburchakYuzasi()
    {
        Console.Write("Uzunlik = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Kenglik = ");
        double b = double.Parse(Console.ReadLine());

        double s = a * b;
        Console.WriteLine($"To'rtburchak yuzasi = {s}");
    }

    static void DoiraYuzasi()
    {
        Console.Write("Radius = ");
        double r = double.Parse(Console.ReadLine());

        double s = Math.PI * r * r;
        Console.WriteLine($"Doira yuzasi = {s}");
    }

    static void UchinchiTomonOraligi()
    {
        Console.Write("1-tomon = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("2-tomon = ");
        double b = double.Parse(Console.ReadLine());

        double min = Math.Abs(a - b);
        double max = a + b;

        Console.WriteLine($"3-tomon shu oraliqda bo'lishi mumkin: {min} < c < {max}");
    }
}