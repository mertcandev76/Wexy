using Microsoft.AspNetCore.Mvc;

namespace Wexy.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
