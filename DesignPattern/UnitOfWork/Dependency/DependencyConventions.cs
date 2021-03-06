﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitOfWork.Models;
using UnitOfWork.Controllers;
using System.Web.Http.Controllers;

namespace UnitOfWork.Dependency
{
	public class DependencyConventions : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Classes.FromThisAssembly().BasedOn<IController>()
				.LifestyleTransient());

			container.Register(
				Component.For<IUnitOfworkManager>().ImplementedBy<UnitOfworkManager>(),
				Component.For<IArticleRepository, ArticleRepository>().ImplementedBy<ArticleRepository>(),
				Component.For<IUnitOfWork, UnitOfWork.Models.UnitOfWork>().ImplementedBy<UnitOfWork.Models.UnitOfWork>(),
				Component.For<IWeDbbContext,WebDbContext>().ImplementedBy<WebDbContext>()
				);
		}
	}
}