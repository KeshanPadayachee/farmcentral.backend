#pragma checksum "E:\Studies\Varsity College\Year 3\Semester 1\PROG7311 - Programming 3A\Portfolio Of Evidence\Task 2\src\v2\com.farmcentral.be\com.farmcentral.be\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a22e13bdb01bc0d08a655d16a215f0b6a6580a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Edit), @"mvc.1.0.view", @"/Views/Products/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a22e13bdb01bc0d08a655d16a215f0b6a6580a", @"/Views/Products/Edit.cshtml")]
    #nullable restore
    public class Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<com.farmcentral.be.Models.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Studies\Varsity College\Year 3\Semester 1\PROG7311 - Programming 3A\Portfolio Of Evidence\Task 2\src\v2\com.farmcentral.be\com.farmcentral.be\Views\Products\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""ProductId"" />
            <div class=""form-group"">
                <label asp-for=""FarmerId"" class=""control-label""></label>
                <select asp-for=""FarmerId"" class=""form-control"" asp-items=""ViewBag.FarmerId""></select>
                <span asp-validation-for=""FarmerId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductName"" class=""control-label""></label>
                <input asp-for=""ProductName"" class=""form-control"" />
                <span asp-validation-for=""ProductName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductDescription"" class=""control-label""></label>
                <input asp-for=""P");
            WriteLiteral(@"roductDescription"" class=""form-control"" />
                <span asp-validation-for=""ProductDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductPrice"" class=""control-label""></label>
                <input asp-for=""ProductPrice"" class=""form-control"" />
                <span asp-validation-for=""ProductPrice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductQuantity"" class=""control-label""></label>
                <input asp-for=""ProductQuantity"" class=""form-control"" />
                <span asp-validation-for=""ProductQuantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductType"" class=""control-label""></label>
                <input asp-for=""ProductType"" class=""form-control"" />
                <span asp-validation-for=""ProductType"" class=""text-danger""></span>
       ");
            WriteLiteral("     </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "E:\Studies\Varsity College\Year 3\Semester 1\PROG7311 - Programming 3A\Portfolio Of Evidence\Task 2\src\v2\com.farmcentral.be\com.farmcentral.be\Views\Products\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<com.farmcentral.be.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
