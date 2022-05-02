using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.DTO
{
    public class AddressViewModel
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public GeoViewModel Geo { get; set; }
    }
}
