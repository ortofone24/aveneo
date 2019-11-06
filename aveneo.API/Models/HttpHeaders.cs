using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aveneo.API.Models
{
    public class HttpHeaders
    {
        public int Id { get; set; }
        public string Accept { get; set; }
        public string AcceptEncoding { get; set; }
        public string AcceptLanguage { get; set; }
        public string Connection { get; set; }
        public string Host { get; set; }
        public string Referer { get; set; }
        public string UserAgent { get; set; }
        public string Origin { get; set; }
        public string Dnt { get; set; }
        public string SecFetchSite { get; set; }
        public string SecFetchMode { get; set; }
        public string Url { get; set; }
    }
}
