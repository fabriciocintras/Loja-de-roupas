#pragma checksum "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\Produtos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94242acb1cf21707d6ef181680b90a5bc7d86098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Produtos), @"mvc.1.0.view", @"/Views/Home/Produtos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94242acb1cf21707d6ef181680b90a5bc7d86098", @"/Views/Home/Produtos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cc4639cc483b3d6cc0ec22398510e95e9994f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Produtos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "produtoDetalheQuik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "produtoDetalheAdidas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "produtoDetalheNike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "camisaDetalheOakley", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\Produtos.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"= ""Produtos"";

            <div id=""linkParaOFreteGratis"" style= ""margin-top:80px;"">
                <h3>FRETE GRATIS PARA TODOS OS ITENS DA LISTA </h3>
            </div>
            
<section class=""container"" style=""margin-top: 16px;"">
            <h1>
                Produtos:
            </h1>
            <div class=""containerConteudo"">
                <div class=""containerImagem"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94242acb1cf21707d6ef181680b90a5bc7d860985078", async() => {
                WriteLiteral("<img src=\"/imagensProdutos/AK2-0021-006_zoom1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 525, "\"", 531, 0);
                EndWriteAttribute();
                WriteLiteral(">");
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
            WriteLiteral(@"
                    <div class=""descricaoProduto"">
                        <p style=""padding: 10px 0;font-size: 18px;"">Camiseta basica Quiksilver Masculina</p>
                        <p><strong>R$: 49,99</strong></p>
                        <span>parcelamento em ate 4x 12,49</span>
                    </div>
                </div>
                <div class=""containerImagem"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94242acb1cf21707d6ef181680b90a5bc7d860986840", async() => {
                WriteLiteral("<img src=\"/imagensProdutos/COL-8580-012_zoom1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1033, "\"", 1039, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""descricaoProduto"">
                        <p style=""padding: 10px 0;font-size: 18px;"">Camiseta basica Adidas Masculina</p>
                        <p><strong>R$: 49,99</strong></p>
                        <span>parcelamento em ate 4x 12,49</span>
                    </div>
                </div>
                <div class=""containerImagem"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94242acb1cf21707d6ef181680b90a5bc7d860988600", async() => {
                WriteLiteral("<img src=\"/imagensProdutos/HZM-1091-026_zoom1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1535, "\"", 1541, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""descricaoProduto"">
                        <p style=""padding: 10px 0;font-size: 18px;"">Camiseta basica Nike <br>Masculina</p>
                        <p><strong>R$: 49,99</strong></p>
                        <span>parcelamento em ate 4x 12,49</span>
                    </div>
                </div>
                <div class=""containerImagem"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94242acb1cf21707d6ef181680b90a5bc7d8609810362", async() => {
                WriteLiteral("<img src=\"/imagensProdutos/photo-of-a-man-listening-music-on-his-phone-846741.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2072, "\"", 2078, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""descricaoProduto"">
                        <p style=""padding: 10px 0;font-size: 18px;"">Camiseta basica Oakley Masculina</p>
                        <p><strong>R$: 49,99</strong></p>
                        <span>parcelamento em ate 4x 12,49</span>
                    </div>
                </div>
            </div>
        </section>
        <div id=""faixaMarcas"">
            <h1>NOSSAS MARCAS</h1>
            <div class=""containerdasMarcas"">
                <div class=""circuloDeMarca""><a");
            BeginWriteAttribute("href", " href=\"", 2622, "\"", 2629, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/1280px-Adidas_Logo.svg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2673, "\"", 2679, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 2739, "\"", 2746, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/Nike-symbol-vector-400x400.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2794, "\"", 2800, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 2860, "\"", 2867, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/Oakley_logo.svg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2904, "\"", 2910, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 2970, "\"", 2977, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/quiksilver-logo-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3016, "\"", 3022, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n            </div>\r\n        </div>");
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
