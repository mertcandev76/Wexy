﻿using Microsoft.AspNetCore.Mvc;

namespace Wexy.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
