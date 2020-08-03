using System.Collections.Generic;
using System.Web.Mvc;

namespace coderush.Controllers
{
	[Authorize(Roles = Services.App.Pages.Role.RoleName)]
    public class RoleController : Controller
    {
        private readonly Services.Security.ICommon _security;

        //dependency injection through constructor, to directly access services
        public RoleController(Services.Security.ICommon security)
        {
            _security = security;
        }

        //consume custom security service to get all roles
        public ActionResult Index()
        {
            List<string> roles = new List<string>();
            roles = _security.GetAllRoles();
            return View(roles);
        }
    }
}