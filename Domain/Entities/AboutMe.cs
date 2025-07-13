using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AboutMe
    {
        public int AboutMeId { get; set; }
        public string AboutTitle { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public string TechTitle { get; set; }
        public string TechDescription { get; set; }
        public string TargetDescription { get; set; }
        public string ContactTitle { get; set; }

        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Github { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }


    }
}
