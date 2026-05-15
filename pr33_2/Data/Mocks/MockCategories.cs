using pr33_2.Data.Interfaces;
using pr33_2.Data.Models;
namespace pr33_2.Data.Mocks
{
    public class MockCategories : ICategories
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    // Ноутбуки
                new Categories()
                {
                    Id = 0,
                    Name = "Ноутбуки",
                    Description = "Мощные ноутбуки для работы, учёбы и игр. Широкий выбор моделей от ведущих производителей."
                },

                // Смартфоны
                new Categories()
                {
                    Id = 1,
                    Name = "Смартфоны",
                    Description = "Современные смартфоны на Android и iOS. Отличные камеры, мощные процессоры, ёмкие аккумуляторы."
                },

                // Наушники и аудио
                new Categories()
                {
                    Id = 2,
                    Name = "Наушники",
                    Description = "Проводные и беспроводные наушники. Внутриканальные, накладные и полноразмерные модели."
                },

                // Клавиатуры
                new Categories()
                {
                    Id = 3,
                    Name = "Клавиатуры",
                    Description = "Механические и мембранные клавиатуры. Проводные и беспроводные. С подсветкой и без."
                },

                // Мониторы
                new Categories()
                {
                    Id = 4,
                    Name = "Мониторы",
                    Description = "Качественные мониторы для работы и игр. Различные диагонали, разрешения и матрицы."
                }
                };
            }
        }
    }
}
