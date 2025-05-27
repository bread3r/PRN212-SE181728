using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm = {n}");
}
int n = 5;
Console.WriteLine($"n trước khi gọi hàm = {n}");    
ham1(n);
Console.WriteLine($"n sau khi gọi hàm = {n}");


void ham2(ref int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm = {n}");
}
Console.WriteLine("--------------------");
n = 5;
Console.WriteLine($"n trước khi gọi hàm = {n}");
ham2(ref n);
Console.WriteLine($"n sau khi gọi hàm = {n}");

//int m;
//ham2(ref m); báo lỗi vì dòng này m chưa có giá trị
// -> luôn phải khởi tạo giá trị ban đầu

void ham3(out int n) //out là không cần khởi tạo giá trị ban đầu, nhưng cần khởi tạo giá trị bên trong hàm
{
    n = 9;
}
n = 113;
ham3(out n);

//      ref                           out
//cần khởi tạo giá trị đầu      không cần khởi tạo giá trị đầu
//                              cần khởi tạo giá trị trong hàm