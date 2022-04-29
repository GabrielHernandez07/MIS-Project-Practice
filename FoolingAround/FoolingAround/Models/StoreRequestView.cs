using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoolingAround.Models
{
    public class StoreRequestView
    {
        public List<Request> RequestClass { get; set; }
        public FoolingAround.Models.Request RequestName { get; set; }
        public FoolingAround.Models.Store StoreClass { get; set; }
    }
}