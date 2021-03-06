﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnitOfWork.Models
{
	public interface IWeDbbContext : IDisposable
	{

	}

	public class WebDbContext : DbContext, IWeDbbContext
	{
		public DbSet<Article> Articles { get; set; }

		public WebDbContext()
			: base("name=connectionStr")
		{
			Configuration.LazyLoadingEnabled = false;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new ArticleMapping());
			base.OnModelCreating(modelBuilder);
		}

		public new void Dispose()
		{
		}
	}
}