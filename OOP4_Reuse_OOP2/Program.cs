using System.Text;
using OOP2;
using OOP4_Reuse_OOP2;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee fe = new FulltimeEmployee();
fe.id = 1;
fe.Name = "Nguyễn Văn A";
fe.idCard = "123131";
fe.Birthday = new DateTime(1990, 1, 1);
Console.WriteLine(fe);
Console.WriteLine("=> Age = " + fe.Tuoi());