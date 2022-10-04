using Crm.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILayer.ViewComponents.Dashboard
{
    public class Chart : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.p1 = context.Products.Where(x => x.ProductID == 1).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.p2 = context.Products.Where(x => x.ProductID == 2).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.p3 = context.Products.Where(x => x.ProductID == 3).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.p4 = context.Products.Where(x => x.ProductID == 4).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.p5 = context.Products.Where(x => x.ProductID == 5).Select(y => y.ProductStock).FirstOrDefault();
            return View();
        }
    }
}
