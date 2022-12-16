#pragma checksum "/app/Views/SciFi/SciFi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88fa4d74ea0197a80705a547bf149a70a3cfaa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SciFi_SciFi), @"mvc.1.0.view", @"/Views/SciFi/SciFi.cshtml")]
namespace AspNetCore
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
#line 1 "/app/Views/_ViewImports.cshtml"
using code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/app/Views/_ViewImports.cshtml"
using code.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88fa4d74ea0197a80705a547bf149a70a3cfaa2", @"/Views/SciFi/SciFi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f871f661e145042bcf5388dc56523a26c657b51", @"/Views/_ViewImports.cshtml")]
    public class Views_SciFi_SciFi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/app/Views/SciFi/SciFi.cshtml"
  
    ViewData["Title"] = "Sci-Fi Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sci-Fi Movies</h1>\r\n\r\n<div id=\"movieCollection\" class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "/app/Views/SciFi/SciFi.cshtml"
         foreach (var movie in Model)
        {
            if (movie.Genre == "Sci-Fi")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"movie col-md-6\">\r\n                    <div class=\"movieTitle\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 373, "\"", 401, 1);
#nullable restore
#line 15 "/app/Views/SciFi/SciFi.cshtml"
WriteAttributeValue("", 379, movie.Poster.File.Url, 379, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 402, "\"", 427, 1);
#nullable restore
#line 15 "/app/Views/SciFi/SciFi.cshtml"
WriteAttributeValue("", 408, movie.Poster.Title, 408, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" />\r\n                        <h2 class=\"text-center\">");
#nullable restore
#line 16 "/app/Views/SciFi/SciFi.cshtml"
                                           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"movieInfo\">\r\n                        <p><b>Genre:</b> ");
#nullable restore
#line 19 "/app/Views/SciFi/SciFi.cshtml"
                                    Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Director:</b> ");
#nullable restore
#line 20 "/app/Views/SciFi/SciFi.cshtml"
                                       Write(movie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Actors:</b> ");
#nullable restore
#line 21 "/app/Views/SciFi/SciFi.cshtml"
                                     Write(movie.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Release Date:</b> ");
#nullable restore
#line 22 "/app/Views/SciFi/SciFi.cshtml"
                                           Write(movie.ReleaseDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Run Time:</b> ");
#nullable restore
#line 23 "/app/Views/SciFi/SciFi.cshtml"
                                       Write(movie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>IMDB Rating:</b> ");
#nullable restore
#line 24 "/app/Views/SciFi/SciFi.cshtml"
                                          Write(movie.IMDBRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("/10</p>\r\n                        <p><b>RT Rating:</b> ");
#nullable restore
#line 25 "/app/Views/SciFi/SciFi.cshtml"
                                        Write(movie.RTRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 28 "/app/Views/SciFi/SciFi.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
