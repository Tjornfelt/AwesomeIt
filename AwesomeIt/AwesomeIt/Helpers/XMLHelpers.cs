using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using AwesomeIt.Models;

namespace AwesomeIt.Helpers
{
    public static class XMLHelpers
    {
        public static void SaveProject(Project p)
        {
            List<Project> pList = GetAllProjects();
            Project project = pList.SingleOrDefault(x => x.ProjectName == p.ProjectName);
            pList.Remove(project);
            pList.Add(p);
            AwesomeIt.Models.FileInfo fInfo = GetFileInfo();

            var serializer = new XmlSerializer(typeof(List<Project>));
            using (var writer = XmlWriter.Create(fInfo.FilePath))
            {
                serializer.Serialize(writer, pList);
            }
        }

        public static List<Project> GetAllProjects()
        {
            AwesomeIt.Models.FileInfo fInfo = GetFileInfo();

            if (!fInfo.Exists)
            {
                File.Create(fInfo.FilePath);
            }

            var serializer = new XmlSerializer(typeof(List<Project>));
            List<Project> p;

            try
            {
                using (var reader = XmlReader.Create(fInfo.FilePath))
                {
                    p = (List<Project>)serializer.Deserialize(reader);
                }
            }
            catch (Exception whoCares)
            {
                //If the projects.xml is empty, an exception is cast. In this case, just return an empty list.
                return new List<Project>();
            }
            return p;
        }
        /*
        public static ProjectModel GetProject(string projectName)
        {
            
            AwesomeIt.Models.FileInfo fInfo = GetFileInfo(projectName);

            var serializer = new XmlSerializer(typeof(ProjectModel));
            ProjectModel p;
            using (var reader = XmlReader.Create(fInfo.FilePath))
            {
                p = (ProjectModel)serializer.Deserialize(reader);
            }
            return p;
        }*/

        private static AwesomeIt.Models.FileInfo GetFileInfo()
        {
            string savepath = HttpContext.Current.Request.MapPath(HttpContext.Current.Request.ApplicationPath) + "\\ ";
            string xmlFileName = "projects.xml";
            string filePath = savepath + "\\" + xmlFileName;

            AwesomeIt.Models.FileInfo f = new AwesomeIt.Models.FileInfo();

            f.Exists = File.Exists(filePath);
            f.FilePath = filePath;
            return f;
        }
    }
}