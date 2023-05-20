using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager _writerManager=new(new EfWriterRepository());
		private readonly IMapper _mapper;

		public RegisterController(IMapper mapper)
		{
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(WriterViewModel writer)
		{
			if (ModelState.IsValid)
			{
				writer.Status = true;
				writer.About = "test";

				_writerManager.WriterAdd(_mapper.Map<Writer>(writer));

				return RedirectToAction("Index", "Blog");
			}

			return View();
			
		}
	}
}
