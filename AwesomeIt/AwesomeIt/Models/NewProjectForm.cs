using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AwesomeIt.Models
{
    public class NewProjectForm
    {
        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
    }
}