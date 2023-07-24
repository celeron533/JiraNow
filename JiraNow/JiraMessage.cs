using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow
{
    internal class JiraMessage
    {
        public HttpStatusCode httpStatusCode { get; set; }
        public string jsonMessage { get; set; }
        public bool isSuccess { get; set; }
    }
}
