using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneToZeroOrOne.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public string CartName { get; set; }
        //public int? StudentAddressID { get; set; }

        public virtual CartPrecinct CartPrecinct { get; set; }
    }
}