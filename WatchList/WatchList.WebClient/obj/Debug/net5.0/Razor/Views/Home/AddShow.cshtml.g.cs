#pragma checksum "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ffa374310abd2838ab8986b70b587bd43b6f2b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddShow), @"mvc.1.0.view", @"/Views/Home/AddShow.cshtml")]
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
#line 1 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"
using WatchList.Logic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"
using WatchList.Logic.Database;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ffa374310abd2838ab8986b70b587bd43b6f2b3", @"/Views/Home/AddShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df7111592f2c7aecf145188ef19f314bf6ebe11d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WatchList.WebClient.Models.AddShowModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"
  

    ViewBag.Title = "Status Select";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"
 using (Html.BeginForm("AddShow", "Home")) {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n            \r\n            <label>Name: </label>\r\n            ");
#nullable restore
#line 18 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"
       Write(Html.TextBox("Name", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br/>\r\n\r\n\r\n            <label># of Seasons: </label>\r\n            <input type=\"number\" id=\"SeasonAmt\" name=\"SeasonAmt\" value=\"0\" />  <br/>\r\n\r\n\r\n            <label>Status: </label>\r\n            ");
#nullable restore
#line 26 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"
       Write(Html.DropDownList("StatusType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br/>\r\n\r\n        <p>\r\n\r\n            <input type=\"submit\" value=\"Submit\" />\r\n\r\n        </p>\r\n\r\n    </fieldset>\r\n");
#nullable restore
#line 35 "C:\Users\thegr\source\repos\CapstoneProject\WatchList\WatchList.WebClient\Views\Home\AddShow.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"






<!---
<form asp-action=""AddShow"" method=""get"">
    <label>Name: </label>
    <input type=""text"" asp-for=""Name"" value=""""/> <br/>

    <label>Seasons: </label>
    <input type=""number"" asp-for=""SeasonAmt"" value=""0"" /> <br/>

    <label>Status: </label>
    <select asp-for=""Status"" name=""SelectedStatus"" id=""SelectedStatus"">
        <option value=""0"">Plan To Watch</option>
        <option value=""1"">Watching</option>
        <option value=""2"">Finished</option>
    </select> <br/>
    <input type=""submit"" value=""Submit"" class=""btn btn-primary"" /> 
</form>
-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WatchList.WebClient.Models.AddShowModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
