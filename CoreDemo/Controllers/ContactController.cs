﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
	public class ContactController : Controller
	{
		ContactManager contactManager=new(new EfContactRepository());
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
			contact.Status = true;
			
			contactManager.ContactAdd(contact);

			return RedirectToAction("Index","Contact");
		}
	}
}
