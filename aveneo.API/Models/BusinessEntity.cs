using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aveneo.API.Models
{
    public class BusinessEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string NIP { get; set; }
        public string KRS { get; set; }
        public string REGON { get; set; }
    }
}
