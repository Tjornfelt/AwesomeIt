using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwesomeIt.Helpers;
using AwesomeIt.Models;

namespace AwesomeIt.Controllers
{
    public class ProjectsController : BaseController
    {
        public ActionResult NewProject(NewProjectForm form)
        {
            var model = new NewProjectModel();

            if (form.ProjectName == null)
            {

                model.Header = "Create a new project!";
                model.BodyText = "Create a new project here, and invite people to take part.";
                model.NewProjectForm = new NewProjectForm();
            }
            else
            {
                var projectModel = new Project() { ProjectName = form.ProjectName };

                XMLHelpers.SaveProject(projectModel);

                model.Header = "Du har oprettet et nyt projekt";
                model.BodyText = "Klik <a href=\"/projects/project/" + form.ProjectName + "\">HER</a> for at navigere hen til dit nye projekt, og inviterer folk til det!";
            }

            return base.Index(model);
        }

        public ActionResult Project(string id)
        {
            var project = XMLHelpers.GetAllProjects().FirstOrDefault(x => x.ProjectName == id);
            var model = new ProjectModel();
            model.ProjectName = project.ProjectName;
            model.Archived = project.Archived;
            return base.Index(model);
        }

        public ActionResult Archive(string id)
        {
            
            var project = XMLHelpers.GetAllProjects().FirstOrDefault(x => x.ProjectName == id);

            project.Archived = true;

            XMLHelpers.SaveProject(project);

            var model = new ArchiveModel();
            model.Header = project.ProjectName + " er blevet arkiveret!"; 
            return base.Index(model);
        }
    }
}