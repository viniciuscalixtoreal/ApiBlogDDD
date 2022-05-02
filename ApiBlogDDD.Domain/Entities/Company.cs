using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Entities
{
    public class Company
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string BS { get; set; }
    }
}
