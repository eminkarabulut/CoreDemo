using System;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
	public class WriterViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Yazar adı soyadı kısmı boş geçilemez.")]
		[MinLength(3, ErrorMessage = "Lütfen en az 3 karakterlik veri girişi yapın.")]
		[MaxLength(50, ErrorMessage = "Lütfen en fazla 50 karakterlik veri girişi yapın.")]
		public string Name { get; set; }
		public string About { get; set; }
		public string Image { get; set; }

		[Required(ErrorMessage = "Email boş geçilemez.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Şifre boş geçilemez.")]
		public string Password { get; set; }
		public bool Status { get; set; }
	}
}
