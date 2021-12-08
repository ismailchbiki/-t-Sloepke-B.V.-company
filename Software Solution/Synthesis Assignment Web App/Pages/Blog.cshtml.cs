using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dutch_Experience.Pages
{
    public class BlogModel : PageModel
    {

        //List to share with the end-user (Blog)
        //public List<Content> Posts;

        //public void OnGet(User user, Content post, ContentManagementWebApp cManagement, DALContent dalContent)// dependency injection
        //{

        //    //upload new post to the DB before showing all the posts in case of a pending post
        //    if (HttpContext.Session.GetObjectFromJson<Content>("pendingPost") != null)
        //    {
        //        //get pending post from session
        //        post = HttpContext.Session.GetObjectFromJson<Content>("pendingPost");
        //        user.Username = User.Identity.Name;
        //        post = new Content(post.PlaceName, post.Province, user, post.Description, post.ImageDB);

        //        //add post to the DB
        //        //user.Username = HttpContext.Session.GetString("online");

        //        cManagement.AddPost(post);
        //        ViewData["confirmationNote"] = "Thank You For Sharing Your Experience " + User.Identity.Name;

        //        //clear session
        //        HttpContext.Session.SetObjectAsJson("pendingPost", null);

        //    }
        //    else
        //    {
        //        //direct post upload (user is logged in)
        //        ViewData["confirmationNote"] = Request.Cookies["DirectPostUpload"] + User.Identity.Name;
        //    }

        //    //print all content to the end-user (BLOG) page
        //    if (dalContent.Contents().Rows.Count > 0)
        //    {
        //        Posts = new List<Content>();
        //        Posts = cManagement.Posts();
        //    }
        //}
    }
}
