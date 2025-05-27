/*
Sử dụng Generic List để quản lý nhân sự với đẩy đủ 
tính năng CRUD
C - Create:             Tạo mới dữ liệu
R - Read/Retrieve:      Xem, lọc, tìm kiếm, sắp xếp, thống kê,...
U - Update:             Sửa dữ liệu
D - Delete:             Xóa dữ liệu 
*/

//Câu 1: Tạo 5 nhân viên, 3 nhân viên chính thức và 2 thời vụ
//lưu vào generic List: 
using System.Text;
using System.Xml.Linq;
using OOP2;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    id = 1,
    idCard = "123",
    Name = "Name 1",
    Birthday = new DateTime(1990, 1, 6),
};
employees.Add(fe1);
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    id = 2,
    idCard = "234",
    Name = "Name 2",
    Birthday = new DateTime(1991, 3, 4),
};
employees.Add(fe2);
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    id = 3,
    idCard = "345",
    Name = "Name 3",
    Birthday = new DateTime(1992, 12, 1),
};
employees.Add(fe3);

PartTimeEmployee pe1 = new PartTimeEmployee()
{
    id = 4,
    idCard = "456",
    Name = "Name 4",
    Birthday = new DateTime(1993, 12, 8),
    WorkingHours = 1
};
employees.Add(pe1);
PartTimeEmployee pe2 = new PartTimeEmployee()
{
    id = 5,
    idCard = "567",
    Name = "Name 5",
    Birthday = new DateTime(1994, 8, 8),
    WorkingHours = 3
};
employees.Add(pe2);
Console.OutputEncoding = Encoding.UTF8;
//Câu 2: R -> Xuất toàn bộ nhân sự: 
Console.WriteLine("Câu 2: R -> Xuất toàn bộ nhân sự: ");
//cách 1:
employees.ForEach(e => Console.WriteLine(e));

//Câu 3: lọc ra các nhân sự là chính thức
//cách 1: 
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("Câu 3: R -> Lọc ra toàn bộ nhân sự là chính thức: ");
foreach (FulltimeEmployee fe in fe_list)
{
    Console.WriteLine(fe);
}

//Câu 4: Tổng lương nhân viên chính thức
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Câu 4: Tổng lương nhân viên chính thức: ");
Console.WriteLine(fe_sum_salary);

//Câu 5: Tổng lương nhân viên thời vụ:
double pe_sum_salary = employees.OfType<PartTimeEmployee>().Sum(e => e.calSalary());
Console.WriteLine("Câu 5: Tổng lương nhân viên thời vụ: ");
Console.WriteLine(pe_sum_salary);