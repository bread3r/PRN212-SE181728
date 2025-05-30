using System.Text;
using OOP6_Dictionary;

Console.OutputEncoding = Encoding.UTF8;
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước ngọt";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Pepsi";
p1.Quantity = 10;
p1.Price = 30;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Coca";
p2.Quantity = 7;
p2.Price = 25;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "RedBull";
p3.Quantity = 130;
p3.Price = 30;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Sting";
p4.Quantity = 25;
p4.Price = 15;
c1.AddProduct(p4);


Product p5 = new Product();
p5.Id = 5;
p5.Name = "Revie";
p5.Quantity = 130;
p5.Price = 15;
c1.AddProduct(p5);

Console.WriteLine("--Thông tin danh mục--");
Console.WriteLine(c1);
Console.WriteLine("--------------Danh sách sản phẩm--------------");
c1.PrintAllProducts();