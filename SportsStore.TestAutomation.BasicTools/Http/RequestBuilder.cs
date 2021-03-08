using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace SportsStore.TestAutomation.BasicTools.Http
{
    class RequestBuilder
    {
        BaseRequest requestData;
        RestRequest request;
        public RequestBuilder(BaseRequest requestData)
        {
            this.requestData = requestData;
            request = new RestRequest();
        }

        public RequestBuilder SetUri()
        {
            request.Resource = requestData.Resource;
            return this;
        }

        public RequestBuilder SetMethod()
        {
            request.Method = requestData.Method;
            return this;
        }

        public RequestBuilder AddHeaders(Dictionary<string, string> headers)
        {
            if (headers.Count != 0)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }
            return this;
        }

        public RequestBuilder AddRequestBody(Dictionary<string, string> body)
        {
            if (body.Count != 0)
            {
                foreach (var parameter in body)
                {
                    request.AddParameter(parameter.Key, parameter.Value);
                }
            }
            return this;
        }

        public RequestBuilder AddQuieryStringParams(Dictionary<string, string> queryStringParams)
        {
            if (queryStringParams.Count != 0)
            {
                foreach (var queryStringParam in queryStringParams)
                {
                    request.AddParameter(queryStringParam.Key, queryStringParam.Value);
                }
            }
            return this;
        }

        public RestRequest Build()
        {
            return request;
        }
    }
}
