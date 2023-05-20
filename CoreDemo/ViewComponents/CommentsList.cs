using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
	public class CommentsList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues=new List<UserComment>()
			{
				new (){Id=1,Username="emin"},
				new (){Id=2,Username="merve"}
			};
			return View(commentValues);
		}
	}
}
