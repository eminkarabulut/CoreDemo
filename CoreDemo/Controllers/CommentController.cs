using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		private CommentManager _commentManager;

		public CommentController(CommentManager commentManager)
		{
			_commentManager = commentManager;
		}

		public IActionResult Index()
		{
			return View();
		}
		
		public PartialViewResult AddCommentPartial()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult AddCommentPartial(Comment comment)
		{
			comment.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.Status = true;
			comment.BlogId = 2;

			_commentManager.CommentAdd(comment);

			return RedirectToAction("Blog","BlogDetails",comment.BlogId);
		}
		public PartialViewResult CommentListByBlogPartial(int id)
		{
			var values = _commentManager.GetComment(id);
			

			return PartialView(values);
		}
	}
}
