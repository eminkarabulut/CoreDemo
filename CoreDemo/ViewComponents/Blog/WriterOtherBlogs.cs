using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
	public class WriterOtherBlogs:ViewComponent
	{
		BlogManager blogManager=new(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetBlogListByWriter(1);

			return View(values);
		}
	}
}
