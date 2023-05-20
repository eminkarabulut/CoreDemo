using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Comment comment);
		//void CommentRemove(Comment comment);
		//void CommentUpdate(Category comment);
		List<Comment> GetAllComments();
		Comment GetComment(int id);
	}
}
