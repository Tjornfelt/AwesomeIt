using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwesomeIt.Models;

namespace AwesomeIt.Controllers
{
    public class ProfileController : BaseController
    {
        public ActionResult MyPage()
        {
            var model = new MyPageModel();

            model.Header = "my page";
            model.BodyText = "bodytext";

            return base.Index(model);
        }
    }
}
