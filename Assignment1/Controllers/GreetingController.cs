using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {

        //curl  api/Greeting
        public String Post()
        {
            return "Hello World!";
        }

        public String Get(int id)
        {
            return "Greeting to " + id + " people";
        }
    }
}
