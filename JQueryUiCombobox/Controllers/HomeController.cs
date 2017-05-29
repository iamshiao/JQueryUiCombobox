using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CircleHsiao.Demo.JQueryUiCombobox.ViewModels;

namespace CircleHsiao.Demo.JQueryUiCombobox.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<SelectListItem> _options = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "option1", Value = "1" },
            new SelectListItem() { Text = "option2", Value = "2" },
            new SelectListItem() { Text = "option3", Value = "3" }
        };

        public ActionResult Index()
        {
            var vm = new JQueryUiComboboxViewModel();
            vm.Options = _options;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(JQueryUiComboboxViewModel vm)
        {
            var selectedVal = vm.SelectedValue;
            vm.Options = _options;
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}