﻿using ApiBlogDDD.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public Company Company { get; set; }
    }
}
