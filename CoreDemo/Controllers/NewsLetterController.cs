using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager manager=new(new EfNewsLetterRepository());

		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}


		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;

			manager.AddNewsLetter(newsLetter);

			return RedirectToAction("Index","Blog");
		}
	}
}
