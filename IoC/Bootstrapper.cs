using Routing.Abstraction.Routing;
using StructureMap;

namespace Routing.Abstraction.IoC
{
	public class Bootstrapper
	{
		public static void Bootstrap()
		{
			ObjectFactory.Initialize(x => x.For<IRouting>().Use<PresentationRoutes>());
		}
	}
}