#pragma checksum "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838006a20f683a3fc48a55aa2e42efdd576a8e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PizzaIngredients_Create), @"mvc.1.0.view", @"/Views/PizzaIngredients/Create.cshtml")]
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
#line 7 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
using MarioPizzeria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838006a20f683a3fc48a55aa2e42efdd576a8e89", @"/Views/PizzaIngredients/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d560477386389832d44a9270570c4a102fc6940d", @"/Views/_ViewImports.cshtml")]
    public class Views_PizzaIngredients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MarioPizzeria.Models.PizzaIngredient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
  
    List<IngredientCheckbox> ingredientsOnPizza = ViewData["Ingredients"] as List<IngredientCheckbox>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
 foreach (var item in ViewContext.ViewData.ModelState)
{
    if (item.Value.Errors.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><b style=\"color:red\">");
#nullable restore
#line 16 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
                                Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
            Write((item.Value != null || item.Value.RawValue != null) ? "" : item.Value.RawValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
            Write(string.Join("; ", item.Value.Errors.Select(x => x.ErrorMessage)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>PizzaIngredient</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838006a20f683a3fc48a55aa2e42efdd576a8e897764", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838006a20f683a3fc48a55aa2e42efdd576a8e898034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 30 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838006a20f683a3fc48a55aa2e42efdd576a8e899787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 32 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PizzaId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838006a20f683a3fc48a55aa2e42efdd576a8e8911410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 33 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PizzaId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 33 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.PizzaId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
             foreach (IngredientCheckbox ingredient in ingredientsOnPizza)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-check\" style=\"margin-bottom:10px\">\r\n                    <input type=\"checkbox\" class=\"form-check-input\"");
                BeginWriteAttribute("value", " value=\"", 1320, "\"", 1352, 1);
#nullable restore
#line 38 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
WriteAttributeValue("", 1328, ingredient.IngredientId, 1328, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1353, "\"", 1382, 1);
#nullable restore
#line 38 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
WriteAttributeValue("", 1358, ingredient.IngredientId, 1358, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"NewIngredients\"");
                BeginWriteAttribute("checked", " \r\n                           checked=", 1405, "", 1479, 1);
#nullable restore
#line 39 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
WriteAttributeValue("", 1443, ingredient.IsChecked ? true:false, 1443, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1535, "\"", 1565, 1);
#nullable restore
#line 40 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
WriteAttributeValue("", 1541, ingredient.IngredientId, 1541, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 41 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
                   Write(ingredient.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </label>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                \r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <button type=\"button\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1942, "\"", 1998, 3);
            WriteAttributeValue("", 1952, "location.href=\'", 1952, 15, true);
#nullable restore
#line 54 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
WriteAttributeValue("", 1967, Url.Action("Index", "Pizzas"), 1967, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1997, "\'", 1997, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back to list</button>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Damian\Documents\NetBeansProjects\MarioPizzeria\MarioPizzeria\Views\PizzaIngredients\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarioPizzeria.Models.PizzaIngredient> Html { get; private set; }
    }
}
#pragma warning restore 1591
