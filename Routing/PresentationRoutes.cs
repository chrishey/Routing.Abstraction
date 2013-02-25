// -----------------------------------------------------------------------
// <copyright file="PresentationRoutes.cs" company="">
// McCann Manchester (Metro) 2013
// </copyright>
// -----------------------------------------------------------------------

using Routing.Abstraction.Controllers;

namespace Routing.Abstraction.Routing
{
	/// <summary>
	/// Class to register specific presentation routes and seperate these from other routes
	/// </summary>
	public class PresentationRoutes : IRouting
	{
		public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
		{
			routes.MapRoute<PresentationController>("default");
		}
	}
}
