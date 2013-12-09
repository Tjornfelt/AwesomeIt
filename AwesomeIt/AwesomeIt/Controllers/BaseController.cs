using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwesomeIt.Models;

namespace AwesomeIt.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult Index(BaseModel model)
        {
            model.MetaTitle = "This is the title!";
            model.MetaDescription = "This is the description!";
            model.MetaKeywords = "These, are, the, keywords!";

            model.SideMenuUrls = PopulateSideMenu();
            model.MainMenuUrls = PopulateMainMenu();

            return View(model);
        }

        public IEnumerable<Link> PopulateSideMenu()
        {
            List<Link> links = new List<Link>();

            Link link1 = new Link() {
                Name = "Project 1",
                Url = "http://google.dk"
            };

            Link link2 = new Link()
            {
                Name = "Project 2",
                Url = "http://google.dk"
            };

            Link link3 = new Link()
            {
                Name = "Project 3",
                Url = "http://google.dk"
            };

            links.Add(link1);
            links.Add(link2);
            links.Add(link3);

            return links;
        }

        public IEnumerable<Link> PopulateMainMenu()
        {
            List<Link> links = new List<Link>();

            Link link1 = new Link()
            {
                Name = "Kontrolpanel",
                Url = "/"
            };

            Link link2 = new Link()
            {
                Name = "Min side",
                Url = "http://localhost:55035/profile/mypage"
            };

            Link link3 = new Link()
            {
                Name = "Logud",
                Url = "http://google.dk"
            };

            links.Add(link1);
            links.Add(link2);
            links.Add(link3);

            return links;
        }
    }
}
