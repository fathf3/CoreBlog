using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>()
            {
                new UserComment
                {
                    Id = 1,
                    userName = "Test",
                },
                new UserComment
                {
                    Id = 2,
                    userName = "Test2",
                },
                new UserComment
                {
                    Id = 3,
                    userName = "Test3",
                }
            };
            return View(values);
        }
    }
}
