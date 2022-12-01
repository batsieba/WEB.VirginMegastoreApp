using Microsoft.AspNetCore.Identity;
using VirginMegastoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace VirginMegastoreApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                    SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        //validation used to prevent CSRF(cross site request forgets) attacks
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel newuser)
        {
            if (ModelState.IsValid)
            {   //create a new application user object using the viewmodel data
                //since the applicationuser entity model is mapped to the DB table AspNetUser
                var user = new ApplicationUser
                {
                    FirstName = newuser.FirstName,
                    LastName = newuser.LastName,
                    UserName = newuser.Email,
                    Email = newuser.Email
                };
                //user CreateAync method to create a new user
                var result = await userManager.CreateAsync(user, newuser.Password);
                if (result.Succeeded)
                {//add the newly registered user to the "Member" Role
                    IdentityResult roleresult = await userManager.AddToRoleAsync(user, "Member");
                    //signin user and redirect to home page
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                //if any errors occured then add errors to the model state.
                foreach (var error in result.Errors)
                {   //errors will be display in the validation summary
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(newuser);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        //validation used to prevent CSRF(cross site request forgets) attacks
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginuser, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginuser.Email, loginuser.Password,
                                                                    loginuser.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl); //to prevent open redirect attack
                    }
                    else
                    {
                        return RedirectToAction("Index", "home");
                    }
                }
                //if signin is unsuccessful, add an error to the modelstate, 
                //it will be displayed in the validaiton summary
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(loginuser);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

    }
}
