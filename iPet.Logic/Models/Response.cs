using System;
namespace iPet.Logic.Models
{
    public class Response
    {
		public bool success { get; set; }
		public string authToken { get; set; }
		public string email { get; set; }
        public string zone { get; set; }
    }
}
