#pragma checksum "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43ec7d2dbdff8bb9edde5c76450be483828bc47f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetBooks), @"mvc.1.0.view", @"/Views/Admin/GetBooks.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\_ViewImports.cshtml"
using AuthLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\_ViewImports.cshtml"
using AuthLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43ec7d2dbdff8bb9edde5c76450be483828bc47f", @"/Views/Admin/GetBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"858236a98b196d282885822e862be6723a1e9907", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AuthLibrary.Models.BookEntities.Book>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
  
    ViewData["Title"] = "GetBooks";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetBooks</h1>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <div class=\"contanier\">\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th> ");
#nullable restore
#line 16 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 18 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 20 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 21 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 22 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.CallNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 23 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                Write(Html.DisplayNameFor(model => model.MaxIssueDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
             foreach (var details in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.CallNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
                   Write(Html.DisplayFor(model => details.MaxIssueDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n   \r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 89 "C:\Users\admin\source\repos\AuthLibrary\AuthLibrary\Views\Admin\GetBooks.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43ec7d2dbdff8bb9edde5c76450be483828bc47f10100", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AuthLibrary.Models.BookEntities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
