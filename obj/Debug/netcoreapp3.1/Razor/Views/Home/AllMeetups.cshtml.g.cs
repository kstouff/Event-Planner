#pragma checksum "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010c3625a3f8bc85e9dfa8d7631f511f89bfb257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllMeetups), @"mvc.1.0.view", @"/Views/Home/AllMeetups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010c3625a3f8bc85e9dfa8d7631f511f89bfb257", @"/Views/Home/AllMeetups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e4a4d40ef26079d3b4684d0bc32675f7e799b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllMeetups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral(@"<div class=""container"">
        <h3 class=""Display-3"">Welcome to the Coding Dojo Meetups</h3>
        
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Meet Up</th>
                        <th scope=""col"">Date and Time</th>
                        <th scope=""col"">Duration</th>
                        <th scope=""col"">Event Coordinator</th>
                        <th scope=""col"">No. of Participants</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 16 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                         foreach (Meetup meetup in ViewBag.allMeetups)
                        {
                            bool alreadyJoined = meetup.Attendees.Any(rsvp => rsvp.UserId == ViewBag.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\" class=\"lead\"><a");
            BeginWriteAttribute("href", " href=\"", 921, "\"", 953, 2);
            WriteAttributeValue("", 928, "/meetups/", 928, 9, true);
#nullable restore
#line 20 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 937, meetup.MeetupId, 937, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                                                                                        Write(meetup.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n                            <td class=\"lead\">");
#nullable restore
#line 21 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                                        Write(meetup.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"lead\">");
#nullable restore
#line 22 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                                        Write(meetup.DurationLength);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                                                               Write(meetup.DurationDenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"lead\">");
#nullable restore
#line 23 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                                        Write(meetup.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"lead\">");
#nullable restore
#line 24 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                                        Write(meetup.Attendees.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                             if(meetup.CreatorId == ViewBag.UserId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010c3625a3f8bc85e9dfa8d7631f511f89bfb2578622", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("Value", " Value = \"", 1554, "\"", 1579, 1);
#nullable restore
#line 28 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 1564, ViewBag.UserId, 1564, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"hidden\" name=\"MeetupId\"");
                BeginWriteAttribute("Value", " Value = \"", 1651, "\"", 1677, 1);
#nullable restore
#line 29 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 1661, meetup.MeetupId, 1661, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <td><button type=\"submit class=\"btn btn-link\">Delete</button></td>\r\n                            ");
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
#line 32 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                            }  
                            else if(!alreadyJoined)                        
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010c3625a3f8bc85e9dfa8d7631f511f89bfb25711905", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("Value", " Value = \"", 2125, "\"", 2150, 1);
#nullable restore
#line 36 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 2135, ViewBag.UserId, 2135, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"hidden\" name=\"MeetupId\"");
                BeginWriteAttribute("Value", " Value = \"", 2222, "\"", 2248, 1);
#nullable restore
#line 37 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 2232, meetup.MeetupId, 2232, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <td><button type=\"submit class=\"btn btn-link\">RSVP</button></td>\r\n                                ");
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
#line 40 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010c3625a3f8bc85e9dfa8d7631f511f89bfb25715116", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("Value", " Value = \"", 2625, "\"", 2650, 1);
#nullable restore
#line 43 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 2635, ViewBag.UserId, 2635, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"hidden\" name=\"MeetupId\"");
                BeginWriteAttribute("Value", " Value = \"", 2722, "\"", 2748, 1);
#nullable restore
#line 44 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
WriteAttributeValue("", 2732, meetup.MeetupId, 2732, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <td><button type=\"submit class=\"btn btn-link\">Un-RSVP</button></td>\r\n                                ");
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
#line 47 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\ID139\OneDrive\Desktop\coding_dojo\c#\.net_core\Belt\Views\Home\AllMeetups.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        \r\n        \r\n        <div class=\"d-flex justify-content-end\">\r\n            <a href=\"/addMeetup\" class=\"btn btn-primary\" role=\"button\">Create New Meetup</a>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
