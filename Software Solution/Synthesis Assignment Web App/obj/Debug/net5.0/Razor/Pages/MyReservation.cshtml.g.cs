#pragma checksum "\\Mac\Home\Desktop\Git\Synthesis Assignment\Software Solution\Synthesis Assignment Web App\Pages\MyReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4831afee5382cabcb911518a4549431f20cf55fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Synthesis_Assignment_Web_App.Pages.Pages_MyReservation), @"mvc.1.0.razor-page", @"/Pages/MyReservation.cshtml")]
namespace Synthesis_Assignment_Web_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "\\Mac\Home\Desktop\Git\Synthesis Assignment\Software Solution\Synthesis Assignment Web App\Pages\_ViewImports.cshtml"
using Synthesis_Assignment_Web_App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4831afee5382cabcb911518a4549431f20cf55fd", @"/Pages/MyReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2bf3c5781df2936b7e6e5954db0dcf4530c750", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyReservation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>\r\n    Your reference number of your reservation is: ");
#nullable restore
#line 11 "\\Mac\Home\Desktop\Git\Synthesis Assignment\Software Solution\Synthesis Assignment Web App\Pages\MyReservation.cshtml"
                                             Write(Model.Quote.RefNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Please save it to access your booking details\r\n</h2>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Synthesis_Assignment_Web_App.Pages.MyReservationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Synthesis_Assignment_Web_App.Pages.MyReservationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Synthesis_Assignment_Web_App.Pages.MyReservationModel>)PageContext?.ViewData;
        public Synthesis_Assignment_Web_App.Pages.MyReservationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
