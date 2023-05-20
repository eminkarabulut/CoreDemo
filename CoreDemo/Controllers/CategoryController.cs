using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace CoreDemo.Controllers
{
	public class CategoryController : Controller
	{
		 CategoryManager categoryManager=new CategoryManager(new EfCategoryRepository());


		public IActionResult Index()
		{
			var values=categoryManager.GetAllCategories();

			return View(values);
		}
	}
}
