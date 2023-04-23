using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICommentService
    {
        void addComment(Comment comment);
        void deleteComment(Comment comment);
        void updateComment(Comment comment);
        List<Comment> getAllComments(int id);

        Comment getCommentById(int id);

    }
}
