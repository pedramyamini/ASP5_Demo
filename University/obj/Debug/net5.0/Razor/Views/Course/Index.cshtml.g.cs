#pragma checksum "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc88755e3031e07da1b1680a8969698742caa40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\Pedram\source\repos\Raymon\University\Views\_ViewImports.cshtml"
using University;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedram\source\repos\Raymon\University\Views\_ViewImports.cshtml"
using University.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
using PagedList.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc88755e3031e07da1b1680a8969698742caa40", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be6e1d28ebfea77e0e20e91cb5493838aa64980", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "دوره‌ها";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>دوره‌ها</h3>\r\n\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 142, "\"", 187, 3);
            WriteAttributeValue("", 152, "showModal(\'", 152, 11, true);
#nullable restore
#line 10 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
WriteAttributeValue("", 163, Url.Action("Upsert"), 163, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 184, "\');", 184, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mt-3\"> افزودن </button>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"course-grid\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
   Write(await Html.PartialAsync("_CourseGrid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center mt-3\"> دانشجویی یافت نشد. </p>\r\n");
#nullable restore
#line 21 "C:\Users\Pedram\source\repos\Raymon\University\Views\Course\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
