#pragma checksum "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dce3b59e88bfc3bc84e19006aa94192952ab207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizzas_Details), @"mvc.1.0.view", @"/Views/Pizzas/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dce3b59e88bfc3bc84e19006aa94192952ab207", @"/Views/Pizzas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d560477386389832d44a9270570c4a102fc6940d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizzas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MarioPizzeria.Models.Pizza>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><div>\r\n    <hr/>\r\n    <h6><b>");
#nullable restore
#line 9 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
      Write(Html.DisplayNameFor(model => model.PriceS));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>: ");
#nullable restore
#line 9 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
                                                       Write(Model.PriceS.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <h6><b>");
#nullable restore
#line 10 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
      Write(Html.DisplayNameFor(model => model.PriceM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>: ");
#nullable restore
#line 10 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
                                                       Write(Model.PriceM.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <h6><b>");
#nullable restore
#line 11 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
      Write(Html.DisplayNameFor(model => model.PriceL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>: ");
#nullable restore
#line 11 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
                                                       Write(Model.PriceL.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <h6><b>");
#nullable restore
#line 12 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
      Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>: ");
#nullable restore
#line 12 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
                                                      Write(Model.Crust);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <h6><b>Toppings</b></h6>\r\n    <ul>\r\n");
#nullable restore
#line 15 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
         foreach (var ingredient in ViewBag.PizzaIngredients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 17 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
           Write(ingredient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n<div>\r\n    <button type=\"button\" style=\"width:75px\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 734, "\"", 799, 3);
            WriteAttributeValue("", 744, "location.href=\'", 744, 15, true);
#nullable restore
#line 22 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
WriteAttributeValue("", 759, Url.Action("Edit", new {id=Model.Id }), 759, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 798, "\'", 798, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n    <button type=\"button\" style=\"margin-left:20px\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 887, "\"", 933, 3);
            WriteAttributeValue("", 897, "location.href=\'", 897, 15, true);
#nullable restore
#line 23 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\Pizzas\Details.cshtml"
WriteAttributeValue("", 912, Url.Action("Index"), 912, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 932, "\'", 932, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarioPizzeria.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
