using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{

		
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			Context context = new Context();
			var dataValue= context.Writers.FirstOrDefault(x=> x.Email==writer.Email && x.Password==writer.Password);

			if (dataValue!=null)
			{
				HttpContext.Session.SetString("username", writer.Email);

				return RedirectToAction("Writer", "Index");
			}

			return View();
		}
	}
}
