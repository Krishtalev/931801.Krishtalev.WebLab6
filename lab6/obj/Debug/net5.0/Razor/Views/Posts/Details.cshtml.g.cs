#pragma checksum "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
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
#line 1 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
using WebApplication8.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac149a0e6a120d05df3bd1c4be3fa2fe014a6da8", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195f33263845ab48ac39bf7972ff81be67288e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PostAttachments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PostComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var canEditPost = UserPermissions.CanEditPost(this.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"blog-post-details\">\n    <h1>");
#nullable restore
#line 11 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <div class=\"blog-post-info\">\n        ");
#nullable restore
#line 13 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
   Write(Model.Creator.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 13 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                             Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 13 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                    Write(Model.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 14 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
         if (canEditPost)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da87939", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("|");
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da810177", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 18 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <div class=\"blog-post-text\">");
#nullable restore
#line 21 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                           Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>\n\n<h3>Attachments</h3>\n\n");
#nullable restore
#line 26 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
 if (canEditPost)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da813167", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n");
#nullable restore
#line 31 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n");
#nullable restore
#line 34 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
     foreach (var item in Model.Attachments.OrderByDescending(x => x.Created))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6 col-md-4\">\n            <div class=\"thumbnail\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 1037, "\"", 1053, 1);
#nullable restore
#line 38 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1043, item.Path, 1043, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" />\n");
#nullable restore
#line 39 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                 if (canEditPost)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"caption\">\n                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da817041", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n                    </div>\n");
#nullable restore
#line 44 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n");
#nullable restore
#line 47 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<h3>Comments</h3>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da820091", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n\n<div class=\"blog-posts\">\n    <div class=\"blog-posts-items\">\n");
#nullable restore
#line 58 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
         foreach (var item in Model.Comments.OrderByDescending(x => x.Created))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-post panel panel-default\">\n                <div class=\"panel-heading\">\n                    <div>");
#nullable restore
#line 62 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                    Write(item.Creator.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 62 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                             Write(item.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 63 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                         if (UserPermissions.CanEditPostComment(item))
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("| ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da823973", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("| ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac149a0e6a120d05df3bd1c4be3fa2fe014a6da826425", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 66 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                                                                                                                  
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n                <div class=\"panel-body\">\n                    <div class=\"blog-post-text\">");
#nullable restore
#line 71 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
                                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n            </div>\n");
#nullable restore
#line 74 "C:\Users\nikita\Downloads\931802.reshetnikov.oleg.lab6-main\lab6\lab6\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserPermissionsService UserPermissions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
