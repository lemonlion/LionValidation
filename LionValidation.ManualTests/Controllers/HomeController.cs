using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using LionValidation.ManualTests.Models;

namespace LionValidation.ManualTests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new BaseModel{SixthValueToTest = new BaseModelChild{ChildField1 = new BaseModelGrandChild()}});
        }

        [HttpPost]
        public ActionResult Index(BaseModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            else
                return View(model);
        }
    }
}