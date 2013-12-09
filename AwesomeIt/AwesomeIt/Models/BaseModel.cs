using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeIt.Models
{
    public class BaseModel
    {
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public IEnumerable<Link> SideMenuUrls { get; set; }
        public IEnumerable<Link> MainMenuUrls { get; set; }
    }
}