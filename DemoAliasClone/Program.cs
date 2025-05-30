using System.Text;
using DemoAliasClone;

Console.OutputEncoding = Encoding.UTF8;

Customer c1 = new Customer();
c1.Id = 1;
c1.Name = "Trần Thị Tèo";

Customer c2 = new Customer();
c1.Id = 2;
c1.Name = "Nguyễn Văn Tẹt";

c1 = c2;
// c1 trỏ tới vùng nhớ mà c2 đang quản lý
// chứ không phải c1 bằng c2 
// => Lúc này xảy ra 2 tình huống 
// (1) Ô nhớ alpha mà c1 quản lý lúc nãy bị trống 
// không còn đối tượng nào tham gia quản lý nữa 
// ==> Hệ điều hành sẽ thu hồi ô nhớ Alpha này
// gọi là cơ chế gom rác tự động: Automatic Garbage Collection
// Ta không thể nào lấy được giá trị tại ô nhớ này nữa 
// (2) Lúc này ô nhớ Beta sẽ có 2 đối tượng tham gia quản lý
// - đối tượng ban đầu là c2
// - bây giờ có thêm đối tượng c1 quảng lý
// Trường hợp 1 ô nhớ từ từ 2 đối tượng trở lên tham gia quản lý
// nó được gọi là Alias: 
// -> Bất kỳ 1 đối tựng nào đổi giá trị tại ô nhớ Beta
// --> thì các đối tựong còn lại đều bị ảnh hưởng

c1.Name = "Hồ Đồ";
//Thì lúc này c2 cũng bị đổi tên thành "Hồ Đồ"
// Vì c1 và c2 đang quản lý 1 ô nhớ 
Console.WriteLine("Tên của c2 = " + c2.Name);

Customer c3 = new Customer();
Customer c4 = c3;
c3 = c1; 
// Không có thu hồi ô nhớ của c3 đang quản lý