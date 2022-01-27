using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<String> Get(int id)
        {
            double cost;
            double hst;
            int numb;
            double total;

            numb = (id/14)+1;
            cost=5.5*numb;
            hst = Math.Round((double)cost * 13/100,2 );

            total = cost + hst;

            return new String[] { numb + " Fortnights at $5.50/FN = $" + cost + " CAD" , "HST 13% = $" + hst + " CAD", "total = $" + total + " CAD" };
        }
    }
}
