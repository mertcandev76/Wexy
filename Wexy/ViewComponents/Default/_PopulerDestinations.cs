﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Wexy.ViewComponents.Default
{
    public class _PopulerDestinations:ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
