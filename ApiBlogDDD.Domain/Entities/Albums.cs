using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Entities
{
    public class Albums
    {
        //public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
    }
}
