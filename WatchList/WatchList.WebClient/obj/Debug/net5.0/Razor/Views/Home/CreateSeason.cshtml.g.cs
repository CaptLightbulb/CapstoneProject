#pragma checksum "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5268ffe0c44464a3fb8f818f992edef2d6926720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateSeason), @"mvc.1.0.view", @"/Views/Home/CreateSeason.cshtml")]
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
#line 1 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\_ViewImports.cshtml"
using WatchList.WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\_ViewImports.cshtml"
using WatchList.WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
using WatchList.Logic.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
using WatchList.Logic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5268ffe0c44464a3fb8f818f992edef2d6926720", @"/Views/Home/CreateSeason.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df7111592f2c7aecf145188ef19f314bf6ebe11d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateSeason : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WatchList.WebClient.Models.AddSeasonModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSeason", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
            </th>
            <th>
                Episodes Watched:
            </th>
            <th>
                Episodes Total:
            </th>
            <th>
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
          
            Season season = Model.UOW.Seasons.GetSeasonsInOrder(Model.ShowId).FirstOrDefault(s => s.EpisodeAmt == 0);  //creates a seperate form for every single season in the given show
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
         if(season != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                Season ");
#nullable restore
#line 29 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
                  Write(season.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5268ffe0c44464a3fb8f818f992edef2d69267205752", async() => {
                WriteLiteral("\r\n                    <td>\r\n                        <input type=\"number\" name=\"EpisodeWatch\"");
                BeginWriteAttribute("value", " value=\"", 926, "\"", 957, 1);
#nullable restore
#line 33 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
WriteAttributeValue("", 934, season.EpisodesWatched, 934, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"number\" name=\"EpisodeNum\"");
                BeginWriteAttribute("value", " value=\"", 1078, "\"", 1104, 1);
#nullable restore
#line 36 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
WriteAttributeValue("", 1086, season.EpisodeAmt, 1086, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"number\" name=\"SeasonId\"");
                BeginWriteAttribute("value", " value=\"", 1223, "\"", 1247, 1);
#nullable restore
#line 39 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
WriteAttributeValue("", 1231, season.SeasonId, 1231, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden=\"hidden\" />\r\n                        <input type=\"Submit\" value=\"Submit\" class=\"btn-dark\" />\r\n                    </td>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\CreateSeason.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WatchList.WebClient.Models.AddSeasonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
