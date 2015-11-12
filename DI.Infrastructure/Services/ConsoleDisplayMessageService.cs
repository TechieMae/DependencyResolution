using DI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Infrastructure.Services
{
	public class ConsoleDisplayMessageService : IDisplayMessageService
	{
		public string ShowMessage()
		{
			return "Test";
		}
	}
}
