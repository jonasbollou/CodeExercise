﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class helloworldController : ApiController
    {
        // GET api/helloworld
        public string Get()
        {
            return "Hello Word";
        }
    }
}
