using System.Text;
using OOP3_ExtensionMethod;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine($"Tổng từ 1 đến {n1} là: {n1.TongTu1toiN()}");
Console.WriteLine($"Tổng từ 1 đến {n2} là: {n2.TongTu1toiN()}");
Console.WriteLine($"Tổng từ 1 đến 8 = " + 8.TongTu1toiN());

Console.WriteLine("8 + 7 = " + 8.Cong(7));

int[] M = new int[8];
M.TaoMang();
Console.WriteLine("Mảng M được tạo ngẫu nhiên là: ");
M.XuatMang();
M.SapXepMangTangDan();
Console.WriteLine("Mảng sau khi sắp xếp tăng dần: ");
M.XuatMang();
int[] M2 = M.SapXepMangGiamDan();
Console.WriteLine("Mảng sau khi sắp xếp giảm dần: ");
M2.XuatMang();