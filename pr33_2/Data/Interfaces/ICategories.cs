using pr33_2.Data.Models;
namespace pr33_2.Data.Interfaces
{
    public interface ICategories
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
