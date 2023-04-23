using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void addComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void deleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> getAllComments(int id)
        {
            return _commentDal.getListAll(x => x.blogId == id);
        }

        public Comment getCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public void updateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
