#pragma checksum "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92097c8180c0fb658b2dcf5d10003e383252d9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentPartial), @"mvc.1.0.view", @"/Views/Shared/_CommentPartial.cshtml")]
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
#line 1 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\_ViewImports.cshtml"
using ArtifitialIntelligence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\_ViewImports.cshtml"
using ArtifitialIntelligence.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92097c8180c0fb658b2dcf5d10003e383252d9b8", @"/Views/Shared/_CommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"812e3fdbffd9717063f4afaf793ee256a3d5fa4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__CommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtifitialIntelligence.Models.Comment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table style=\"width:100%; border:1px solid black\">\r\n    <tr>\r\n        <td>  ");
#nullable restore
#line 5 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml"
         Write(Model.CommentedOn.ToString("dd-mm-yyyy HH:MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td> ");
#nullable restore
#line 9 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml"
        Write(Model.CommentDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n");
#nullable restore
#line 14 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml"
             for (int i = 1; i <= @Model.Rating; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star\"></span>\r\n");
#nullable restore
#line 17 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml"
             for (int i = @Model.Rating + 1; i <= 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star-empty\"></span>\r\n");
#nullable restore
#line 21 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Views\Shared\_CommentPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n\r\n    </tr>\r\n\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtifitialIntelligence.Models.Comment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591