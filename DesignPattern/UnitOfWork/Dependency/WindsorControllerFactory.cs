﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel;
using System.Web.Mvc;

namespace UnitOfWork.Dependency
{
	public class WindsorControllerFactory : DefaultControllerFactory
	{
		private readonly IKernel kernel;

		public WindsorControllerFactory(IKernel kernel)
		{
			this.kernel = kernel;
		}

		public override void ReleaseController(IController controller)
		{
			kernel.ReleaseComponent(controller);
		}

		protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
		{
			if (controllerType == null)
				throw new HttpException(404, string.Format("The controller for path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
			return (IController)kernel.Resolve(controllerType);
		}
	}
}