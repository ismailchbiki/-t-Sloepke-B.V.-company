using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Dutch_Experience.Pages
{

    public class AddPostModel : PageModel
    {

        //[BindProperty]
        //public Content Content { get; set; }

        public void OnGet()
        {

        }

        //To set the files path
        private readonly IWebHostEnvironment _webHostEnv;
        public AddPostModel(IWebHostEnvironment webHostEnv)
        {
            _webHostEnv = webHostEnv;
        }


        //Add post OnPost
        //public IActionResult OnPost(User user, Content post, ContentManagementWebApp cManagement) //dependeny injection
        //{

        //    if (Content.ImageLocation != null)
        //    {
        //        /// <summary>
        //        /// IMAGE PATH CREATION
        //        /// </summary>

        //        //generate unique name for every uploaded image
        //        string uniqueImageName = null;

        //        //store image in a local file
        //        string folder = "ImagesUsers";

        //        //to store image as byte in the DB
        //        byte[] image = null;

        //        //get the physical name of the local folder
        //        string imgFolder = Path.Combine(_webHostEnv.WebRootPath, folder);

        //        //unique name generation
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

        //        /// <summary>
        //        /// FILE PATH CONVERSION TO BYTE FOR DB STORING
        //        /// </summary>
        //        /// 
        //        using (var fStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
        //        {
        //            //image conversion to byte for storing
        //            BinaryReader BinaryReaderStream = new BinaryReader(fStream);
        //            image = BinaryReaderStream.ReadBytes((int)fStream.Length);

        //            //direct post upload
        //            if (User.Identity.IsAuthenticated)
        //            {
        //                user.Username = User.Identity.Name;

        //                post = new Content(Content.PlaceName, Content.Province, user, Content.Description, image);

        //                cManagement.AddPost(post);


        //                //successful post upload confirmation
        //                Response.Cookies.Append("DirectPostUpload", "Thank you for sharing your experience ");
        //                return new RedirectToPageResult("Blog");
        //            }

        //            //else user must log in to share post
        //            else
        //            {
        //                //user.Username = User.Identity.Name;

        //                post = new Content(Content.PlaceName, Content.Province, user, Content.Description, image);

        //                //Content post = new Content();

        //                //post.PlaceName = Content.PlaceName;
        //                //post.ImageDB = image;
        //                //post.Province = Content.Province;
        //                //post.Description = Content.Description;

        //                //save post in a session till user is logged in
        //                HttpContext.Session.SetObjectAsJson("pendingPost", post);

        //                return new RedirectToPageResult("Login");
        //            }
        //        }
        //    }

        //    return Page();
        //}
    }
}


