using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.ViewModels
{
    public class CommentsViewModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Emaill { get; set; }
        public string Body { get; set; }
    }
}
