using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using RoundPanelValidation.Models;

namespace DevExpress.Razor.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult DXControlValidation(){
            return View("DXControlValidation", new Person());
        }
        public ActionResult DXControlValidationPartial([ModelBinder(typeof(DevExpressEditorsBinder))] Person person) {
            return ValidationInternal(person, "SuccessValidation", "DXControlValidationPartial");
        }
        public ActionResult StandardControlValidation() {
            return View("StandardControlValidation", new Person());
        }
        public ActionResult StandardControlValidationPartial([ModelBinder(typeof(DevExpressEditorsBinder))] Person person) {
            return ValidationInternal(person, "SuccessValidation", "StandardControlValidationPartial");
        }

        public ActionResult SuccessValidation() {
            return View("SuccessValidation");
        }

        ActionResult ValidationInternal(Person person, string successAction, string typeAction){
            if (ModelState.IsValid) 
                return View(successAction);

            return View(typeAction, person);

        }
    }
}
