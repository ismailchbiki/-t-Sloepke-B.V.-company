using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Dutch_Experience.Pages
{
    public class ContactModel : PageModel
    {
        //[BindProperty]
        //public Contact Contact { get; set; }

        ////Testing
        //public string Text;

        //public void OnPost(StringBuilder strBuilder) //dependency injection
        //{
        //    // using string builder
        //    strBuilder.Append("Thank you " + Contact.Username + " for your email.\nWe will write you in: " + Contact.Email + " as soon as possible");
            
        //    //print to screen
        //    Text = strBuilder.ToString();
        //}
    }
}
