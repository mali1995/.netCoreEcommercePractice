#pragma checksum "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditCategory), @"mvc.1.0.view", @"/Views/Admin/EditCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EditCategory.cshtml", typeof(AspNetCore.Views_Admin_EditCategory))]
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
#line 1 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI;

#line default
#line hidden
#line 2 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df713", @"/Views/Admin/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e789d86202787a6a7b3bcc76fb6660a1d9c6860", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminEditCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
  
    ViewData["Title"] = "EditCategory";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(131, 90, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Edit Category\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(221, 633, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df7137453", async() => {
                BeginContext(290, 47, true);
                WriteLiteral("\r\n        <div class=\"card-body\">\r\n            ");
                EndContext();
                BeginContext(338, 23, false);
#line 12 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(361, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(375, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df7138251", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(435, 52, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"CategoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 487, "\"", 512, 1);
#line 14 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 495, Model.CategoryId, 495, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(513, 59, true);
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(572, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df71310561", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 16 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(610, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(628, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df71312190", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 17 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(681, 166, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(854, 101, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Products\r\n    </div>\r\n\r\n");
            EndContext();
#line 31 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
     if (Model.Products.Count == 0)
    {

#line default
#line hidden
            BeginContext(999, 97, true);
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            No Products\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
    }
    else
    {


#line default
#line hidden
            BeginContext(1122, 438, true);
            WriteLiteral(@"        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Image</th>
                    <th>ProductName</th>
                    <th>IsApproved</th>
                    <th>IsHome</th>
                    <th>IsFeatured</th>
                    <th style=""width:155px;""></th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 54 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                 foreach (var item in Model.Products)
                {

#line default
#line hidden
            BeginContext(1634, 54, true);
            WriteLiteral("                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1689, 14, false);
#line 57 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                       Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1703, 65, true);
            WriteLiteral("</th>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1768, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df71317678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1778, "~/images/products/tn/", 1778, 21, true);
#line 59 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
AddHtmlAttributeValue("", 1799, item.Image, 1799, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1825, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(1887, 16, false);
#line 61 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1903, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 63 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                             if (item.IsApproved)
                            {

#line default
#line hidden
            BeginContext(2022, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 66 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2193, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 70 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(2295, 61, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 73 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                             if (item.IsHome)
                            {

#line default
#line hidden
            BeginContext(2434, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 76 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2605, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 80 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(2707, 61, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 83 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                             if (item.IsFeatured)
                            {

#line default
#line hidden
            BeginContext(2850, 75, true);
            WriteLiteral("                                <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 86 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3021, 71, true);
            WriteLiteral("                                <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 90 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(3123, 89, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3212, 450, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df71323106", async() => {
                BeginContext(3287, 88, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" id=\"CategoryId\" name=\"CategoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3375, "\"", 3400, 1);
#line 94 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 3383, Model.CategoryId, 3383, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3401, 89, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" id=\"ProductId\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3490, "\"", 3513, 1);
#line 95 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 3498, item.ProductId, 3498, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3514, 141, true);
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-danger btn-sm delete\">Remove</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3662, 144, true);
            WriteLiteral("\r\n\r\n                            <button class=\"btn btn-primary btn-sm\">Edit</button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 102 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"
                }

#line default
#line hidden
            BeginContext(3825, 42, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 106 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\EditCategory.cshtml"

    }

#line default
#line hidden
            BeginContext(3876, 41, true);
            WriteLiteral("\r\n    <div class=\"card-footer\">\r\n        ");
            EndContext();
            BeginContext(3917, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117cbdadb6ad3dd0fc9c0bddbd8ab7d3ce2df71327060", async() => {
                BeginContext(3991, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4001, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4050, 1052, true);
                WriteLiteral(@"
    <script>

        $("".delete"").click(function (event) {

            event.preventDefault();

            var form = $(this).parent();
            var row = form.parent(""td"").parent(""tr"");

            var token = $('input[name=""__RequestVerificationToken""]', form).val();
            var data = { categoryId: $(""#CategoryId"", form).val(), productId: $(""#ProductId"", form).val() };
            var dataWithToken = $.extend(data, { '__RequestVerificationToken': token });


            $.ajax({
                url: form.attr(""action""),
                data: dataWithToken,
                type: ""Post"",
                beforeSend: function () {
                    $(""#ajax-loader"").show();
                },
                complete: function () {
                    $(""#ajax-loader"").hide();
                },
                success: function () {
                    row.remove();
                },
                error: function () {

                }

            });

    ");
                WriteLiteral("    });\r\n\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(5105, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminEditCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
