using ApiBlogDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Infra.Data.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}
