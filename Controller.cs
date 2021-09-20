using Microsoft.AspNetCore.Mvc;

namespace Controllers {
	namespace Api {
		[Route("")]
		public class ApiController : Controller {
			[HttpGet]
			[Route("")]
			public string States() {
				return "This is just Demo Deployment";
			}
		}
	}
}