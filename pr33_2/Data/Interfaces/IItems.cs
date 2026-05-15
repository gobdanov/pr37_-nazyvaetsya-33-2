using pr33_2.Data.Models;
namespace pr33_2.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
    }
}
