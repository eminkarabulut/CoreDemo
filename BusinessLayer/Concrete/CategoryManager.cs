using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void CategoryAdd(Category category)
		{
			_categoryDal.Insert(category);
		}

		public void CategoryRemove(Category category)
		{
			_categoryDal.Remove(category);
		}

		public void CategoryUpdate(Category category)
		{
			_categoryDal.Update(category);
		}

		public List<Category> GetAllCategories()
		{
			return _categoryDal.GetAll();
		}

		public Category GetCategory(int id)
		{
			return _categoryDal.GetById(id);
		}
	}
}
