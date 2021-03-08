using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools.Http
{
    public abstract class BaseRequest
    {
        public string Resource;
        public Method Method;
        public Dictionary<string, string> Headers;
        public Dictionary<string, string> Body;
        public Dictionary<string, string> QueryStringParams;
        
        public BaseRequest(string resource, Method method)
        {
            this.Resource = resource;
            this.Method = method;
        }        
    }
}
