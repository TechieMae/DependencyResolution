using DI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DI.Web.Controllers
{
    public class HomeController : Controller
    {
		private IDisplayMessageService _displayMessageService;

		public HomeController(IDisplayMessageService displayMessageService)
		{
			_displayMessageService = displayMessageService;
		}

        //
        // GET: /Home/
        public ActionResult Index()
        {
			return Content(_displayMessageService.ShowMessage());
        }
	}
}