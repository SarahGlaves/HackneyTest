using System;
using Microsoft.EntityFrameworkCore;

namespace PostCode.Models
{
    public class PostCodeContext : DbContext
    {
        public PostCodeContext(DbContextOptions<PostCodeContext> options)
            : base(options)
        {
        }

        public DbSet<AddressItem> AddressItems { get; set; }
    }
}
