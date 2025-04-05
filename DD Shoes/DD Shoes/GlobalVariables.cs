using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace DD_Shoes
{
    public static class GlobalVariables
    {
        public static HttpClient WebClient = new HttpClient();

        static GlobalVariables()
        {
            WebClient.BaseAddress = new Uri("https://localhost:44322/api/");
            WebClient.DefaultRequestHeaders.Clear();
            WebClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}