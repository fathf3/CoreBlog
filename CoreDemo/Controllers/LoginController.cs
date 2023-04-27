using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;



namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {


            ClaimsPrincipal claims = HttpContext.User;
            if(claims.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Writer");


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context context = new Context();
            var dataValue = context.Writers.FirstOrDefault(x => x.writerMail == writer.writerMail &&
            x.writerPassword == writer.writerPassword);
            if (dataValue != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, writer.writerMail),
                    new Claim("OtheProperties", "Example Role")
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true

                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity), properties);

                return RedirectToAction("Index", "Writer");
            }
            else
            {
                ViewData["ValidateMessage"] = "user not found";
                return View();
            }
            
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

    }
}
