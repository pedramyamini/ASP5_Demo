#pragma checksum "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36253cdaf0742e093ef988a27da1a3148de5f293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36253cdaf0742e093ef988a27da1a3148de5f293", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be6e1d28ebfea77e0e20e91cb5493838aa64980", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>دانشجویان</h3>\r\n\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 94, "\"", 139, 3);
            WriteAttributeValue("", 104, "showModal(\'", 104, 11, true);
#nullable restore
#line 8 "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml"
WriteAttributeValue("", 115, Url.Action("Upsert"), 115, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 136, "\');", 136, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mt-3\"> افزودن </button>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"student-grid\">\r\n       ");
#nullable restore
#line 13 "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml"
  Write(await Html.PartialAsync("_StudentGrid"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center mt-3\"> دانشجویی یافت نشد. </p>\r\n");
#nullable restore
#line 19 "C:\Users\Pedram\source\repos\Raymon\University\Views\Student\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
