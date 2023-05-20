﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager blogManager=new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			var values = blogManager.GetBlogListWithCategory();

			return View(values);
		}

		public IActionResult BlogDetails(int id)
		{
			var values=blogManager.GetBlog(id);

			return View(values);
		}
	}
}
