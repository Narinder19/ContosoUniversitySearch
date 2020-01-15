using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToZeroOrOne.Models
{
    public class CartPrecinct
    {
        [ForeignKey("Cart")]
        public int CartPrecinctID { get; set; }
        public int PrecinctNumber { get; set; }
        public string PrecinctName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public virtual Cart Cart { get; set; }


    }
}
