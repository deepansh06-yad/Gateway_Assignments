using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HRM
{
    public static class GlobalVariable
    {
        public static HttpClient webapiclient = new HttpClient();
        static GlobalVariable()
        {
            webapiclient.BaseAddress = new Uri("http://localhost:44588/api/");
            webapiclient.DefaultRequestHeaders.Clear();
            webapiclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
