using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing.Abstraction.Routing
{
	public static class RouteExtensions
	{
		public static void MapRoute<T>(this RouteCollection routes, string key = "", string path = "", Expression<Func<T, ActionResult>> actionMethod = null, object defaultValues = null, object constraints = null, string[] namespaces = null) where T : IController
		{
			var controller = typeof(T).Name.Replace("Controller", "");

			routes.MapRoute(string.IsNullOrEmpty(key) ? Guid.NewGuid().ToString() : key, path, new { controller = controller, action = (actionMethod == null ? "Index" : ((MethodCallExpression)actionMethod.Body).Method.Name) }, constraints, namespaces);
		}  
	}
}