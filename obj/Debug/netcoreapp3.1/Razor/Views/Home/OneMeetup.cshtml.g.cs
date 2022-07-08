#pragma checksum "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9f79712b76ed6051c994c03f0c98ad7907f118"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneMeetup), @"mvc.1.0.view", @"/Views/Home/OneMeetup.cshtml")]
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
#line 1 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\_ViewImports.cshtml"
using Belt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\_ViewImports.cshtml"
using Belt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9f79712b76ed6051c994c03f0c98ad7907f118", @"/Views/Home/OneMeetup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e4a4d40ef26079d3b4684d0bc32675f7e799b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneMeetup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meetup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMeetup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitUnRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
  bool alreadyJoined = Model.Attendees.Any(rsvp => rsvp.UserId == ViewBag.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"Display-2\">");
#nullable restore
#line 4 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n    <div class=\"ml-4\">\r\n        <h3 class=\"Display-3\">Event Coordinator: ");
#nullable restore
#line 8 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
                                            Write(Model.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <div class=\"mb-3\">\r\n            <h3 class=\"Display-3\">Description:</h3>\r\n            <h4 class=\"lead ml-2\"> ");
#nullable restore
#line 11 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n        <h3 class=\"Display-3\">Participants:</h3>\r\n        <div>\r\n");
#nullable restore
#line 15 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
             foreach (var rsvp in Model.Attendees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"lead ml-2\">");
#nullable restore
#line 17 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
                                Write(rsvp.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
     if(Model.CreatorId == ViewBag.UserId)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9f79712b76ed6051c994c03f0c98ad7907f1187266", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("Value", " Value = \"", 848, "\"", 873, 1);
#nullable restore
#line 25 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 858, ViewBag.UserId, 858, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"MeetupId\"");
                BeginWriteAttribute("Value", " Value = \"", 925, "\"", 950, 1);
#nullable restore
#line 26 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 935, Model.MeetupId, 935, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <td><button type=\"submit class=\"btn btn-link\">Delete</button></td>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
        }  
        else if(!alreadyJoined)                        
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9f79712b76ed6051c994c03f0c98ad7907f11810377", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("Value", " Value = \"", 1258, "\"", 1283, 1);
#nullable restore
#line 33 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 1268, ViewBag.UserId, 1268, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"MeetupId\"");
                BeginWriteAttribute("Value", " Value = \"", 1335, "\"", 1360, 1);
#nullable restore
#line 34 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 1345, Model.MeetupId, 1345, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <td><button type=\"submit class=\"btn btn-link\">RSVP</button></td>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9f79712b76ed6051c994c03f0c98ad7907f11813444", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("Value", " Value = \"", 1617, "\"", 1642, 1);
#nullable restore
#line 40 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 1627, ViewBag.UserId, 1627, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"MeetupId\"");
                BeginWriteAttribute("Value", " Value = \"", 1694, "\"", 1719, 1);
#nullable restore
#line 41 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 1704, Model.MeetupId, 1704, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <td><button type=\"submit class=\"btn btn-link\">Un-RSVP</button></td>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\OneMeetup.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meetup> Html { get; private set; }
    }
}
#pragma warning restore 1591
