#pragma checksum "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8932dedc0fdce6102ac28222440bc759359f3695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewSeasons), @"mvc.1.0.view", @"/Views/Home/ViewSeasons.cshtml")]
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
#line 1 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\_ViewImports.cshtml"
using WatchList.WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\_ViewImports.cshtml"
using WatchList.WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
using WatchList.Logic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8932dedc0fdce6102ac28222440bc759359f3695", @"/Views/Home/ViewSeasons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df7111592f2c7aecf145188ef19f314bf6ebe11d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewSeasons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WatchList.WebClient.Models.ListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeSeason", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSeason", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>\r\n    ");
#nullable restore
#line 6 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
Write(Model.UOW.Shows.Find(Model.ShowId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
            </th>
            <th>
                Score
            </th>
            <th>
                Status
            </th>
            <th>
                Episodes Watched
            </th>
            <th>
                Episodes Total
            </th>
            <th>
            </th>
            <th>
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
         foreach (var season in Model.UOW.Seasons.GetSeasonsInOrder(Model.ShowId))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                Season ");
#nullable restore
#line 37 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                  Write(season.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8932dedc0fdce6102ac28222440bc759359f36956454", async() => {
                WriteLiteral("\r\n                <td>\r\n                    <select name=\"ScoreNum\">\r\n");
#nullable restore
#line 42 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                         for (int i = 0; i < 11; i++)
                        {
                            if (season.Score == i)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8932dedc0fdce6102ac28222440bc759359f36957208", async() => {
#nullable restore
#line 46 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8932dedc0fdce6102ac28222440bc759359f36959585", async() => {
#nullable restore
#line 50 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                                              Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
               Write(season.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"number\" name=\"EpisodeWatch\"");
                BeginWriteAttribute("value", " value=\"", 1615, "\"", 1646, 1);
#nullable restore
#line 59 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
WriteAttributeValue("", 1623, season.EpisodesWatched, 1623, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <label>/</label>\r\n                    ");
#nullable restore
#line 63 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
               Write(season.EpisodeAmt);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"number\" name=\"SeasonId\"");
                BeginWriteAttribute("value", " value=\"", 1876, "\"", 1900, 1);
#nullable restore
#line 66 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
WriteAttributeValue("", 1884, season.SeasonId, 1884, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden=\"hidden\" />\r\n                    <input type=\"Submit\" value=\"Save\" class=\"btn-dark\" />\r\n                </td>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8932dedc0fdce6102ac28222440bc759359f369515148", async() => {
                WriteLiteral("\r\n                    <input type=\"number\" name=\"SeasonId\"");
                BeginWriteAttribute("value", " value=\"", 2165, "\"", 2189, 1);
#nullable restore
#line 72 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
WriteAttributeValue("", 2173, season.SeasonId, 2173, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden=\"hidden\" />\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn-danger\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 77 "C:\Users\4400112045\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\ViewSeasons.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WatchList.WebClient.Models.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591