#pragma checksum "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52b2bb93c0ecbcc1e970fe216fa9c828834b44a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/_ViewImports.cshtml"
using BethanysPies.Models;

#line default
#line hidden
#line 2 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/_ViewImports.cshtml"
using BethanysPies.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b2bb93c0ecbcc1e970fe216fa9c828834b44a0", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8770d8fd18aeb0ec30729e44875a1785a7e84b2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(17, 10, false);
#line 3 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(27, 37, true);
            WriteLiteral("</h2>\n\n<div class=\"thumbnail\">\n  <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 64, "\"", 85, 1);
#line 6 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml"
WriteAttributeValue("", 70, Model.ImageUrl, 70, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 86, "\"", 103, 1);
#line 6 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml"
WriteAttributeValue("", 92, Model.Name, 92, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(104, 83, true);
            WriteLiteral(" />\n  <div class=\"caption-full\">\n    <h3 class=\"pull-right\">\n      <h3><a href=\"#\">");
            EndContext();
            BeginContext(188, 10, false);
#line 9 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(198, 20, true);
            WriteLiteral("</a></h3>\n      <h4>");
            EndContext();
            BeginContext(219, 22, false);
#line 10 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml"
     Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(241, 15, true);
            WriteLiteral("</h4>\n      <p>");
            EndContext();
            BeginContext(257, 21, false);
#line 11 "/Users/leeraulin/Dropbox/Projects/BethanysPies/Views/Home/Details.cshtml"
    Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(278, 31, true);
            WriteLiteral("</p>\n    </h3>\n  </div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
