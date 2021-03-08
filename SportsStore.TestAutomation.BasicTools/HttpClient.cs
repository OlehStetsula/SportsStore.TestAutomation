using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace SportsStore.TestAutomation.BasicTools
{
    class HttpClient
    {
        public IRestClient  client { get; set; }

        public HttpClient (string baseUrl)
        {
            client = new RestClient();
            client.BaseUrl = new Uri(baseUrl);            
        }
    }
}
