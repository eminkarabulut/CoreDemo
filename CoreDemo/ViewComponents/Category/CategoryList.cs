using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManager manager=new(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values=manager.GetAllCategories();

			return View(values);
		}
	}
}
