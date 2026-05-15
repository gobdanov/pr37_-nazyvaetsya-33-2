using pr33_2.Data.Interfaces;
using pr33_2.Data.Models;

namespace pr33_2.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategories _category = new MockCategory();
        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items()
                    {
                        Id = 0,
                        Name = "Dexp MS-70",
                        Description = "не хочу писать описание",
                        Img = "",
                        Price = 3699,
                        category = _category.AllCategories.Where(x=>x.Id==0).First()
                    },
                    new Items()
                    {
                        Id = 1,
                        Name = "Apple MacBook Pro 14 M3",
                        Description = "Ноутбук с чипом M3, 8-core CPU, 10-core GPU, 16GB RAM, 512GB SSD",
                        Img = "/images/macbook-pro-14.jpg",
                        Price = 199990,
                        category =_category.AllCategories.Where(x=>x.Id==1).First()
                    },
                    new Items()
                    {
                        Id = 2,
                        Name = "Xiaomi 13T Pro",
                        Description = "6.67' AMOLED, Dimensity 9200+, 12GB RAM, 256GB, 120W зарядка",
                        Img = "/images/xiaomi-13t-pro.jpg",
                        Price = 49990,
                        category =_category.AllCategories.Where(x=>x.Id==2).First()
                    },

                    new Items()
                    {
                        Id = 3,
                        Name = "Sony WH-1000XM5",
                        Description = "Беспроводные наушники с шумоподавлением, 30 часов работы",
                        Img = "/images/sony-xm5.jpg",
                        Price = 27990,
                        category =_category.AllCategories.Where(x=>x.Id==3).First()
                    },

                    // Клавиатура
                    new Items()
                    {
                        Id = 4,
                        Name = "Logitech MX Mechanical",
                        Description = "Механическая клавиатура, подсветка, беспроводная, Bluetooth",
                        Img = "/images/logitech-mx-mechanical.jpg",
                        Price = 14990,
                        category =_category.AllCategories.Where(x=>x.Id==4).First()
                    },

                    // Монитор
                    new Items()
                    {
                        Id = 5,
                        Name = "Dell UltraSharp U2723QE",
                        Description = "27' 4K IPS, USB-C Hub, 100% sRGB, заводская калибровка",
                        Img = "/images/dell-u2723qe.jpg",
                        Price = 58990,
                        category =_category.AllCategories.Where(x=>x.Id==5).First()
                    }

                };
            }
        }
    }
}
