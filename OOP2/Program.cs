using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee obam = new FulltimeEmployee();
obam.id = 1;
obam.idCard = "123";
obam.Name = "Barack Obama";
obam.Birthday = new DateTime(1961, 8, 4);
Console.WriteLine("Thông tin của Obama: ");
Console.WriteLine("ID: " + obam.id);
Console.WriteLine("ID Card: " + obam.idCard);
Console.WriteLine("Ho va ten: " + obam.Name);
Console.WriteLine("Ngay sinh: " + obam.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Luong: " + obam.calSalary());

PartTimeEmployee trump = new PartTimeEmployee()
{
    id = 2,
    idCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1946, 6, 14),
    WorkingHours = 2
};

Console.WriteLine("Thông tin của Trump: ");
Console.WriteLine("ID: " + trump.id);
Console.WriteLine("ID Card: " + trump.idCard);
Console.WriteLine("Ho va ten: " + trump.Name);
Console.WriteLine("Ngay sinh: " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Luong: " + trump.calSalary());


Console.WriteLine("--------Thông tin cách 2 của nhân sự--------");
Console.WriteLine(obam);
Console.WriteLine(trump);