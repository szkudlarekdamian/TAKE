#pragma checksum "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Ingredients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716b1ef13f43f0046c5639788535d2aaf9c3777a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Details), @"mvc.1.0.view", @"/Views/Ingredients/Details.cshtml")]
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
#line 1 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\_ViewImports.cshtml"
using MarioPizzeria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\_ViewImports.cshtml"
using MarioPizzeria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716b1ef13f43f0046c5639788535d2aaf9c3777a", @"/Views/Ingredients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d560477386389832d44a9270570c4a102fc6940d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MarioPizzeria.Models.Ingredient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Ingredients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Ingredient</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <button type=\"button\" style=\"width:75px\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 467, "\"", 532, 3);
            WriteAttributeValue("", 477, "location.href=\'", 477, 15, true);
#nullable restore
#line 22 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Ingredients\Details.cshtml"
WriteAttributeValue("", 492, Url.Action("Edit", new {id=Model.Id }), 492, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 531, "\'", 531, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n    <button type=\"button\" style=\"margin-left:20px\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 620, "\"", 666, 3);
            WriteAttributeValue("", 630, "location.href=\'", 630, 15, true);
#nullable restore
#line 23 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Ingredients\Details.cshtml"
WriteAttributeValue("", 645, Url.Action("Index"), 645, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 665, "\'", 665, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back to list</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarioPizzeria.Models.Ingredient> Html { get; private set; }
    }
}
#pragma warning restore 1591
