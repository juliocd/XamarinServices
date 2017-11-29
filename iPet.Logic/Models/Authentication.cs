using System;
namespace iPet.Logic.Models
{
    public class Authentication
    {
		public string latitude { get; set; }
		public string longitude { get; set; }
        public string userLatitude { get; set; }
        public string userLongitude { get; set; }
        public string idType { get; set; }
        public string radioInKms { get; set; }
        public String[] filterProperties { get; set; }
    }
}
