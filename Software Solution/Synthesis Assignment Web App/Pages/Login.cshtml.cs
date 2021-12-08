using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dutch_Experience.Pages
{
    public class LoginModel : PageModel
    {

        //[BindProperty]
        //public User NewUser { get; set; }

        ////Popup notification
        //public string Notification; //either this way or viewdata[""]


        ////promt the user to log in to complete the post upload
        //public void OnGet()
        //{
        //    // in case there is a pending post to submit
        //    if (HttpContext.Session.GetObjectFromJson<Content>("pendingPost") != null)
        //    {
        //        ViewData["loginRequired"] = "Thank you for sharing your experience. Please log in to complete the upload";
        //    }
        //}

        ////Sign up
        //public IActionResult OnPost(User user, DutchExperienceClassLib.Validation validate, UserManagement userManagement)//dependency injection
        //{
        //    try
        //    {
        //        //in case of an issue
        //        if (!ModelState.IsValid) return Page();

        //        user = new User(NewUser.Username, NewUser.Nationality, NewUser.Email, validate.HashPassword(NewUser.Password));

        //        //prevent duplicate usernames creation
        //        if (validate.IsUsernameDuplicate(user.Username))
        //        {
        //            Notification = "Username already exists. Choose a unique username";
        //            return Page();

        //        }

        //        //prevent duplicate emails creation
        //        else if (validate.IsEmailDuplicate(NewUser.Email))
        //        {
        //            Notification = "Email already exists. Choose a unique email";
        //            return Page();
        //        }

        //        //Add user
        //        else
        //        {
        //            //password salting
        //            //string salt = Crypto.GenerateSalt();
        //            //string saltingAndHasingPassW = NewUser.Password + salt;

        //            userManagement.AddUser(user);
        //            Notification = "Your account is successfully created";

        //            return Page();
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Notification = ex.Message;
        //    }

        //    return null;
        //}

        ////Sign in

        ////What async-await is useful for is allowing the calling function to continue doing other things
        ////while the asynchronous function is awaiting,
        ////as opposed to synchronous("normal") functions that blocks the calling function until completion.

        //public async Task<IActionResult> OnPostLoginAsync(DutchExperienceClassLib.Validation validate, UserManagement userManagement) // dependency injection
        //{

        //    foreach (User user in userManagement.Users())
        //    {

        //        //verify the credential
        //        if (NewUser.Username == user.Username && validate.HashPassword(NewUser.Password) == user.Password)
        //        {
        //            Notification = "Successful Login";

        //            //get the username of the logged in user (in case of a post submission)
        //            HttpContext.Session.SetString("online", user.Username.ToString());

        //            // -----------------------------------------------------Security context generation

        //            //Create the security context (Authentication)
        //            //adding claims for Authentication and authorization
        //            List<Claim> claims = new List<Claim>();
        //            claims.Add(new Claim(ClaimTypes.Name, NewUser.Username));
        //            claims.Add(new Claim("Role", NewUser.Username));
        //            //claims.Add(new Claim("Role", "member")); //for later use

        //            //declare and instantiate an identity (primary identity)
        //            var identity = new ClaimsIdentity(claims, "MyCookieAuth");

        //            //Now the claimsprincipal contains the security context
        //            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

        //            // -----------------------------------------------------Serialization of the security context (claimsprincipal) into a string and encrypting it and saving it as a cookie in httpcontext

        //            //specifying the authentication scheme (authentication type)
        //            //(it will throw an exception: (No sign-in authentication handlers are registered...)=> lack of a handler
        //            //until there is a concrete implementation of IAuthenticateService interface in startup file) (which is done)
        //            await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

        //            //redirect user back to blog page after logging in (in case of the existing of a pending post)
        //            if (HttpContext.Session.GetObjectFromJson<Content>("pendingPost") != null)
        //            {
        //                return new RedirectToPageResult("Blog");
        //            }

        //            return new RedirectToPageResult("Profile");
        //        }
        //    }

        //    Notification = "Incorrect username or password";
        //    return Page();
        //}
    }
}
