using Crm.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILayer.ViewComponents.Dashboard
{
    public class Widgets : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v = context.Categories.Count();
            ViewBag.v2 = context.Products.Count();
            return View();
        }
    }
}
