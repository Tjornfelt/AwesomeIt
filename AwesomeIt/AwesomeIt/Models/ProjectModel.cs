using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeIt.Models
{
    public class ProjectModel : BaseModel
    {
        public string ProjectName { get; set; }
        public bool Archived { get; set; }
    }
}