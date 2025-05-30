using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        /*
        KHi quản lý mọi đối tượng ta đều phải đáp ứng 
        đầy đủ tính năng CRUD
        */

        public void AddProduct(Product p)
        {
            
            if (p == null)
            {
                return; //dữ liệu đầu vào null
            }
            if (Products.ContainsKey(p.Id))
            {
                Console.WriteLine("Sản phẩm đã tồn tại trong danh mục này.");
                return; //sản phẩm đã tồn tại
            }
            Products.Add(p.Id, p);
        }

        //Xuất toàn bộ Sản phẩm
        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }

        //Lọc các sản phẩm có giá từ min tới max
        public Dictionary<int, Product> FilterProductsByPrice(double min, double max)
        {
            return Products.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
        }
    }
}
