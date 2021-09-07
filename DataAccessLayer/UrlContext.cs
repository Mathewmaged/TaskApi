using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class UrlContext : DbContext
    {
			public UrlContext(DbContextOptions options) : base(options)
			{
			}
			public UrlContext() : base()
			{ }
			public virtual DbSet<Urls> Urls { get; set; }
	}
}
