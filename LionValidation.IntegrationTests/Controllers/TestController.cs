using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LionValidation.IntegrationTests.Models;
using LionValidation.ValidationAttributes;
using Newtonsoft.Json;

namespace LionValidation.IntegrationTests.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult StartTest(string id)
        {
            string modelName = id.EndsWith("_NoJS") ? id.Split('_')[0] : id;
            bool useServerValidationOnly = id.EndsWith("_NoJS");

            Type modelType = Type.GetType("LionValidation.IntegrationTests.Models." + modelName + "TestsModel");
            dynamic model = Activator.CreateInstance(modelType);
            model.UseServerValidationOnly = useServerValidationOnly;

            return View(model);
        }

        [HttpPost]
        public ActionResult StartTest(TestsBaseModel model, string ModelTypeString)
        {
            var modelType = Type.GetType(ModelTypeString);

            string serializedParent = JsonConvert.SerializeObject(model);
            dynamic correctlyTypedModel = JsonConvert.DeserializeObject(serializedParent, modelType);

            bool isValid = TryValidateModel(correctlyTypedModel);

            correctlyTypedModel.IsFinishedValidating = true;

            return View(correctlyTypedModel);
        }

    }
}
