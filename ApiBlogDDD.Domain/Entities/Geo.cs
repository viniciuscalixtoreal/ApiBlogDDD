using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Entities
{
    public class Geo
    {
        //public int Id { get; set; }
        public string Lat { get; set; }
        
        public string Lng { get; set; }
    }
}
