﻿using CalCli.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalDav.Client
{
    public class XHttpWebResponse
    {
        public XHttpWebResponse(System.Net.HttpStatusCode httpStatusCode, string responseContent, ResponseHeaders responseHeaders)
        {
            HttpStatusCode = httpStatusCode;
            ResponseContent = responseContent;
            ResponseHeaders = responseHeaders;
        }

        public System.Net.HttpStatusCode HttpStatusCode;
        public string ResponseContent;
        public ResponseHeaders ResponseHeaders;
    }
}
