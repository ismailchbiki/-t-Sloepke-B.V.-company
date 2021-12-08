using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dutch_Experience.Pages
{
    [Authorize(Policy = "MustBeAdmin")]
    public class AddPostAdminModel : PageModel
    {
        //[BindProperty]
        //public Content Content { get; set; }

        //public void OnGet()
        //{

        //}

        ////To set the files path
        //private readonly IWebHostEnvironment _webHostEnv;
        //public AddPostAdminModel(IWebHostEnvironment webHostEnv)
        //{
        //    _webHostEnv = webHostEnv;
        //}


        ////Add post OnPost
        //public IActionResult OnPost(User user, Content post, ContentManagementWebApp cManagement) //dependency injection
        //{
        //    if (Content.ImageLocation != null)
        //    {
        //        //image new path creation
        //        string uniqueImageName = null;
        //        string folder = "ImagesUsers";

        //        byte[] image = null;

        //        //put the image in this folder
        //        string imgFolder = Path.Combine(_webHostEnv.WebRootPath, folder);

        //        //Generate a unique name for the image
        //        uniqueImageName = Guid.NewGuid().ToString() + "_" + Content.ImageLocation.FileName;

        //        //combine the unique name with the folder to have the complete path
        //        string imagePath = Path.Combine(imgFolder, uniqueImageName);


        //        using (var fileStream = new FileStream(imagePath, FileMode.Create))
        //        {
        //            //copy to file
        //            Content.ImageLocation.CopyTo(fileStream);

        //            //close the process after the creation of the new path
        //            fileStream.Close();
        //        }

        //        //Convert file to byte to store in the DB
        //        using (var fStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
        //        {
        //            //image conversion to byte for storing
        //            BinaryReader BinaryReaderStream = new BinaryReader(fStream);
        //            image = BinaryReaderStream.ReadBytes((int)fStream.Length);

        //            //add post to the DB
        //            //using session (timeout 20 minutes)
        //            if (HttpContext.Session.Get("online") != null)
        //            {
        //                user.Username = HttpContext.Session.GetString("online");
        //                post = new Content(Content.PlaceName, Content.Province, user, Content.Description, Content.ImageDB);

        //                cManagement.AddPost(post);

        //                ViewData["message"] = "Thank you for sharing your experience";

        //                CookieOptions cOptions = new CookieOptions();

        //                Response.Cookies.Append("directPostUpload", "Thank you for sharing your experience");

        //                return new RedirectToPageResult("Blog");
        //            }
        //            else
        //            {
        //                //Content pendingPost = new Content();

        //                post.PlaceName = Content.PlaceName;
        //                post.ImageDB = image;
        //                post.Province = Content.Province;
        //                post.Description = Content.Description;

        //                //save post in a session until user is logged in
        //                HttpContext.Session.SetObjectAsJson("pendingPost", post);

        //                return new RedirectToPageResult("Login");
        //            }
        //        }
        //    }

        //    return Page();
        //}
    }
}
