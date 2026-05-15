using Microsoft.AspNetCore.Mvc;
using pr33_2.Data.Interfaces;
using System.Runtime.CompilerServices;
namespace pr33_2.Controllers
{
    public class ItemsController : Controller
    {
        private IItems IAllItems;
        private ICategories IAllCaterogies;
        public ItemsController(IItems IAllItems, ICategories IAllCaterogies)
        {
            this.IAllItems = IAllItems;
            this.IAllCaterogies = IAllCaterogies;
        }
        public ViewResult List()
        {
            ViewBag.Title = "страница с предметами";
            var cars = IAllItems.AllItems;
            return View(cars);
        }
    }
}
