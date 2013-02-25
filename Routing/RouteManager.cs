using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Reflection;

namespace Routing.Abstraction.Routing
{
	public class RouteManager
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			var routings =
				Assembly.GetExecutingAssembly().GetTypes().Where(x => typeof (IRouting).IsAssignableFrom(x) && x.IsClass).ToList();

			routings.ForEach(r=>
			                 	{
			                 		if (r.FullName != null)
			                 			((IRouting)
			                 			 Activator.CreateInstance(Assembly.GetExecutingAssembly().FullName, r.FullName).Unwrap()).
			                 				RegisterRoutes(routes);
			                 	});
		}
	}
}