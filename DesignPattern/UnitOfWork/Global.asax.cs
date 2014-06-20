﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using UnitOfWork.Dependency;

namespace UnitOfWork
{
	// 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
	// 请访问 http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		private readonly IWindsorContainer container;
		public MvcApplication()
		{
			this.container = new WindsorContainer().Install(new DependencyConventions());
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			var controllerFactory = new WindsorControllerFactory(container.Kernel);
			ControllerBuilder.Current.SetControllerFactory(controllerFactory);
		}
		public override void Dispose()
		{
			this.container.Dispose();
			base.Dispose();
		}
	}
}