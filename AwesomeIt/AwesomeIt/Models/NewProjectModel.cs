using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeIt.Models
{
    public class NewProjectModel : BaseModel
    {
        public string Header { get; set; }
        public string BodyText { get; set; }
        public NewProjectForm NewProjectForm { get; set; }
    }
}