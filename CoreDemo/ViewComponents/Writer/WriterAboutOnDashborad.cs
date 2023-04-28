using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    

    public class WriterAboutOnDashborad : ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = writerManager.getWriterById(5);
            return View(values);
        }
    }
}
