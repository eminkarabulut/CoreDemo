using AutoMapper;
using BusinessLayer.ViewModels;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
	public class ViewModelMapping:Profile
	{
        public ViewModelMapping()
        {
			CreateMap<Writer, WriterViewModel>().ReverseMap();

		}
       

	}
}
