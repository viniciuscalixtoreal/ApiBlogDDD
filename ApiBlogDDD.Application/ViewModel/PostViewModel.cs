﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
