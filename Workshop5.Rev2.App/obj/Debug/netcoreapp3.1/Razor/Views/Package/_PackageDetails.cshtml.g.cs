#pragma checksum "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e4f75d912ee7c281c6e495ce4a281d6e611090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Package__PackageDetails), @"mvc.1.0.view", @"/Views/Package/_PackageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4f75d912ee7c281c6e495ce4a281d6e611090", @"/Views/Package/_PackageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c8bb9f0adfe0ca473aa585be6b855e0e1dd80", @"/Views/_ViewImports.cshtml")]
    public class Views_Package__PackageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Workshop5.Rev2.Data.Domain.Packages>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <h4>Packages</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 8 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PackageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 11 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PackageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PkgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PkgStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PkgEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PkgDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgBasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PkgBasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgAgencyCommission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n           \n            ");
#nullable restore
#line 48 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayFor(model => model.PkgAgencyCommission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 51 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n");
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 1919, "\"", 1951, 1);
#nullable restore
#line 58 "C:\Users\hahne\Desktop\PROJ207._Rev12\PROJ207._Rev12\Workshop5.Rev2.App\Views\Package\_PackageDetails.cshtml"
WriteAttributeValue("", 1925, Url.Content(@Model.Photo), 1925, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:100px; max-height:100px;\" />\n          \n        </dd>\n       \n    </dl>\n</div>\n<div>\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e4f75d912ee7c281c6e495ce4a281d6e6110909438", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
