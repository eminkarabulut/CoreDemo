using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Coment
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManager commentManager=new CommentManager(new EfCommentRepository());

		public IViewComponentResult Invoke(int id)
		{
			var values= commentManager.GetComments(id);

			return View(values);
		}
	}
}
 