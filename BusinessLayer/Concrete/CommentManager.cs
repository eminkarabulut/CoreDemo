using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		private readonly ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentAdd(Comment comment)
		{
			_commentDal.Insert(comment);
		}

		public List<Comment> GetComments(int id)
		{
			return _commentDal.GetListAll(x=>x.BlogId==id);
		}

		public Comment GetComment(int id)
		{
			return _commentDal.GetById(id);
		}

		public List<Comment> GetAllComments()
		{
			throw new NotImplementedException();
		}
	}
}
