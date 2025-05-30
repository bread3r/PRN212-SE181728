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

double min_price = 10;
double max_price = 20;
Dictionary<int, Product> products_by_price = 
    c1.FilterProductsByPrice(min_price, max_price);
Console.WriteLine($"Danh sách sản phẩm có giá từ {min_price} đến {max_price}:");
foreach (KeyValuePair<int, Product> kvp in products_by_price)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_products = c1.SortProductsByPrice();
Console.WriteLine("Danh sách các sản phẩm đã được sắp xếp theo giá tăng dần:");
foreach (KeyValuePair<int, Product> kvp in sorted_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_complex = c1.SortComplex();
Console.WriteLine("Danh sách các sản phẩm đã được sắp xếp complex:");
foreach (KeyValuePair<int, Product> kvp in sorted_complex)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}