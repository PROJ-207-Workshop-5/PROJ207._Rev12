#pragma checksum "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ebc179ff0aa3cdbf12bd3b17308daf377ed7670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\_ViewImports.cshtml"
using Workshop5.Rev2.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\_ViewImports.cshtml"
using Workshop5.Rev2.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ebc179ff0aa3cdbf12bd3b17308daf377ed7670", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c8bb9f0adfe0ca473aa585be6b855e0e1dd80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Workshop5.Rev2.Data.Domain.Packages>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <h1 id=\"uxPackageMessage\">Package Details</h1>\n    <hr />\n    <div class=\"card\">\n        <img id=\"uxImageDisplay\"");
            BeginWriteAttribute("src", " src=\"", 204, "\"", 236, 1);
#nullable restore
#line 9 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
WriteAttributeValue("", 210, Url.Content(@Model.Photo), 210, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 237, "\"", 265, 1);
#nullable restore
#line 9 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
WriteAttributeValue("", 243, Model.AlternativeText, 243, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:400px; max-height:400px;\" />\n        <div class=\"card-body\">\n            <table id=\"uxDetailDisplay\" class=\"table-bordered table col-sm-6\">\n                <tr>\n                    <td> ");
#nullable restore
#line 13 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                    Write(Html.DisplayNameFor(model => model.PkgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td> ");
#nullable restore
#line 14 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                    Write(Html.DisplayFor(model => model.PkgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td> ");
#nullable restore
#line 17 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                    Write(Html.DisplayNameFor(model => model.PkgStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 19 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Model.PkgStartDate.Value.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>");
#nullable restore
#line 22 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PkgEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 24 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Model.PkgEndDate.Value.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>");
#nullable restore
#line 27 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PkgDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PkgDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>");
#nullable restore
#line 31 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PkgBasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PkgBasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n            </table>\n            <div id=\"uxConfirm\" class=\"text-center\">\n                <span id=\"uxButton\" class=\"btn btn-success\">");
#nullable restore
#line 36 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Home\Details.cshtml"
                                                       Write(Html.ActionLink("Confirm Booking", "Booking", "Bookings", new { Packageid = Model.PackageId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ebc179ff0aa3cdbf12bd3b17308daf377ed76709144", async() => {
                WriteLiteral("Return to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Workshop5.Rev2.Data.Domain.Packages> Html { get; private set; }
    }
}
#pragma warning restore 1591
