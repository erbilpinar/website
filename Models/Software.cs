using System;
using System.ComponentModel.DataAnnotations;

namespace MMS.Models
{
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FreeTrial { get; set; }
        public string StartingPrice { get; set; }
        public string Link { get; set; }
        public string Description { get; set;}
        public string Deployment { get; set;}
        public string Training { get; set;}
        public string Support { get; set;}
    }
}