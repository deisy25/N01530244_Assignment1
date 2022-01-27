using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        // GET api/AddTen/5
        public int Get(int id)
        {
            return (id + 10);
        }
    }

    public class SquareController : ApiController
    {
        // GET api/Square/5
        public int Get(int id)
        {
            return (id * id);
        }
    }

    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return id * 20 / 5 + 30 - 25;
        }
    }
}