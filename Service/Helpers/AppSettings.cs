using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers
{
    public class AppSettings
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}
