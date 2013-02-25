using System.Web.Routing;

namespace Routing.Abstraction.Routing
{
	public interface IRouting
	{
		void RegisterRoutes(RouteCollection routes);
	}
}
