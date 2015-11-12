using DI.Core.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Infrastructure.Services
{
	public class ServiceModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IDisplayMessageService>().To<ConsoleDisplayMessageService>();
		}
	}
}
