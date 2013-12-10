using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwesomeIt.Models;

namespace AwesomeIt.Controllers
{
    //Inherit from the BaseController - we use the base controller to set global values, such as meta tags.
    public class FrontpageController : BaseController
    {
        public ActionResult Frontpage()
        {
            var model = new FrontpageModel();
            model.Header = "Kontrolpanel";
            model.BodyText = "Velkommen  til Awesome IT's projektstyringsværktøj. Til venstre kan du se en liste over alle oprettede projekter. Du kan også se en liste over arkiverede projekter, ved at klikke på \"Arkiverede Projekter\". Herunder kan du oprette nye projekter";

            //Return the model to the Index method of the inherited class (BaseController). From there, we will set base values into the model
            //and return the result to the view. The view will still use the "Frontpage" from this controller. 
            return base.Index(model);
        }
    }
}
