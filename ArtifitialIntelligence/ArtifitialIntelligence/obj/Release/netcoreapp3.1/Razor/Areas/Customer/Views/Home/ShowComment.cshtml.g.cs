#pragma checksum "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "397a5f3ffeb6fb4825b7f64f4895acdf72ede6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_ShowComment), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/ShowComment.cshtml")]
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
#line 1 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\_ViewImports.cshtml"
using ArtifitialIntelligence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\_ViewImports.cshtml"
using ArtifitialIntelligence.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397a5f3ffeb6fb4825b7f64f4895acdf72ede6c0", @"/Areas/Customer/Views/Home/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"812e3fdbffd9717063f4afaf793ee256a3d5fa4b", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ArtifitialIntelligence.Models.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"
  
    ViewBag.Title = "ShowComment";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<script type=""text/javascript"">

    function CRateOut(rating) {
        for (var i = 1; i <= rating; i++) {
            $(""#span"" + i).attr('class', 'glyphicon glyphicon-star-empty');
        }

    }

    function CRateOver(rating) {
        for (var i = 1; i <= rating; i++) {
            $(""#span"" + i).attr('class', 'glyphicon glyphicon-star');
        }
    }

    function CRateClick(rating) {
        $(""#lblRating"").val(rating);
        for (var i = 1; i <= rating; i++) {
            $(""$span"" + i).attr('class', 'glyphicon glyphicon-star');
        }
        for (var i = rating + 1; i <= 5; i++) {
            $(""#span"" + i).attr('class', 'glyphicon glyphicon-star-empty');
        }
    }

    function CRateSelected() {
        var rating = $(""#lblRating"").val();
        for (var i = 1; i <= rating; i++) {
            $(""#span"" + i).attr('class', 'glyphicon glyphicon-star');
        }
    }

    function VerifyRating() {
        var rating = $(""#lblRating"")");
            WriteLiteral(".val();\r\n        if (rating == \"0\") {\r\n            alert(\"Please Select Rating\");\r\n            return false;\r\n        }\r\n    }\r\n</script>\r\n\r\n<h4>ShowComment</h4>\r\n");
#nullable restore
#line 50 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"
 foreach (var data in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"
Write(Html.Partial("_CommentPartial", data));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"
                                          

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Please Enter your valuable Comment Below :</h4>\r\n");
#nullable restore
#line 56 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"
 using (Html.BeginForm("AddComment", "Home", FormMethod.Post, new { onsubmit = "return VerifyRating()" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <textarea rows=""6"" cols=""50"" name=""productComment"" id=""txtProductComment""></textarea>
    <div onmouseout=""CRateSelected()"">
        <span id=""span1"" onmouseout=""CRateOut(1)"" onmouseover=""CRateOver(1)"" onclick=""CRateClick(1)"" class=""glyphicon glyphicon-star-empty""></span>
        <span id=""span2"" onmouseout=""CRateOut(2)"" onmouseover=""CRateOver(2)"" onclick=""CRateClick(2)"" class=""glyphicon glyphicon-star-empty""></span>
        <span id=""span3"" onmouseout=""CRateOut(3)"" onmouseover=""CRateOver(3)"" onclick=""CRateClick(3)"" class=""glyphicon glyphicon-star-empty""></span>
        <span id=""span4"" onmouseout=""CRateOut(4)"" onmouseover=""CRateOver(4)"" onclick=""CRateClick(4)"" class=""glyphicon glyphicon-star-empty""></span>
        <span id=""span5"" onmouseout=""CRateOut(5)"" onmouseover=""CRateOver(5)"" onclick=""CRateClick(5)"" class=""glyphicon glyphicon-star-empty""></span>
    </div>
    <div>
        <input type=""hidden"" name=""rating"" id=""lblRating"" value=""0"" />
    </div>
    <div>
        <input type=""hidden"" n");
            WriteLiteral("ame=\"id\" id=\"lblRating\"");
            BeginWriteAttribute("value", " value=\"", 2584, "\"", 2610, 1);
#nullable restore
#line 70 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"
WriteAttributeValue("", 2592, ViewBag.ProductId, 2592, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" class=\" btn btn-primary active\" name=\"SaveComment\" value=\"Submit Comment\" />\r\n    </div>\r\n");
#nullable restore
#line 75 "E:\Artifitial Intelligence\ArtifitialIntelligence\ArtifitialIntelligence\Areas\Customer\Views\Home\ShowComment.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ArtifitialIntelligence.Models.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591