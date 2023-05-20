using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		Context context=new();

		public List<T> GetAll()
		{
			return context.Set<T>().ToList();
		}

		public List<T> GetAll(Expression<Func<T, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public T GetById(int id)
		{
			return context.Set<T>().Find(id);
		}

		public void Insert(T item)
		{
			context.Add(item);
			context.SaveChanges();
		}

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			return context.Set<T>().Where(filter).ToList();
		}

		public void Remove(T item)
		{
			context.Remove(item);
			context.SaveChanges();
		}

		public void Update(T item)
		{
			context.Update(item);
			context.SaveChanges();
		}
	}
}
