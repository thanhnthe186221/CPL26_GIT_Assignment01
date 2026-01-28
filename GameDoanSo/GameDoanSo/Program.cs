using System;
namespace GameDoanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Máy tính chọn ngẫu nhiên một số từ 1 đến 100
            Random random = new Random();
            int soBiMat = random.Next(1, 101);
            int soLanDoan = 0;
            int soBanDoan = 0;

            Console.WriteLine("=== CHAO MUNG DEN VOI GAME DOAN SO ===");
            Console.WriteLine("Minh dang nghi mot so tu 1 den 100.");
            Console.WriteLine("Ban hay doan xem do la so may nhe!");
            Console.WriteLine("--------------------------------------");

            // 2. Vòng lặp game: Chơi đến khi nào đoán đúng thì thôi
            while (soBanDoan != soBiMat)
            {
                Console.Write("Nhap so cua ban: ");
                string input = Console.ReadLine();

                // Kiểm tra xem người dùng có nhập đúng là số không
                if (!int.TryParse(input, out soBanDoan))
                {
                    Console.WriteLine("Loi: Vui long chi nhap so!");
                    continue;
                }

                soLanDoan++;

                if (soBanDoan < soBiMat)
                {
                    Console.WriteLine(">> Thap qua! Thu so lon hon nhe.");
                }
                else if (soBanDoan > soBiMat)
                {
                    Console.WriteLine(">> Cao qua! Thu so nho hon nhe.");
                }
                else
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"CHUC MUNG! Ban da doan trung so {soBiMat}!");
                    Console.WriteLine($"Ban da mat {soLanDoan} luot doan.");
                }
            }

            // Giữ màn hình không tắt ngay
            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
