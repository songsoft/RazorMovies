#pragma checksum "D:\DevLearn\Razor\RazorPagesMovie\RazorPagesMovie\Pages\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d8eefadb9de6cf49b02f11216596a5002d3459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_Test), @"mvc.1.0.razor-page", @"/Pages/Test.cshtml")]
namespace RazorPagesMovie.Pages
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
#line 1 "D:\DevLearn\Razor\RazorPagesMovie\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d8eefadb9de6cf49b02f11216596a5002d3459", @"/Pages/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DevLearn\Razor\RazorPagesMovie\RazorPagesMovie\Pages\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Test</h1>\r\n\r\n<h3>This is a test page</h3>\r\n\r\n<h4>");
#nullable restore
#line 11 "D:\DevLearn\Razor\RazorPagesMovie\RazorPagesMovie\Pages\Test.cshtml"
Write(ViewData["TIME"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.TestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.TestModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
