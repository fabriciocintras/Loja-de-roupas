#pragma checksum "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb2cb65ef6df5594e58d13ae564afdb3a9ef17f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_carrinho), @"mvc.1.0.view", @"/Views/Home/carrinho.cshtml")]
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
#line 1 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\_ViewImports.cshtml"
using etapa_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\_ViewImports.cshtml"
using etapa_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb2cb65ef6df5594e58d13ae564afdb3a9ef17f", @"/Views/Home/carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cc4639cc483b3d6cc0ec22398510e95e9994f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<itemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produtos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div id=""carrinho"">
    <h2 > Pedido </h2>

    <table class=""tabela"">
        <thead>
            <tr>
                <th>Descrição</th>
                <th>Quantidade</th>
                <th>Tamanho</th>
                <th>Valor</th>
            </tr>
   </thead>
   <tbody>
");
#nullable restore
#line 17 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
        foreach(itemPedido a in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 20 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
          Write(a.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 21 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
          Write(a.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 22 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
          Write(a.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 23 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
          Write(a.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n   </tbody>\r\n   \r\n</table>\r\n    <h2 >Valor Total: ");
#nullable restore
#line 30 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\carrinho.cshtml"
                 Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeb2cb65ef6df5594e58d13ae564afdb3a9ef17f5797", async() => {
                WriteLiteral("Cadastrar novo pedido");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<itemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
