using System;
using System.Web.Mvc;
using StructureMap;

namespace Routing.Abstraction.IoC
{
	public class ControllerFactory : DefaultControllerFactory
	{
		protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
		{
			try
			{
				if (controllerType == null)
					return base.GetControllerInstance(requestContext, controllerType);

				return ObjectFactory.GetInstance(controllerType) as Controller;
			}
			catch (StructureMapException)
			{
				System.Diagnostics.Debug.WriteLine(ObjectFactory.WhatDoIHave());
				throw;
			}
		}
	}
}