using Microsoft.AspNetCore.Mvc;

namespace Wexy.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
