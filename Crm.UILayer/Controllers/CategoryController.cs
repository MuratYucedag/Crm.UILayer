using Crm.BusinessLayer.Abstact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILayer.Controllers
{
    public class CategoryController : Controller
    {
        //AJAX

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListCategory()
        {
            var values = JsonConvert.SerializeObject(_categoryService.TGetListAll());
            return Json(values);
        }
    }
}
